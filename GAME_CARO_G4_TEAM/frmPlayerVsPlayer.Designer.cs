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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlayerVsPlayer));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.prbCoolDown = new System.Windows.Forms.ProgressBar();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.btnLan = new System.Windows.Forms.Button();
            this.pnChessBoard = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chơiMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.màuBànCờToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.màuViềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.màuQuânOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.màuQuânXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.IP = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.IP);
            this.panel3.Controls.Add(this.btnRedo);
            this.panel3.Controls.Add(this.btnUndo);
            this.panel3.Controls.Add(this.btnQuit);
            this.panel3.Controls.Add(this.btnPlay);
            this.panel3.Controls.Add(this.prbCoolDown);
            this.panel3.Controls.Add(this.txtPlayerName);
            this.panel3.Controls.Add(this.btnLan);
            this.panel3.Location = new System.Drawing.Point(726, 300);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 166);
            this.panel3.TabIndex = 6;
            // 
            // btnRedo
            // 
            this.btnRedo.BackColor = System.Drawing.Color.Transparent;
            this.btnRedo.FlatAppearance.BorderSize = 0;
            this.btnRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedo.Font = new System.Drawing.Font("UTM Ambrosia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedo.Location = new System.Drawing.Point(85, 130);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(75, 29);
            this.btnRedo.TabIndex = 15;
            this.btnRedo.Text = "Redo";
            this.btnRedo.UseVisualStyleBackColor = false;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.Transparent;
            this.btnUndo.FlatAppearance.BorderSize = 0;
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndo.Font = new System.Drawing.Font("UTM Ambrosia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Location = new System.Drawing.Point(6, 130);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 29);
            this.btnUndo.TabIndex = 14;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("UTM Ambrosia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(166, 121);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(105, 42);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.Text = "Thoát Game";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("UTM Ambrosia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(166, 1);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(105, 42);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Chơi 1 máy";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // prbCoolDown
            // 
            this.prbCoolDown.BackColor = System.Drawing.Color.Gray;
            this.prbCoolDown.Location = new System.Drawing.Point(6, 56);
            this.prbCoolDown.Maximum = 30;
            this.prbCoolDown.Name = "prbCoolDown";
            this.prbCoolDown.Size = new System.Drawing.Size(156, 40);
            this.prbCoolDown.Step = 1;
            this.prbCoolDown.TabIndex = 4;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlayerName.Font = new System.Drawing.Font("UTM Ambrosia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.Location = new System.Drawing.Point(3, 9);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.ReadOnly = true;
            this.txtPlayerName.Size = new System.Drawing.Size(159, 43);
            this.txtPlayerName.TabIndex = 2;
            this.txtPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLan
            // 
            this.btnLan.BackColor = System.Drawing.Color.Transparent;
            this.btnLan.FlatAppearance.BorderSize = 0;
            this.btnLan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLan.Font = new System.Drawing.Font("UTM Ambrosia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLan.Location = new System.Drawing.Point(166, 61);
            this.btnLan.Name = "btnLan";
            this.btnLan.Size = new System.Drawing.Size(105, 41);
            this.btnLan.TabIndex = 0;
            this.btnLan.Text = "LAN game";
            this.btnLan.UseVisualStyleBackColor = false;
            this.btnLan.Click += new System.EventHandler(this.btnLan_Click);
            // 
            // pnChessBoard
            // 
            this.pnChessBoard.BackColor = System.Drawing.Color.White;
            this.pnChessBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnChessBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnChessBoard.Location = new System.Drawing.Point(99, 82);
            this.pnChessBoard.Name = "pnChessBoard";
            this.pnChessBoard.Size = new System.Drawing.Size(604, 530);
            this.pnChessBoard.TabIndex = 5;
            this.pnChessBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnChessBoard_Paint);
            this.pnChessBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnChessBoard_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 20, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(96, 700);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chơiMớiToolStripMenuItem,
            this.thoátGameToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("UTM Ambrosia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(89, 39);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // chơiMớiToolStripMenuItem
            // 
            this.chơiMớiToolStripMenuItem.Name = "chơiMớiToolStripMenuItem";
            this.chơiMớiToolStripMenuItem.Size = new System.Drawing.Size(158, 40);
            this.chơiMớiToolStripMenuItem.Text = "Chơi mới";
            this.chơiMớiToolStripMenuItem.Click += new System.EventHandler(this.chơiMớiToolStripMenuItem_Click);
            // 
            // thoátGameToolStripMenuItem
            // 
            this.thoátGameToolStripMenuItem.Name = "thoátGameToolStripMenuItem";
            this.thoátGameToolStripMenuItem.Size = new System.Drawing.Size(158, 40);
            this.thoátGameToolStripMenuItem.Text = "Thoát Game";
            this.thoátGameToolStripMenuItem.Click += new System.EventHandler(this.thoátGameToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.màuBànCờToolStripMenuItem,
            this.màuViềnToolStripMenuItem,
            this.màuQuânOToolStripMenuItem,
            this.màuQuânXToolStripMenuItem});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("UTM Ambrosia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(89, 39);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(161, 40);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(161, 40);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // màuBànCờToolStripMenuItem
            // 
            this.màuBànCờToolStripMenuItem.Name = "màuBànCờToolStripMenuItem";
            this.màuBànCờToolStripMenuItem.Size = new System.Drawing.Size(161, 40);
            this.màuBànCờToolStripMenuItem.Text = "Màu Bàn Cờ";
            this.màuBànCờToolStripMenuItem.Click += new System.EventHandler(this.màuBànCờToolStripMenuItem_Click);
            // 
            // màuViềnToolStripMenuItem
            // 
            this.màuViềnToolStripMenuItem.Name = "màuViềnToolStripMenuItem";
            this.màuViềnToolStripMenuItem.Size = new System.Drawing.Size(161, 40);
            this.màuViềnToolStripMenuItem.Text = "Màu Viền";
            this.màuViềnToolStripMenuItem.Click += new System.EventHandler(this.màuViềnToolStripMenuItem_Click);
            // 
            // màuQuânOToolStripMenuItem
            // 
            this.màuQuânOToolStripMenuItem.Name = "màuQuânOToolStripMenuItem";
            this.màuQuânOToolStripMenuItem.Size = new System.Drawing.Size(161, 40);
            this.màuQuânOToolStripMenuItem.Text = "Màu Quân O";
            this.màuQuânOToolStripMenuItem.Click += new System.EventHandler(this.màuQuânOToolStripMenuItem_Click);
            // 
            // màuQuânXToolStripMenuItem
            // 
            this.màuQuânXToolStripMenuItem.Name = "màuQuânXToolStripMenuItem";
            this.màuQuânXToolStripMenuItem.Size = new System.Drawing.Size(161, 40);
            this.màuQuânXToolStripMenuItem.Text = "Màu Quân X";
            this.màuQuânXToolStripMenuItem.Click += new System.EventHandler(this.màuQuânXToolStripMenuItem_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.btnSend);
            this.panel4.Controls.Add(this.rtbChat);
            this.panel4.Location = new System.Drawing.Point(726, 472);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(277, 152);
            this.panel4.TabIndex = 7;
            this.panel4.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 120);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 28);
            this.textBox1.TabIndex = 10;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("UTM Ambrosia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(198, 118);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(73, 29);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Chat";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click_1);
            // 
            // rtbChat
            // 
            this.rtbChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbChat.Location = new System.Drawing.Point(0, 3);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.ReadOnly = true;
            this.rtbChat.Size = new System.Drawing.Size(277, 112);
            this.rtbChat.TabIndex = 8;
            this.rtbChat.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(761, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Red;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Maroon;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 2;
            this.bunifuFlatButton1.ButtonText = " x";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(915, 28);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Maroon;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Red;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(57, 29);
            this.bunifuFlatButton1.TabIndex = 16;
            this.bunifuFlatButton1.Text = " x";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Red;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 2;
            this.bunifuFlatButton2.ButtonText = " _";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(878, 28);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Red;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(39, 29);
            this.bunifuFlatButton2.TabIndex = 19;
            this.bunifuFlatButton2.Text = " _";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(6, 104);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(154, 20);
            this.IP.TabIndex = 16;
            // 
            // frmPlayerVsPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 700);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnChessBoard);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPlayerVsPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chơi với người";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmPlayerVsPlayer_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPlayerVsPlayer_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmPlayerVsPlayer_MouseUp);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ProgressBar prbCoolDown;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Button btnLan;
        private System.Windows.Forms.Panel pnChessBoard;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chơiMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.ToolStripMenuItem màuBànCờToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem màuViềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem màuQuânOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem màuQuânXToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox IP;
    }
}