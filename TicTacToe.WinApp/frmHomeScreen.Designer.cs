namespace TicTacToe.WinApp
{
    partial class frmHomeScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPlay = new Button();
            btnLeaderboard = new Button();
            btnEdit = new Button();
            pbPicture = new PictureBox();
            lblUsername = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnPlay.Location = new Point(244, 126);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(274, 64);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnLeaderboard
            // 
            btnLeaderboard.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnLeaderboard.Location = new Point(244, 207);
            btnLeaderboard.Name = "btnLeaderboard";
            btnLeaderboard.Size = new Size(274, 64);
            btnLeaderboard.TabIndex = 1;
            btnLeaderboard.Text = "Leaderboard";
            btnLeaderboard.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnEdit.Location = new Point(244, 288);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(274, 64);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit Profile";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // pbPicture
            // 
            pbPicture.Location = new Point(12, 22);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(113, 92);
            pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPicture.TabIndex = 3;
            pbPicture.TabStop = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Segoe UI", 15F);
            lblUsername.Location = new Point(146, 56);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(65, 28);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "label1";
            // 
            // frmHomeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblUsername);
            Controls.Add(pbPicture);
            Controls.Add(btnEdit);
            Controls.Add(btnLeaderboard);
            Controls.Add(btnPlay);
            Name = "frmHomeScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmHomeScreen";
            Load += frmHomeScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlay;
        private Button btnLeaderboard;
        private Button btnEdit;
        private PictureBox pbPicture;
        private Label lblUsername;
    }
}