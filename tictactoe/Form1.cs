using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        TictactoePlayer[] players;
        Action<Image>[] setFaceImageFuncs;
        Tictactoe game;
        int turnPlayerIndex;
        PictureBox[] pictureBoxes;
        int gameState;
        Timer timer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler((o, a) =>
            {
                ProcessTurn();
            });
            pictureBoxes = new PictureBox[]
            {
                pictureBox1, pictureBox2, pictureBox3,
                pictureBox4, pictureBox5, pictureBox6,
                pictureBox7, pictureBox8, pictureBox9
            };
            gamePanel.Controls.Add(gameBoard);
            gamePanel.Controls.Add(faceBox);
            gamePanel.Controls.Add(faceBox2);
            gamePanel.Controls.Add(serifBox);
            gamePanel.Controls.Add(statusBox);
            gamePanel.Controls.Add(goTopButton);
            startPanel.Controls.Add(gamePanel);
            startPanel.Controls.Add(systemPanel);
            startPanel.Controls.Add(gameStartButton);
            gamePanel.Visible = false;
        }

        private static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        private void gameStartButtonClick(object sender, EventArgs e)
        {
            timer.Stop();

            this.gameState = 0;
            this.game = new Tictactoe();
            this.setFaceImageFuncs = new Action<Image>[] {
                (img) => { img.RotateFlip(RotateFlipType.RotateNoneFlipX); this.faceBox.Image = img; },
                (img) => { this.faceBox2.Image = img; }
            };
            if (pvpButton.Checked)
            {
                this.players = new TictactoePlayer[] { new Player(Mark.MARU), new Player(Mark.PEKE) };
            }
            else if (pvnButton.Checked)
            {
                this.players = new TictactoePlayer[] { new Player(Mark.MARU), new AIPlayer(Mark.PEKE) };
            }
            else if (nvnButton.Checked)
            {
                this.players = new TictactoePlayer[] { new AIPlayer(Mark.MARU), new AIPlayer(Mark.PEKE) };
            }
            else
            {
                throw new Exception();
            }

            if (fromPlayer2.Checked)
            {
                Swap(ref players[0], ref players[1]);
            }
            else if (fromRandom.Checked)
            {
                Random rd = new Random();
                if (rd.Next(2) == 0)
                {
                    Swap(ref players[0], ref players[1]);
                }
            }

            setFaceImageFuncs[0](players[0].GetFaceImage());
            setFaceImageFuncs[1](players[1].GetFaceImage());
            serifBox.Text = "";
            statusBox.Text = "";

            this.turnPlayerIndex = 0;
            gamePanel.Visible = true;

            DrawBoard();
            ProcessTurn();
        }

        private void DrawBoard()
        {
            for (int i = 0; i < game.Size * game.Size; i++)
            {
                Point p = Point.FromOneDim((uint)i, game.Size);
                int s = game.GetAt(p.X, p.Y);
                if (s == 0)
                {
                    pictureBoxes[i].Image = null;
                }
                else
                {
                    pictureBoxes[i].Image = GetMarkImage((Mark)s);
                }
            }
        }


        private void ProcessTurn()
        {
            timer.Stop();

            TictactoePlayer turnPlayer = GetTurnPlayer();
            if (!turnPlayer.IsReady())
            {
                return;
            }
            Point putAt = turnPlayer.Action(game);
            statusBox.Text = GetMarkName(turnPlayer.Mark) + ":(" + putAt.X.ToString() + ", " + putAt.Y.ToString() + ")";

            DrawBoard();
            setFaceImageFuncs[turnPlayerIndex](turnPlayer.GetFaceImage());
            serifBox.Text = turnPlayer.GetSerif();
            if (game.IsWin(turnPlayer.Mark))
            {
                statusBox.Text = GetMarkName(turnPlayer.Mark) + " User is Win";
                this.gameState = 1;
                return;
            }
            if (game.IsFulfilled())
            {
                statusBox.Text = "Draw";
                this.gameState = 1;
                return;
            }

            this.Refresh();
            turnPlayerIndex = (turnPlayerIndex + 1) % players.Length;

            timer.Start();
        }

        private string GetMarkName(Mark mark)
        {
            switch (mark)
            {
                case Mark.MARU:
                    return "O";
                case Mark.PEKE:
                    return "X";
            }
            throw new Exception("UNKNOWN MARK");
        }

        private Image GetMarkImage(Mark mark)
        {
            switch(mark)
            {
                case Mark.MARU:
                    return Image.FromFile("maru.png");
                case Mark.PEKE:
                    return Image.FromFile("peke.png");
            }
            throw new Exception("UNKNOWN MARK");
        }

        private TictactoePlayer GetTurnPlayer()
        {
            return this.players[this.turnPlayerIndex];
        }

        private void cellClick(object sender, EventArgs e)
        {
            if (gameState != 0)
            {
                return;
            }
            if (!GetTurnPlayer().IsWaitingUserInput())
            {
                return;
            }

            PictureBox cell = (PictureBox)sender;
            int n;
            if (int.TryParse(cell.Name.Substring(cell.Name.Length-1), out n))
            {

                Point p = Point.FromOneDim((uint)n-1, game.Size);
                if (! game.IsPuttable(p))
                {
                    return;
                }
                GetTurnPlayer().Put(p);
                ProcessTurn();
            }
        }

        private void goTopButton_Click(object sender, EventArgs e)
        {
            gamePanel.Visible = false;

        }
    }

    class Point {
        public int X;
        public int Y;
        public Point (int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public bool IsInSquare(uint size)
        {
            return 0 <= X && X < size && 0 <= Y && Y < size;
        }
        public static Point FromOneDim(uint p, uint size)
        {
            uint x = p % size;
            uint y = p / size;
            return new Point((int)x, (int)y);
        }
        public uint ToOneDim(uint size)
        {
            return (uint)(Y * size + X);
        }
    }
    enum Mark
    {
        MARU = 1,
        PEKE = -1
    }
    class Tictactoe
    {
        private int[,] state;
        private readonly uint size;
        private int turn;

        public uint Size { get { return size; }}

        public int[,] State { get { return state;} }

        public Tictactoe(int[,] state)
        {
            this.state = new int[state.GetLength(0), state.GetLength(1)];
            Array.Copy(state, this.state, state.Length);
            this.turn = 0;
            this.size = (uint)state.GetLength(0);
        }
        public Tictactoe ()
        {
            this.size = 3;
            this.state = new int[this.size, this.size];
            this.turn = 0;
        }
        public bool IsFulfilled()
        {
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    if (this.state[y, x] == 0) { return false; }
                }
            }
            return true;
        }
        public bool IsWin(Mark mark)
        {
            for (int y = 0; y < size; y++)
            {
                int sum1 = 0;
                int sum2 = 0;
                for (int x = 0; x < size; x++)
                {
                    sum1 += state[y, x];
                    sum2 += state[x, y];
                }
                if (sum1 == (int)mark* size || sum2 == (int)mark*size)
                {
                    return true;
                }
            }

            int sum3 = 0;
            int sum4 = 0;
            for (int i = 0; i < size; i++)
            {
                sum3 += state[i, i];
                sum4 += state[size - i - 1, i];
            }
            if (sum3 == (int)mark * size || sum4 == (int)mark * size)
            {
                return true;
            }
            return false;
        }

        public bool Put(Point p, Mark mark)
        {
            if (!p.IsInSquare(this.size) || this.state[p.Y, p.X] != 0)
            {
                return false;
            }
            this.state[p.Y, p.X] = (int)mark;
            this.turn++;
            return true;
        }

        public bool IsPuttable(Point p)
        {
            return p.IsInSquare(this.size) && this.state[p.Y, p.X] == 0;

        }
        public bool IsPuttable(int x, int y)
        {
            return this.IsPuttable(new Point(x, y));
        }
        public int GetAt(int x, int y)
        {
            return this.state[y,x];
        }

    }

    class FaceImage
    {
    public static Image GetNormalFace()
        {
            return Image.FromFile("ai_normal.png");
        }
        public static Image GetChanceFace()
        {
            return Image.FromFile("ai_chance.png");
        }
        public static Image GetPinchImage()
        {
            return Image.FromFile("ai_pinch.png");
        }

    }

    interface TictactoePlayer
    {
        Point Action(Tictactoe game);
        bool IsReady();
        bool IsWaitingUserInput();
        void Put(Point p);
        Image GetFaceImage();
        string GetSerif();
        Mark Mark { get; set; }
    }



    class AIPlayer : TictactoePlayer
    {
        private Mark mark;
        public Mark Mark { get { return mark; } set { mark = value;} }
        private Image nextFace;
        private string nextSerif;
        public AIPlayer(Mark mark)
        {
            this.mark = mark;
            this.nextFace = FaceImage.GetNormalFace();
            this.nextSerif = "";
        }

        public Image GetFaceImage()
        {
            return nextFace;
        }
        public string GetSerif()
        {
            return nextSerif;
        }

        public double NegMax(Tictactoe game, Mark mark)
        {
            //if (game.IsWin(mark)) { return -10; }
            if (game.IsWin((Mark)(-(int)mark))) { return -10; }
            else if (game.IsFulfilled())
            {
                return 0;
            }

            double max = -100;
            for (int y = 0; y < game.Size; y++)
            {
                for (int x = 0; x < game.Size; x++)
                {
                    if (game.IsPuttable(x, y))
                    {
                        Point p = new Point(x, y);
                        Tictactoe newScene = new Tictactoe(game.State);
                        newScene.Put(p, mark);
                        max = Math.Max(max, -NegMax(newScene, (Mark)(-(int)mark)));
                    }
                }
            }

            return max*0.9;
        }

        public Point SearchToPut2(Tictactoe game)
        {
            List<Point> ps = new List<Point>();
            double max = -100;
            for (int y = 0; y < game.Size; y++)
            {
                for (int x = 0; x < game.Size; x++)
                {
                    if (game.IsPuttable(x, y))
                    {
                        Point p = new Point(x, y);
                        Tictactoe newScene = new Tictactoe(game.State);
                        newScene.Put(p, mark);
                        double v = -NegMax(newScene, (Mark)(-(int)mark));

                        //Console.WriteLine("Put at (" + p.X.ToString() + ", " + p.Y.ToString() + ") is " + v.ToString());
                        if (max < v)
                        {
                            ps.Clear();
                            ps.Add(p);
                            max = v;
                        }
                        else if (max == v)
                        {
                            ps.Add(p);
                        }
                    }
                }
            }
            Random rd = new Random();

            List<string> nextSerifs = new List<string>();
            if (max > 7)
            {
                nextFace = FaceImage.GetChanceFace();
                nextSerifs.Add("ハッハー！　勝つるでござる！");
                nextSerifs.Add("これでどうでござるか？");
                nextSerifs.Add("ざるそば！！！");
            }
            else if (ps.Count == 1)
            {
                nextFace = FaceImage.GetPinchImage();
                nextSerifs.Add("ここしかないでござるな！？");
                nextSerifs.Add("むむむ……");
                nextSerifs.Add("勘弁してほしいでござる！");
            }
            else
            {
                nextFace = FaceImage.GetNormalFace();
                nextSerifs.Add("ま、この辺りでござろ");
                nextSerifs.Add("拙者ざるそばが大好きでござるよ");
                nextSerifs.Add("勝ったら借金はチャラでござる！　忘れないでくだされ");
            }
            nextSerif = nextSerifs.ElementAt(rd.Next(nextSerifs.Count));
            return ps.ElementAt(rd.Next(ps.Count));
        }
        
        public Point SearchToPut(Tictactoe game)
        {
            // a=1 自分が勝てる筋があれば置く
            // a=-1 相手が勝てる筋があれば置く
            for (int a = 1; a == 1 || a == -1; a -= 2)
            {
                for (int y = 0; y < game.Size; y++)
                {
                    int sum1 = 0; int sum2 = 0;
                    for (int x = 0; x < game.Size; x++)
                    {
                        sum1 += game.GetAt(x, y);
                        sum2 += game.GetAt(y, x);
                    }
                    if (sum1 == (int)this.mark * (game.Size - 1) * a)
                    {
                        for (int x = 0; x < game.Size; x++)
                        {
                            if (game.IsPuttable(x, y))
                            {
                                return new Point(x, y);
                            }
                        }
                    }
                    if (sum2 == (int)this.mark * (game.Size - 1) * a)
                    {
                        for (int x = 0; x < game.Size; x++)
                        {
                            if (game.IsPuttable(y, x))
                            {
                                return new Point(y, x);
                            }
                        }
                    }
                }
                {
                    int sum1 = 0; int sum2 = 0;
                    for (int i = 0; i < game.Size; i++)
                    {
                        sum1 += game.GetAt(i, i);
                        sum2 += game.GetAt(i, (int)game.Size -i - 1);
                    }
                    if (sum1 == (int)this.mark * (game.Size - 1) * a)
                    {
                        for (int i = 0; i < game.Size; i++)
                        {
                            if (game.IsPuttable(i, i))
                            {
                                return new Point(i, i);
                            }
                        }
                    }
                    if (sum2 == (int)this.mark * (game.Size - 1) * a)
                    {
                        for (int i = 0; i < game.Size; i++)
                        {
                            if (game.IsPuttable(i, (int)game.Size - i - 1))
                            {
                                return new Point(i, (int)game.Size -i -1);
                            }
                        }
                    }
                }
            }

            // 真ん中におけるなら置く
            if (game.IsPuttable((int)game.Size/2, (int)game.Size/2))
            {
                return new Point((int)game.Size / 2, (int)game.Size / 2);
            }

            // 四隅を狙う
            for (int y = 0; y < game.Size; y += (int)game.Size-1)
            {
                for (int x = 0; x < game.Size; x += (int)game.Size - 1)
                {
                    if (game.IsPuttable(x,y))
                    {
                        return new Point(x, y);
                    }
                }

            }
            
            // どこでもいいからおけるところに置く
            for (int y = 0; y < game.Size; y++)
            {
                for (int x = 0; x < game.Size; x++)
                {
                    if (game.IsPuttable(x,y))
                    {
                        return new Point(x, y);
                    }
                }
            }

            throw new Exception("Unreachable");
        }

        

        public Point Action(Tictactoe game)
        {
            Point at = this.SearchToPut2(game);
            if (!game.Put(at, this.mark))
            {
                throw new Exception("Not Puttable At...");
            }
            return at;
        }

        public bool IsReady()
        {
            return true;
        }

        public bool IsWaitingUserInput()
        {
            return false;
        }

        public void Put(Point p)
        {
            throw new NotImplementedException();
        }
    }

    class Player : TictactoePlayer
    {
        private Mark mark;
        private Point willPut;

        public Player(Mark mark)
        {
            this.mark = mark;
            this.willPut = null;
        }

        public Mark Mark { get { return mark; } set { mark = value; } }

        public Point Action(Tictactoe game)
        {
            if (! game.Put(willPut, this.mark))
            {
                throw new Exception("Not Puttable At...");
            }
            Point p = new Point(willPut.X, willPut.Y);
            this.willPut = null;
            return p;
        }

        public bool IsWaitingUserInput()
        {
            return !this.IsReady();
        }

        public void Put(Point p)
        {
            this.willPut = p;
        }

        public bool IsReady()
        {
            return this.willPut != null;
        }

        public Image GetFaceImage()
        {
            return FaceImage.GetNormalFace();
        }

        public string GetSerif()
        {
            return "";
        }
    }

}
