namespace TicTacToe.WinApp
{
    partial class frmPlay
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            pbPlayer = new PictureBox();
            pbEnemy = new PictureBox();
            lblPlayer = new Label();
            lblEnemy = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEnemy).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button1.Location = new Point(163, 131);
            button1.Name = "button1";
            button1.Size = new Size(122, 84);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button2.Location = new Point(323, 131);
            button2.Name = "button2";
            button2.Size = new Size(122, 84);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button3.Location = new Point(482, 131);
            button3.Name = "button3";
            button3.Size = new Size(122, 84);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button4.Location = new Point(163, 238);
            button4.Name = "button4";
            button4.Size = new Size(122, 84);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button5.Location = new Point(323, 238);
            button5.Name = "button5";
            button5.Size = new Size(122, 84);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button6.Location = new Point(482, 238);
            button6.Name = "button6";
            button6.Size = new Size(122, 84);
            button6.TabIndex = 3;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button7.Location = new Point(163, 340);
            button7.Name = "button7";
            button7.Size = new Size(122, 84);
            button7.TabIndex = 8;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button8.Location = new Point(323, 340);
            button8.Name = "button8";
            button8.Size = new Size(122, 84);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button9.Location = new Point(482, 340);
            button9.Name = "button9";
            button9.Size = new Size(122, 84);
            button9.TabIndex = 6;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // pbPlayer
            // 
            pbPlayer.Location = new Point(41, 12);
            pbPlayer.Name = "pbPlayer";
            pbPlayer.Size = new Size(119, 88);
            pbPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPlayer.TabIndex = 9;
            pbPlayer.TabStop = false;
            // 
            // pbEnemy
            // 
            pbEnemy.Location = new Point(627, 12);
            pbEnemy.Name = "pbEnemy";
            pbEnemy.Size = new Size(119, 88);
            pbEnemy.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEnemy.TabIndex = 10;
            pbEnemy.TabStop = false;
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblPlayer.Location = new Point(183, 47);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(70, 28);
            lblPlayer.TabIndex = 11;
            lblPlayer.Text = "label1";
            // 
            // lblEnemy
            // 
            lblEnemy.AutoSize = true;
            lblEnemy.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblEnemy.Location = new Point(534, 47);
            lblEnemy.Name = "lblEnemy";
            lblEnemy.Size = new Size(70, 28);
            lblEnemy.TabIndex = 12;
            lblEnemy.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.Location = new Point(351, 34);
            label1.Name = "label1";
            label1.Size = new Size(62, 46);
            label1.TabIndex = 13;
            label1.Text = "VS";
            // 
            // frmPlay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblEnemy);
            Controls.Add(lblPlayer);
            Controls.Add(pbEnemy);
            Controls.Add(pbPlayer);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "frmPlay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPlay";
            Load += frmPlay_Load;
            ((System.ComponentModel.ISupportInitialize)pbPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEnemy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private PictureBox pbPlayer;
        private PictureBox pbEnemy;
        private Label lblPlayer;
        private Label lblEnemy;
        private Label label1;
    }
}