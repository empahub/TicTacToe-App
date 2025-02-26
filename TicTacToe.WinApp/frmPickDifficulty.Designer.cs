namespace TicTacToe.WinApp
{
    partial class frmPickDifficulty
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
            pbEasy = new PictureBox();
            pbMedium = new PictureBox();
            pbImpossible = new PictureBox();
            label1 = new Label();
            btnEasy = new Button();
            btnMedium = new Button();
            btnImpossible = new Button();
            lblEasy = new Label();
            lblMedium = new Label();
            lblImpossible = new Label();
            ((System.ComponentModel.ISupportInitialize)pbEasy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMedium).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImpossible).BeginInit();
            SuspendLayout();
            // 
            // pbEasy
            // 
            pbEasy.Location = new Point(37, 125);
            pbEasy.Name = "pbEasy";
            pbEasy.Size = new Size(194, 160);
            pbEasy.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEasy.TabIndex = 0;
            pbEasy.TabStop = false;
            // 
            // pbMedium
            // 
            pbMedium.Location = new Point(304, 125);
            pbMedium.Name = "pbMedium";
            pbMedium.Size = new Size(194, 160);
            pbMedium.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMedium.TabIndex = 1;
            pbMedium.TabStop = false;
            // 
            // pbImpossible
            // 
            pbImpossible.Location = new Point(562, 125);
            pbImpossible.Name = "pbImpossible";
            pbImpossible.Size = new Size(194, 160);
            pbImpossible.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImpossible.TabIndex = 2;
            pbImpossible.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.Location = new Point(239, 20);
            label1.Name = "label1";
            label1.Size = new Size(294, 46);
            label1.TabIndex = 3;
            label1.Text = "Choose Difficulty";
            // 
            // btnEasy
            // 
            btnEasy.Location = new Point(71, 300);
            btnEasy.Name = "btnEasy";
            btnEasy.Size = new Size(128, 41);
            btnEasy.TabIndex = 4;
            btnEasy.Text = "Easy";
            btnEasy.UseVisualStyleBackColor = true;
            btnEasy.Click += btnEasy_Click;
            // 
            // btnMedium
            // 
            btnMedium.Location = new Point(334, 300);
            btnMedium.Name = "btnMedium";
            btnMedium.Size = new Size(128, 41);
            btnMedium.TabIndex = 5;
            btnMedium.Text = "Medium";
            btnMedium.UseVisualStyleBackColor = true;
            btnMedium.Click += btnMedium_Click;
            // 
            // btnImpossible
            // 
            btnImpossible.Location = new Point(594, 300);
            btnImpossible.Name = "btnImpossible";
            btnImpossible.Size = new Size(128, 41);
            btnImpossible.TabIndex = 6;
            btnImpossible.Text = "Impossible";
            btnImpossible.UseVisualStyleBackColor = true;
            btnImpossible.Click += btnImpossible_Click;
            // 
            // lblEasy
            // 
            lblEasy.AutoSize = true;
            lblEasy.BackColor = Color.Transparent;
            lblEasy.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblEasy.Location = new Point(96, 88);
            lblEasy.Name = "lblEasy";
            lblEasy.Size = new Size(0, 25);
            lblEasy.TabIndex = 7;
            // 
            // lblMedium
            // 
            lblMedium.AutoSize = true;
            lblMedium.BackColor = Color.Transparent;
            lblMedium.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblMedium.Location = new Point(368, 88);
            lblMedium.Name = "lblMedium";
            lblMedium.Size = new Size(0, 25);
            lblMedium.TabIndex = 8;
            // 
            // lblImpossible
            // 
            lblImpossible.AutoSize = true;
            lblImpossible.BackColor = Color.Transparent;
            lblImpossible.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblImpossible.Location = new Point(636, 88);
            lblImpossible.Name = "lblImpossible";
            lblImpossible.Size = new Size(0, 25);
            lblImpossible.TabIndex = 9;
            // 
            // frmPickDifficulty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblImpossible);
            Controls.Add(lblMedium);
            Controls.Add(lblEasy);
            Controls.Add(btnImpossible);
            Controls.Add(btnMedium);
            Controls.Add(btnEasy);
            Controls.Add(label1);
            Controls.Add(pbImpossible);
            Controls.Add(pbMedium);
            Controls.Add(pbEasy);
            Name = "frmPickDifficulty";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPickDifficulty";
            Load += frmPickDifficulty_Load;
            ((System.ComponentModel.ISupportInitialize)pbEasy).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMedium).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImpossible).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbEasy;
        private PictureBox pbMedium;
        private PictureBox pbImpossible;
        private Label label1;
        private Button btnEasy;
        private Button btnMedium;
        private Button btnImpossible;
        private Label lblEasy;
        private Label lblMedium;
        private Label lblImpossible;
    }
}