namespace DemoGameCaro
{
    partial class Form2
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
            this.btnPlaygame = new System.Windows.Forms.Button();
            this.txbNameplayer2 = new System.Windows.Forms.TextBox();
            this.txbNameplayer1 = new System.Windows.Forms.TextBox();
            this.lblNamePlayer2 = new System.Windows.Forms.Label();
            this.lblNamePlayer1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPlaygame);
            this.panel1.Controls.Add(this.txbNameplayer2);
            this.panel1.Controls.Add(this.txbNameplayer1);
            this.panel1.Controls.Add(this.lblNamePlayer2);
            this.panel1.Controls.Add(this.lblNamePlayer1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 120);
            this.panel1.TabIndex = 0;
            // 
            // btnPlaygame
            // 
            this.btnPlaygame.Location = new System.Drawing.Point(163, 90);
            this.btnPlaygame.Name = "btnPlaygame";
            this.btnPlaygame.Size = new System.Drawing.Size(75, 23);
            this.btnPlaygame.TabIndex = 4;
            this.btnPlaygame.Text = "Vô game";
            this.btnPlaygame.UseVisualStyleBackColor = true;
            this.btnPlaygame.Click += new System.EventHandler(this.btnPlaygame_Click);
            // 
            // txbNameplayer2
            // 
            this.txbNameplayer2.Location = new System.Drawing.Point(116, 62);
            this.txbNameplayer2.Name = "txbNameplayer2";
            this.txbNameplayer2.Size = new System.Drawing.Size(170, 22);
            this.txbNameplayer2.TabIndex = 3;
            // 
            // txbNameplayer1
            // 
            this.txbNameplayer1.Location = new System.Drawing.Point(116, 26);
            this.txbNameplayer1.Name = "txbNameplayer1";
            this.txbNameplayer1.Size = new System.Drawing.Size(170, 22);
            this.txbNameplayer1.TabIndex = 2;
            // 
            // lblNamePlayer2
            // 
            this.lblNamePlayer2.AutoSize = true;
            this.lblNamePlayer2.Location = new System.Drawing.Point(26, 62);
            this.lblNamePlayer2.Name = "lblNamePlayer2";
            this.lblNamePlayer2.Size = new System.Drawing.Size(84, 16);
            this.lblNamePlayer2.TabIndex = 1;
            this.lblNamePlayer2.Text = "Người chơi 2:";
            // 
            // lblNamePlayer1
            // 
            this.lblNamePlayer1.AutoSize = true;
            this.lblNamePlayer1.Location = new System.Drawing.Point(26, 26);
            this.lblNamePlayer1.Name = "lblNamePlayer1";
            this.lblNamePlayer1.Size = new System.Drawing.Size(84, 16);
            this.lblNamePlayer1.TabIndex = 0;
            this.lblNamePlayer1.Text = "Người chơi 1:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 144);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game caro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbNameplayer2;
        private System.Windows.Forms.TextBox txbNameplayer1;
        private System.Windows.Forms.Label lblNamePlayer2;
        private System.Windows.Forms.Label lblNamePlayer1;
        private System.Windows.Forms.Button btnPlaygame;
    }
}