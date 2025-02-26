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
using static System.Net.Mime.MediaTypeNames;

namespace TicTacToe.WinApp
{
    public partial class frmEditProfile : Form
    {

        TicTacToeDBContext db=new TicTacToeDBContext();

        private Players player;

       

        public frmEditProfile(Players player1)
        {
            InitializeComponent();
            this.player = player1;
        }

        private void frmEditProfile_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Helpers.Extensions.ToImage(Resources.Resource1.StartImage);
            this.BackgroundImageLayout = ImageLayout.Stretch;

            pbPicture.Image = Helpers.Extensions.ToImage(player.Picture);
            txtUsername.Text = player.Username;
            txtEmail.Text = player.Email;

        }

        private void btnProfilePicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbPicture.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validation())
            {

                this.player.Picture=Helpers.Extensions.toByteArray(pbPicture.Image);
                this.player.Username=txtUsername.Text;
                this.player.Email=txtEmail.Text;

                db.Players.Update(this.player);
                db.SaveChanges();
                lblError.Text = "Change Succesful";
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
            string regexEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            ;
            if (!Regex.IsMatch(txtEmail.Text, regexEmail))
            {
                lblError.Text = "Incorrect Email Fromat";
                return false;
            }

            var Players = db.Players.Where(x=>x.Id!=player.Id).ToList();

            for (int i = 0; i < Players.Count(); i++)
            {
                var player1 = Players[i];

                if (!string.Equals(player.Username, txtUsername.Text))
                {
                    if (string.Equals(player.Username, txtUsername.Text))
                    {
                        lblError.Text = "Username taken";
                        return false;
                    }
                }

                if (!string.Equals(player1.Email, txtEmail.Text))
                {
                    if (string.Equals(player1.Email, txtEmail.Text))
                    {
                        lblError.Text = "Email already in use";
                        return false;
                    }
                }


            }

            return true;
        }
    }
}
