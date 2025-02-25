namespace TicTacToe.WinApp
{
    public partial class frmHomePage : Form
    {
        public frmHomePage()
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
            var newForm=new frmSignUp();
            newForm.ShowDialog();
            Show();
        }
    }
}
