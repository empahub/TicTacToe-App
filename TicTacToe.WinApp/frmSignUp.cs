using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Data;
using TicTacToe.Infrastructure;

namespace TicTacToe.WinApp
{
    public partial class frmSignUp : Form
    {
        TicTacToeDBContext db=new TicTacToeDBContext();
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Helpers.Extensions.ToImage(Resources.Resource1.StartImage);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            
            pbImage.Image = Helpers.Extensions.ToImage( Resources.Resource1.ProfilePic);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (Validation())
            {

                var newGame = new Games
                {
                    Win = 0,
                    Lose = 0,
                    Draw=0
                    
                };
                
                db.Games.Add(newGame);
                db.SaveChanges();

                    var player = new Players
                    {
                        Email = txtEmail.Text,
                        Username = txtUsername.Text,
                        Password = txtPassword.Text,
                        Picture=Helpers.Extensions.toByteArray(pbImage.Image),
                        GameId=newGame.Id,

                    };
                    db.Players.Add(player);
                    db.SaveChanges();

                MessageBox.Show("You Signed in Successfully");

                Close();

            }
        }

        private bool Validation()
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                lblError.Text = "Username is Empty";
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                lblError.Text = "Email is Empty";
                return false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblError.Text = "Password is Empty";
                return false;
            }
            string regex = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            ;
            if(!Regex.IsMatch(txtEmail.Text, regex))
            {
                lblError.Text = "Incorrect Email Fromat";
                return false;
            }



            return true;
        }

        private void pbImage_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbImage.Image=Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
