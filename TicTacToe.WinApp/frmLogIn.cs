using TicTacToe.Data;
using TicTacToe.Infrastructure;

namespace TicTacToe.WinApp
{
    public partial class frmLogIn : Form
    {
        TicTacToeDBContext db=new TicTacToeDBContext();
        List<Players> players = new List<Players>();

        public frmLogIn()
        {
            InitializeComponent();
        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Helpers.Extensions.ToImage(Resources.Resource1.StartImage);
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Hide();
            var newForm = new frmSignUp();
            newForm.ShowDialog();
            Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            
            players=db.Players.Where(x=>string.Equals(txtUsername.Text,x.Username) || string.Equals(txtUsername.Text, x.Email)).ToList();

            if (players.Count == 0) {

                lblWarning.Text = "Wrong username or email";
                return;
            }
            
            
            lblWarning.Text = "";

            players = db.Players.Where(x => (string.Equals(txtUsername.Text, x.Username) || string.Equals(txtUsername.Text, x.Email)) && string.Equals(txtPassword.Text, x.Password)).ToList();



            if (players.Count == 0)
            {

                lblWarning.Text = "Wrong password";
                return;
            }
            lblWarning.Text = "";

            if (players.Count > 1) { return; }

            var homeScreen=new frmHomeScreen(players[0]);
            Hide();
            homeScreen.ShowDialog();
            Show();

        }
    }
}
