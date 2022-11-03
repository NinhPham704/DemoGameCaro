using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoGameCaro
{
    public partial class Form1 : Form
    {
        ChessBoardManager chessBoardManager;
        public Form1()
        {
            
            InitializeComponent();
            chessBoardManager = new ChessBoardManager(pnChessboard, txtPlayer1, txtPlayer2);
            chessBoardManager.PlayerClick += ChessBoardManager_PlayerClick;
            chessBoardManager.EndedGame += ChessBoardManager_EndedGame;
            prcbCoolDown.Maximum = Const.COOL_DOWN_TIME;
            prcbCoolDown.Step = Const.COOL_DOWN_STEP;
            prcbCoolDown.Value = 0;
            tmCoolDown.Interval = Const.COOL_DOWN_INTERVAL;
            chessBoardManager.DrawChessboard();
            chessBoardManager.ChessBoard.Enabled=false;
        }

        private void ChessBoardManager_EndedGame(object sender, EventArgs e)
        {
            EndGame();
        }

        private void ChessBoardManager_PlayerClick(object sender, EventArgs e)
        {
            prcbCoolDown.Value = 0;
            tmCoolDown.Start();
        }
        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            if (prcbCoolDown.Value >= prcbCoolDown.Maximum)
            {
                tmCoolDown.Stop();
                MessageBox.Show("Đã hết thời gian!");
                EndGame();
            }
            prcbCoolDown.PerformStep();
        }
        public void EndGame()
        {
            tmCoolDown.Stop();
            pnChessboard.Enabled = false;
            btnXinThua.Enabled = false;
            undoToolStripMenuItem.Enabled = false;
            if (chessBoardManager.CurrenPlayer == 0)
            {
                MessageBox.Show(txtPlayer2.Text + " đã giành chiến thắng!!!");
            }
            else if (chessBoardManager.CurrenPlayer == 1)
            {
                MessageBox.Show(txtPlayer1.Text + " đã giành chiến thắng!!!");
            }
        }
        public void NewGame()
        {
            prcbCoolDown.Value = 0;
            tmCoolDown.Stop();
            btnXinThua.Enabled = true;
            undoToolStripMenuItem.Enabled = true;
            chessBoardManager.DrawChessboard();
        }
        public void Quit()
        {
            Application.Exit();
        }
        public void Undo()
        {
            chessBoardManager.Undo();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát!", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
                e.Cancel = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game Caro được tạo bởi DEV704","Thông tin Game");
        }

        private void btnNewgame_Click(object sender, EventArgs e)
        {
            if (!chessBoardManager.checkNamePlayer())
            {
                MessageBox.Show("Xin vui lòng nhập tên người chơi!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                CreatePlayer();
                NewGame();
            }
            else
            {
                NewGame();
            }
        }
        private void CreatePlayer()
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
            txtPlayer1.Text = frm.NamePlayer1;
            txtPlayer2.Text = frm.NamePlayer2;
            btnNewgame.Text = "Ván mới";
        }
        private void btnXinThua_Click(object sender, EventArgs e)
        {
            EndGame();
        }
    }
}
