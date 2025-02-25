namespace TicTacToe.WinApp
{
    partial class frmHomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnLogIn = new Button();
            label3 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnSignUp = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(269, 181);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(205, 23);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(269, 234);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(205, 23);
            txtPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 163);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 2;
            label1.Text = "Username or email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 216);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(386, 277);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(88, 23);
            btnLogIn.TabIndex = 4;
            btnLogIn.Text = "Log in";
            btnLogIn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 314);
            label3.Name = "label3";
            label3.Size = new Size(131, 15);
            label3.TabIndex = 5;
            label3.Text = "Dont have an account ?";
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(12, 332);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(75, 23);
            btnSignUp.TabIndex = 6;
            btnSignUp.Text = "Sign up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label4.Location = new Point(283, 48);
            label4.Name = "label4";
            label4.Size = new Size(191, 46);
            label4.TabIndex = 7;
            label4.Text = "Tic Tac Toe";
            // 
            // frmHomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(btnSignUp);
            Controls.Add(label3);
            Controls.Add(btnLogIn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "frmHomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmHomePage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Button btnLogIn;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnSignUp;
        private Label label4;
    }
}
