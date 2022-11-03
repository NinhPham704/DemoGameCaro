using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoGameCaro
{
    public class ChessBoardManager
    {
        #region Properties
        private int mod;
        private Panel chessBoard;
        private TextBox player1Name;
        private TextBox player2Name;
        private PictureBox playerMark;
        private List<List<Button>> matrix;
        private List<Player> players;
        private int currenPlayer;
        private Stack<PlayInfo> playTimeLine;

        public Panel ChessBoard { get => chessBoard; set => chessBoard = value; }
        public TextBox Player1Name { get => player1Name; set => player1Name = value; }
        public PictureBox PlayerMark { get => playerMark; set => playerMark = value; }
        public int CurrenPlayer { get => currenPlayer; set => currenPlayer = value; }
        public TextBox Player2Name { get => player2Name; set => player2Name = value; }
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }
        public Stack<PlayInfo> PlayTimeLine { get => playTimeLine; set => playTimeLine = value; }
        public int MOD { get => mod; set => mod = value; }

        public event EventHandler playerClick;
        public event EventHandler PlayerClick
        {
            add
            {
                playerClick += value;
            }
            remove
            {
                playerClick -= value;
            }
        }
        public event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }
        #endregion

        #region Initialize
        public ChessBoardManager(Panel chessBoard,TextBox player1Name,TextBox player2Name)
        {
            this.ChessBoard = chessBoard;
            this.Player1Name = player1Name;
            this.Player2Name = player2Name;
            this.PlayerMark = playerMark;

            players = new List<Player>()
            {
                 new Player(player1Name.Text,Image.FromFile(Application.StartupPath + "\\Resources\\X.png")),
                 new Player(player2Name.Text,Image.FromFile(Application.StartupPath + "\\Resources\\O.png")),
            };
            PlayTimeLine = new Stack<PlayInfo>();
        }
        #endregion

        #region Methods
        public void DrawChessboard()
        {
            chessBoard.Enabled = true;
            chessBoard.Controls.Clear();
            currenPlayer = 1;
            ChangePlayer();
            Matrix = new List<List<Button>>();
            for (int i = 0; i < Const.CHESSBOARD_HEIGHT; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Const.CHESSBOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Const.CHESS_WIDTH,
                        Height = Const.CHESS_HEIGHT,
                        Location = new Point(j * Const.CHESS_WIDTH, i * Const.CHESS_HEIGHT),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i
                    };
                    btn.Click += Btn_Click;
                    ChessBoard.Controls.Add(btn);
                    Matrix[i].Add(btn);
                }
            }
        }
        private bool isEndGame(Button btn)
        {
            return isEndHorizontal(btn)||isEndVertical(btn)||isEndPrimaryDiagonal(btn)||isEndSubDiagonal(btn);
        }
        public void EndGame()
        {
            if (endedGame != null)
            {
                endedGame(this, new EventArgs());
            }
        }
        public bool Undo()
        {
            if(playTimeLine.Count <= 0)
                return false;
            PlayInfo oldPlayer = PlayTimeLine.Pop();
            Button btn = Matrix[oldPlayer.Point.Y][oldPlayer.Point.X];

            btn.BackgroundImage = null;
            if(playTimeLine.Count <= 0)
            {
                MessageBox.Show("Không thể Undo được nữa.","Thông báo");
                CurrenPlayer = 0;
            }
            else
            {
                //MessageBox.Show("Không thể Undo được nữa.","Thông báo");
                oldPlayer = playTimeLine.Peek();
                CurrenPlayer = oldPlayer.CurrentPlayer == 1 ? 0 : 1;
            }
            ChangePlayer();
            return false;
        }
        private Point GetChessPoint(Button btn)
        {
            int vertical = (int)btn.Tag;
            int horizontal = Matrix[vertical].IndexOf(btn);
            Point point = new Point(horizontal,vertical);
            return point;
        }
        private bool isEndHorizontal(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countLeft = 0;
            int countRight = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else break;
            }
            for (int i = point.X+1; i < Const.CHESSBOARD_WIDTH; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else break;
            }
            return countRight + countLeft >= 5;
        }
        private bool isEndVertical(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countTop = 0;
            int countBot = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else break;
            }
            for (int i = point.Y + 1; i < Const.CHESSBOARD_HEIGHT; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countBot++;
                }
                else break;
            }
            return countTop + countBot >= 5;
        }
        private bool isEndPrimaryDiagonal(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countpridiagonalTop = 0;
            int countpridiagonalBot = 0;
            for (int i = point.X,j=point.Y; i >= 0; i--,j--)
            {
                if (i < 0 || j < 0)
                {
                    break;
                }
                if (Matrix[j][i].BackgroundImage == btn.BackgroundImage)
                {
                    countpridiagonalTop++;
                }
                else break;
            }
            for (int i = point.X + 1, j = point.Y+1; i < Const.CHESSBOARD_WIDTH; i++,j++)
            {
                if( i >= Const.CHESSBOARD_WIDTH || j >= Const.CHESSBOARD_HEIGHT)
                {
                    break;
                }
                if (Matrix[j][i].BackgroundImage == btn.BackgroundImage)
                {
                    countpridiagonalBot++;
                }
                else break;
            }
            return countpridiagonalTop + countpridiagonalBot >= 5;
        }
        private bool isEndSubDiagonal(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countsubdiagonalTop = 0;
            int countsubdiagonalBot = 0;
            for (int i = point.X, j = point.Y; i >= 0; i++, j--)
            {
                if (i >= Const.CHESSBOARD_WIDTH || j < 0)
                {
                    break;
                }
                if (Matrix[j][i].BackgroundImage == btn.BackgroundImage)
                {
                    countsubdiagonalTop++;
                }
                else break;
            }
            for (int i = point.X - 1, j = point.Y + 1; i < Const.CHESSBOARD_WIDTH; i--, j++)
            {
                if (i < 0 || j >= Const.CHESSBOARD_HEIGHT)
                {
                    break;
                }
                if (Matrix[j][i].BackgroundImage == btn.BackgroundImage)
                {
                    countsubdiagonalBot++;
                }
                else break;
            }
            return countsubdiagonalTop + countsubdiagonalBot >= 5;
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            
            Button btn = sender as Button;
            if (btn.BackgroundImage != null) return;

            btn.BackgroundImage = players[currenPlayer].Mark;

            PlayTimeLine.Push(new PlayInfo(GetChessPoint(btn),CurrenPlayer));

            ChangePlayer();

            if (playerClick != null)
            {
                playerClick(this, new EventArgs());
            }

            if (isEndGame(btn))
            {
                EndGame();
            }
        }
        public void ChangePlayer()
        {
            currenPlayer = currenPlayer == 1 ? 0 : 1;
            if (currenPlayer == 0)
            {
                player1Name.BackColor = Color.Yellow;
                player2Name.BackColor = Color.White;
            }
            else if (currenPlayer == 1)
            {
                player2Name.BackColor = Color.Yellow;
                player1Name.BackColor = Color.White;
            }
        }
        public bool checkNamePlayer()
        {
            if(Player1Name.Text == "Player1" && Player2Name.Text == "Player2")
            {
                return false;
            }
            return true;
        }
        #endregion

    }
}
