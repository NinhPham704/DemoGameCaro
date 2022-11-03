namespace DemoGameCaro
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnChessboard = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictrLogo = new System.Windows.Forms.PictureBox();
            this.txtHuongdan = new System.Windows.Forms.TextBox();
            this.btnNewgame = new System.Windows.Forms.Button();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.prcbCoolDown = new System.Windows.Forms.ProgressBar();
            this.btnXinThua = new System.Windows.Forms.Button();
            this.tmCoolDown = new System.Windows.Forms.Timer(this.components);
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictrLogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnChessboard
            // 
            this.pnChessboard.Location = new System.Drawing.Point(12, 36);
            this.pnChessboard.Name = "pnChessboard";
            this.pnChessboard.Size = new System.Drawing.Size(1100, 740);
            this.pnChessboard.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictrLogo);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1118, 36);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 250);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pictrLogo
            // 
            this.pictrLogo.BackgroundImage = global::DemoGameCaro.Properties.Resources.caro;
            this.pictrLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictrLogo.Location = new System.Drawing.Point(3, 3);
            this.pictrLogo.Name = "pictrLogo";
            this.pictrLogo.Size = new System.Drawing.Size(244, 244);
            this.pictrLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictrLogo.TabIndex = 0;
            this.pictrLogo.TabStop = false;
            // 
            // txtHuongdan
            // 
            this.txtHuongdan.Enabled = false;
            this.txtHuongdan.Location = new System.Drawing.Point(1121, 306);
            this.txtHuongdan.Multiline = true;
            this.txtHuongdan.Name = "txtHuongdan";
            this.txtHuongdan.Size = new System.Drawing.Size(244, 141);
            this.txtHuongdan.TabIndex = 2;
            this.txtHuongdan.Text = resources.GetString("txtHuongdan.Text");
            // 
            // btnNewgame
            // 
            this.btnNewgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewgame.Location = new System.Drawing.Point(1121, 694);
            this.btnNewgame.Name = "btnNewgame";
            this.btnNewgame.Size = new System.Drawing.Size(244, 38);
            this.btnNewgame.TabIndex = 3;
            this.btnNewgame.Text = "Bắt đầu";
            this.btnNewgame.UseVisualStyleBackColor = true;
            this.btnNewgame.Click += new System.EventHandler(this.btnNewgame_Click);
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.BackColor = System.Drawing.Color.Yellow;
            this.txtPlayer1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPlayer1.Location = new System.Drawing.Point(1121, 453);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(115, 22);
            this.txtPlayer1.TabIndex = 4;
            this.txtPlayer1.Text = "Player1";
            this.txtPlayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Location = new System.Drawing.Point(1250, 453);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(115, 22);
            this.txtPlayer2.TabIndex = 5;
            this.txtPlayer2.Text = "Player2";
            this.txtPlayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prcbCoolDown
            // 
            this.prcbCoolDown.Location = new System.Drawing.Point(1121, 603);
            this.prcbCoolDown.Maximum = 15000;
            this.prcbCoolDown.Name = "prcbCoolDown";
            this.prcbCoolDown.Size = new System.Drawing.Size(244, 23);
            this.prcbCoolDown.Step = 100;
            this.prcbCoolDown.TabIndex = 8;
            // 
            // btnXinThua
            // 
            this.btnXinThua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXinThua.Location = new System.Drawing.Point(1121, 738);
            this.btnXinThua.Name = "btnXinThua";
            this.btnXinThua.Size = new System.Drawing.Size(244, 38);
            this.btnXinThua.TabIndex = 9;
            this.btnXinThua.Text = "Xin thua!";
            this.btnXinThua.UseVisualStyleBackColor = true;
            this.btnXinThua.Click += new System.EventHandler(this.btnXinThua_Click);
            // 
            // tmCoolDown
            // 
            this.tmCoolDown.Tick += new System.EventHandler(this.tmCoolDown_Tick);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.quitToolStripMenuItem,
            this.txtAbout});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // txtAbout
            // 
            this.txtAbout.Name = "txtAbout";
            this.txtAbout.Size = new System.Drawing.Size(217, 26);
            this.txtAbout.Text = "About";
            this.txtAbout.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1382, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1250, 481);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1121, 481);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 786);
            this.Controls.Add(this.btnXinThua);
            this.Controls.Add(this.prcbCoolDown);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtPlayer2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPlayer1);
            this.Controls.Add(this.btnNewgame);
            this.Controls.Add(this.txtHuongdan);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnChessboard);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "GameCaro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictrLogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnChessboard;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictrLogo;
        private System.Windows.Forms.TextBox txtHuongdan;
        private System.Windows.Forms.Button btnNewgame;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar prcbCoolDown;
        private System.Windows.Forms.Button btnXinThua;
        private System.Windows.Forms.Timer tmCoolDown;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem txtAbout;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

