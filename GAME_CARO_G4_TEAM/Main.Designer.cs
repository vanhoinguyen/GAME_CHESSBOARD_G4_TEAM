namespace GAME_CARO_G4_TEAM
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPlayerVsCom = new System.Windows.Forms.Button();
            this.btnPlayerVsPlayer = new System.Windows.Forms.Button();
            this.btnGuide = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.ckbSound = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 135);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnGuide);
            this.panel2.Controls.Add(this.btnPlayerVsPlayer);
            this.panel2.Controls.Add(this.btnPlayerVsCom);
            this.panel2.Location = new System.Drawing.Point(12, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 212);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ckbSound);
            this.panel3.Location = new System.Drawing.Point(15, 371);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(419, 47);
            this.panel3.TabIndex = 2;
            // 
            // btnPlayerVsCom
            // 
            this.btnPlayerVsCom.FlatAppearance.BorderSize = 0;
            this.btnPlayerVsCom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlayerVsCom.Font = new System.Drawing.Font("Chiller", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerVsCom.Location = new System.Drawing.Point(95, 3);
            this.btnPlayerVsCom.Name = "btnPlayerVsCom";
            this.btnPlayerVsCom.Size = new System.Drawing.Size(211, 47);
            this.btnPlayerVsCom.TabIndex = 0;
            this.btnPlayerVsCom.Text = "Chơi với máy";
            this.btnPlayerVsCom.UseVisualStyleBackColor = true;
            this.btnPlayerVsCom.Click += new System.EventHandler(this.btnPlayerVsCom_Click);
            // 
            // btnPlayerVsPlayer
            // 
            this.btnPlayerVsPlayer.FlatAppearance.BorderSize = 0;
            this.btnPlayerVsPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlayerVsPlayer.Font = new System.Drawing.Font("Chiller", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerVsPlayer.Location = new System.Drawing.Point(95, 56);
            this.btnPlayerVsPlayer.Name = "btnPlayerVsPlayer";
            this.btnPlayerVsPlayer.Size = new System.Drawing.Size(211, 47);
            this.btnPlayerVsPlayer.TabIndex = 1;
            this.btnPlayerVsPlayer.Text = "Chơi với người";
            this.btnPlayerVsPlayer.UseVisualStyleBackColor = true;
            this.btnPlayerVsPlayer.Click += new System.EventHandler(this.btnPlayerVsPlayer_Click);
            // 
            // btnGuide
            // 
            this.btnGuide.FlatAppearance.BorderSize = 0;
            this.btnGuide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuide.Font = new System.Drawing.Font("Chiller", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuide.Location = new System.Drawing.Point(95, 109);
            this.btnGuide.Name = "btnGuide";
            this.btnGuide.Size = new System.Drawing.Size(211, 47);
            this.btnGuide.TabIndex = 2;
            this.btnGuide.Text = "Hướng dẫn";
            this.btnGuide.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Chiller", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(95, 162);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(211, 47);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ckbSound
            // 
            this.ckbSound.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbSound.Checked = true;
            this.ckbSound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbSound.FlatAppearance.BorderSize = 0;
            this.ckbSound.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ckbSound.Font = new System.Drawing.Font("Chiller", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSound.Image = global::GAME_CARO_G4_TEAM.Properties.Resources.sound;
            this.ckbSound.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ckbSound.Location = new System.Drawing.Point(305, 13);
            this.ckbSound.Name = "ckbSound";
            this.ckbSound.Size = new System.Drawing.Size(111, 31);
            this.ckbSound.TabIndex = 1;
            this.ckbSound.Text = "    Bật nhạc";
            this.ckbSound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckbSound.UseVisualStyleBackColor = true;
            this.ckbSound.CheckedChanged += new System.EventHandler(this.ckbSound_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GAME_CARO_G4_TEAM.Properties.Resources.caro;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(446, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(446, 430);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Caro";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGuide;
        private System.Windows.Forms.Button btnPlayerVsPlayer;
        private System.Windows.Forms.Button btnPlayerVsCom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox ckbSound;
    }
}