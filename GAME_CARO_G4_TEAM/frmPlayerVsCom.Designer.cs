namespace GAME_CARO_G4_TEAM
{
    partial class frmPlayerVsCom
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.pnChessBoard = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chơiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chơiMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.màuNềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.màuBànCờToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.màuQuânXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.màuViềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.màuQuânOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnPlay);
            this.panel3.Controls.Add(this.txtPlayerName);
            this.panel3.Location = new System.Drawing.Point(635, 248);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 184);
            this.panel3.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(168, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 60);
            this.button1.TabIndex = 11;
            this.button1.Text = "Thoát Game";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Silver;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(166, 55);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(121, 60);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.Text = "Chơi";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(3, 55);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.ReadOnly = true;
            this.txtPlayerName.Size = new System.Drawing.Size(157, 20);
            this.txtPlayerName.TabIndex = 2;
            // 
            // pnChessBoard
            // 
            this.pnChessBoard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnChessBoard.BackColor = System.Drawing.Color.White;
            this.pnChessBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnChessBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnChessBoard.Location = new System.Drawing.Point(12, 36);
            this.pnChessBoard.Name = "pnChessBoard";
            this.pnChessBoard.Size = new System.Drawing.Size(606, 530);
            this.pnChessBoard.TabIndex = 9;
            this.pnChessBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnChessBoard_Paint);
            this.pnChessBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnChessBoard_MouseClick);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(627, 448);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(274, 118);
            this.panel4.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Chiller", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 118);
            this.label1.TabIndex = 5;
            this.label1.Text = "5 in a line to WIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(635, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 190);
            this.panel1.TabIndex = 12;
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chơiToolStripMenuItem,
            this.chơiMớiToolStripMenuItem,
            this.thoátGameToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // chơiToolStripMenuItem
            // 
            this.chơiToolStripMenuItem.Name = "chơiToolStripMenuItem";
            this.chơiToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.chơiToolStripMenuItem.Text = "Chơi";
            // 
            // chơiMớiToolStripMenuItem
            // 
            this.chơiMớiToolStripMenuItem.Name = "chơiMớiToolStripMenuItem";
            this.chơiMớiToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.chơiMớiToolStripMenuItem.Text = "Chơi mới";
            // 
            // thoátGameToolStripMenuItem
            // 
            this.thoátGameToolStripMenuItem.Name = "thoátGameToolStripMenuItem";
            this.thoátGameToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.thoátGameToolStripMenuItem.Text = "Thoát Game";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.màuNềnToolStripMenuItem,
            this.màuBànCờToolStripMenuItem,
            this.màuQuânOToolStripMenuItem,
            this.màuQuânXToolStripMenuItem,
            this.màuViềnToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // màuNềnToolStripMenuItem
            // 
            this.màuNềnToolStripMenuItem.Name = "màuNềnToolStripMenuItem";
            this.màuNềnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.màuNềnToolStripMenuItem.Text = "Màu nền";
            this.màuNềnToolStripMenuItem.Click += new System.EventHandler(this.màuNềnToolStripMenuItem_Click);
            // 
            // màuBànCờToolStripMenuItem
            // 
            this.màuBànCờToolStripMenuItem.Name = "màuBànCờToolStripMenuItem";
            this.màuBànCờToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.màuBànCờToolStripMenuItem.Text = "Màu bàn cờ";
            this.màuBànCờToolStripMenuItem.Click += new System.EventHandler(this.màuBànCờToolStripMenuItem_Click);
            // 
            // màuQuânXToolStripMenuItem
            // 
            this.màuQuânXToolStripMenuItem.Name = "màuQuânXToolStripMenuItem";
            this.màuQuânXToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.màuQuânXToolStripMenuItem.Text = "Màu quân X";
            this.màuQuânXToolStripMenuItem.Click += new System.EventHandler(this.màuQuânXToolStripMenuItem_Click);
            // 
            // màuViềnToolStripMenuItem
            // 
            this.màuViềnToolStripMenuItem.Name = "màuViềnToolStripMenuItem";
            this.màuViềnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.màuViềnToolStripMenuItem.Text = "Màu viền";
            this.màuViềnToolStripMenuItem.Click += new System.EventHandler(this.màuViềnToolStripMenuItem_Click);
            // 
            // màuQuânOToolStripMenuItem
            // 
            this.màuQuânOToolStripMenuItem.Name = "màuQuânOToolStripMenuItem";
            this.màuQuânOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.màuQuânOToolStripMenuItem.Text = "Màu quân O";
            this.màuQuânOToolStripMenuItem.Click += new System.EventHandler(this.màuQuânOToolStripMenuItem_Click);
            // 
            // frmPlayerVsCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 600);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnChessBoard);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "frmPlayerVsCom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chơi với máy";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Panel pnChessBoard;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chơiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chơiMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem màuNềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem màuBànCờToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem màuQuânXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem màuViềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem màuQuânOToolStripMenuItem;
    }
}