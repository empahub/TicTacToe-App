namespace TicTacToe.WinApp
{
    partial class frmEditProfile
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
            pbPicture = new PictureBox();
            btnProfilePicture = new Button();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            lblError = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            SuspendLayout();
            // 
            // pbPicture
            // 
            pbPicture.Location = new Point(22, 23);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(236, 171);
            pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPicture.TabIndex = 0;
            pbPicture.TabStop = false;
            // 
            // btnProfilePicture
            // 
            btnProfilePicture.Location = new Point(61, 209);
            btnProfilePicture.Name = "btnProfilePicture";
            btnProfilePicture.Size = new Size(157, 46);
            btnProfilePicture.TabIndex = 1;
            btnProfilePicture.Text = "Change Profile Picture";
            btnProfilePicture.UseVisualStyleBackColor = true;
            btnProfilePicture.Click += btnProfilePicture_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(319, 82);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(175, 23);
            txtUsername.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(319, 135);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(175, 23);
            txtEmail.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(401, 179);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(93, 30);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 64);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 5;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 117);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 6;
            label2.Text = "Email";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(319, 161);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 7;
            // 
            // frmEditProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblError);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(btnProfilePicture);
            Controls.Add(pbPicture);
            Name = "frmEditProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEditProfile";
            Load += frmEditProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbPicture;
        private Button btnProfilePicture;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private OpenFileDialog openFileDialog1;
        private Label lblError;
    }
}