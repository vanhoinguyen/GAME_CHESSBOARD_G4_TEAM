namespace GAME_CARO_G4_TEAM
{
    partial class frmPlayerVsPlayer
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.prbCoolDown = new System.Windows.Forms.ProgressBar();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.btnLan = new System.Windows.Forms.Button();
            this.pnChessBoard = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbMark = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel3.Controls.Add(this.ptbMark);
            this.panel3.Controls.Add(this.prbCoolDown);
            this.panel3.Controls.Add(this.txtID);
            this.panel3.Controls.Add(this.txtPlayerName);
            this.panel3.Controls.Add(this.btnLan);
            this.panel3.Location = new System.Drawing.Point(644, 208);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 116);
            this.panel3.TabIndex = 6;
            // 
            // prbCoolDown
            // 
            this.prbCoolDown.Location = new System.Drawing.Point(3, 29);
            this.prbCoolDown.Name = "prbCoolDown";
            this.prbCoolDown.Size = new System.Drawing.Size(157, 23);
            this.prbCoolDown.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(3, 58);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(157, 20);
            this.txtID.TabIndex = 3;
            this.txtID.Text = "127.0.0.1";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(3, 3);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.ReadOnly = true;
            this.txtPlayerName.Size = new System.Drawing.Size(157, 20);
            this.txtPlayerName.TabIndex = 2;
            // 
            // btnLan
            // 
            this.btnLan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLan.Font = new System.Drawing.Font("Chiller", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLan.Location = new System.Drawing.Point(3, 84);
            this.btnLan.Name = "btnLan";
            this.btnLan.Size = new System.Drawing.Size(157, 23);
            this.btnLan.TabIndex = 0;
            this.btnLan.Text = "LAN";
            this.btnLan.UseVisualStyleBackColor = true;
            // 
            // pnChessBoard
            // 
            this.pnChessBoard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnChessBoard.BackColor = System.Drawing.Color.White;
            this.pnChessBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnChessBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnChessBoard.Location = new System.Drawing.Point(16, 12);
            this.pnChessBoard.Name = "pnChessBoard";
            this.pnChessBoard.Size = new System.Drawing.Size(606, 530);
            this.pnChessBoard.TabIndex = 5;
            this.pnChessBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnChessBoard_Paint);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.btnSend);
            this.panel4.Controls.Add(this.rtbChat);
            this.panel4.Location = new System.Drawing.Point(641, 330);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(277, 214);
            this.panel4.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 178);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 28);
            this.textBox1.TabIndex = 7;
            // 
            // btnSend
            // 
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend.Font = new System.Drawing.Font("Chiller", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(204, 177);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(73, 29);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // rtbChat
            // 
            this.rtbChat.Location = new System.Drawing.Point(0, 3);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.Size = new System.Drawing.Size(277, 168);
            this.rtbChat.TabIndex = 0;
            this.rtbChat.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(644, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 190);
            this.panel1.TabIndex = 8;
            // 
            // ptbMark
            // 
            this.ptbMark.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ptbMark.Location = new System.Drawing.Point(166, 0);
            this.ptbMark.Name = "ptbMark";
            this.ptbMark.Size = new System.Drawing.Size(108, 107);
            this.ptbMark.TabIndex = 5;
            this.ptbMark.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GAME_CARO_G4_TEAM.Properties.Resources.avatar2;
            this.pictureBox1.Location = new System.Drawing.Point(42, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmPlayerVsPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 556);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnChessBoard);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "frmPlayerVsPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chơi với người";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox ptbMark;
        private System.Windows.Forms.ProgressBar prbCoolDown;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Button btnLan;
        private System.Windows.Forms.Panel pnChessBoard;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}