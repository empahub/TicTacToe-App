using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Data;

namespace TicTacToe.WinApp
{
    public partial class frmHomeScreen : Form
    {
        private Players player;



        public frmHomeScreen(Players players)
        {
            InitializeComponent();
            this.player = players;
        }

        private void frmHomeScreen_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Helpers.Extensions.ToImage(Resources.Resource1.StartImage);
            this.BackgroundImageLayout = ImageLayout.Stretch;

            lblUsername.Text = player.Username;
            pbPicture.Image = Helpers.Extensions.ToImage(player.Picture);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Hide();
            var editProfile = new frmEditProfile(player);

            editProfile.ShowDialog();

            lblUsername.Text = player.Username;
            pbPicture.Image = Helpers.Extensions.ToImage(player.Picture);

            Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Hide();
            var pickDifficulty = new frmPickDifficulty(player);
            pickDifficulty.ShowDialog();
            Show();
        }
    }
}
