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
using TicTacToe.Infrastructure;

namespace TicTacToe.WinApp
{
    public partial class frmPickDifficulty : Form
    {
        TicTacToeDBContext db = new TicTacToeDBContext();
        List<NonPlayable> nonPlayable = new List<NonPlayable>();
        private Players player;



        public frmPickDifficulty(Players player)
        {
            InitializeComponent();
            this.player = player;
        }

        private void frmPickDifficulty_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Helpers.Extensions.ToImage(Resources.Resource1.StartImage);
            this.BackgroundImageLayout = ImageLayout.Stretch;

            nonPlayable = db.NonPlayable.ToList();

            pbEasy.Image = Helpers.Extensions.ToImage(nonPlayable[0].Picture);
            pbMedium.Image = Helpers.Extensions.ToImage(nonPlayable[1].Picture);
            pbImpossible.Image = Helpers.Extensions.ToImage(nonPlayable[2].Picture);

            lblEasy.Text = nonPlayable[0].Name;
            lblMedium.Text = nonPlayable[1].Name;
            lblImpossible.Text = nonPlayable[2].Name;

        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            Hide();
            var Play = new frmPlay(nonPlayable[0],player);
            Play.ShowDialog();
            Close();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            Hide();
            var Play = new frmPlay(nonPlayable[1],player);
            Play.ShowDialog();
            Close();
        }

        private void btnImpossible_Click(object sender, EventArgs e)
        {
            Hide();
            var Play = new frmPlay(nonPlayable[2],player);
            Play.ShowDialog();
            Close();
        }
    }
}
