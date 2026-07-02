using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XO_Game.Properties;

namespace XO_Game
{
    public partial class Form1 : Form
    {

        stGameStatus GameStatus;
        enPlayer PlayerTurn = enPlayer.Player1;
        enum enPlayer
        {
            Player1,
            Player2
        }

        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;

        }


        // تعريف مصفوفة تضم الـ 9 صور
        //PictureBox[] board;

        public Form1()
        {
            InitializeComponent();
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    // نربط عناصر المصفوفة بالصور الموجودة على الفورم
        //    board = new PictureBox[] { picb, pictureBox2, pictureBox3,
        //                               pictureBox4, pictureBox5, pictureBox6,
        //                               pictureBox7, pictureBox8, pictureBox9 };  
        //}


        //private void CheckForWinner()
        //{
        //    int[,] winningCombinations = new int[,]
        //    {
        //{0, 1, 2}, {3, 4, 5}, {6, 7, 8}, // الأسطر الأفقية
        //{0, 3, 6}, {1, 4, 7}, {2, 5, 8}, // الأعمدة الرأسية
        //{0, 4, 8}, {2, 4, 6}             // الخطوط القطرية
        //    };

        //    // نمر على كل احتمال من الاحتمالات الثمانية
        //    for (int i = 0; i < 8; i++)
        //    {
        //        int pos1 = winningCombinations[i, 0];
        //        int pos2 = winningCombinations[i, 1];
        //        int pos3 = winningCombinations[i, 2];

        //        if (board[pos1].Tag != null && board[pos2].Tag != null && board[pos3].Tag != null)
        //        {
        //            if (board[pos1].Tag.ToString() == board[pos2].Tag.ToString() &&
        //                board[pos2].Tag.ToString() == board[pos3].Tag.ToString())
        //            {
        //                string winner = board[pos1].Tag.ToString();
        //                LbWinner.Text = $"Winner is: {winner}";
        //                MessageBox.Show($"اللاعب ({winner}) هو الفائز!");

        //                // هام جداً: نقوم بإيقاف الدالة هنا لأننا وجدنا فائزاً
        //                return;
        //            }
        //        }
        //    }

        //    // [التعديل الهام هنا]: 
        //    // إذا وصلنا إلى هذه النقطة، فهذا يعني أن اللعبة مرت على كل شروط الفوز ولم ينجح أي شرط.
        //    // الآن فقط نقوم بفحص إذا كانت النتيجة تعادل أم أن هناك خانات متبقية للعب!
        //    CheckForDraw();
        //}

        //private void CheckForDraw()
        //{
        //    bool draw = true;

        //    for (int i = 0; i < 9; i++)
        //    {
        //        // إذا وجدنا أي خانة لم يتم اللعب فيها بعد (الـ Tag ليس X وليس O)
        //        if (board[i].Tag == null || (board[i].Tag.ToString() != "X" && board[i].Tag.ToString() != "O"))
        //        {
        //            draw = false; // اللعبة ما زالت مستمرة
        //            break;        // نخرج من الفحص فوراً ولا نظهر أي رسالة
        //        }
        //    }

        //    // لن تظهر هذه الرسالة إلا إذا كانت جميع الخانات التسعة ممتلئة بـ X أو O
        //    if (draw)
        //    {
        //        LbWinner.Text = "Draw - No Winner!";
        //        MessageBox.Show("لا يوجد فائز - تعادل!");
        //    }
        //}

        //void UpdateImage(PictureBox picturebox)
        //{
        //    // 1. حماية: نتحقق أولاً إذا كانت الصورة قد تم اللعب بها مسبقاً (حتى لا تتغير إذا ضغط عليها مجدداً)
        //    if (picturebox.Tag != null && (picturebox.Tag.ToString() == "X" || picturebox.Tag.ToString() == "O"))
        //    {
        //        return; // نخرج من الدالة ولا نفعل شيئاً لأن المربع محجوز
        //    }

        //    if (LbTurn.Text == "Player1 [X]")
        //    {
        //        picturebox.Image = Properties.Resources.ImageX;
        //        picturebox.Tag = "X"; // حفظ الحالة في Tag
        //        LbTurn.Text = "Player2 [O]";
        //        CheckForWinner();
        //    }
        //    else
        //    {
        //        picturebox.Image = Properties.Resources.ImageO;
        //        picturebox.Tag = "O"; // حفظ الحالة في Tag
        //        LbTurn.Text = "Player1 [X]";
        //        CheckForWinner();
        //    }

        //    // تحقق من الفائز بعد كل حركة

        //}

        bool CheckValues(PictureBox pictur1, PictureBox picture2, PictureBox pictur3)
        {
            if(pictur1.Tag.ToString() != "?" && pictur1.Tag.ToString() == picture2.Tag.ToString() && pictur1.Tag.ToString() == pictur3.Tag.ToString())
            {
                pictur1.BackColor = Color.Green;
                picture2.BackColor = Color.Green;
                pictur3.BackColor = Color.Green;

                if (pictur1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }

            }

            GameStatus.GameOver = false;
            return false;
        }



        void EndGame()
        {

            LbTurn.Text = "Game Over";
            switch (GameStatus.Winner)
            {

                case enWinner.Player1:

                    LbWinner.Text = "Player1";
                    break;

                case enWinner.Player2:

                    LbWinner.Text = "Player2";
                    break;

                default:

                    LbWinner.Text = "Draw";
                    break;

            }

            MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



        void CheckWinner()
        {
            if (CheckValues(pictur1, pictur2, pictur3))
                return;

            if (CheckValues(pictur4, pictur5, pictur6))
                return;

            if (CheckValues(pictur7, pictur8, pictur9))
                return;

            if (CheckValues(pictur1, pictur4, pictur7))
                return;

            if (CheckValues(pictur2, pictur5, pictur8))
                return;

            if (CheckValues(pictur3, pictur6, pictur9))
                return;

            if (CheckValues(pictur1, pictur5, pictur9))
                return;

            if (CheckValues(pictur3, pictur5, pictur7))
                return;

        }

        void ChangeImage(PictureBox picturebox)
        {
            if (picturebox.Tag.ToString() == "?")
            {
                switch(PlayerTurn)
                {
                   case enPlayer.Player1:
                        picturebox.Image = Properties.Resources.ImageX;
                        picturebox.Tag = "X"; // حفظ الحالة في Tag
                        PlayerTurn = enPlayer.Player2;
                        LbTurn.Text = "Player2 [O]";
                        GameStatus.PlayCount++;
                        CheckWinner();
                        break;
                    case enPlayer.Player2:
                        picturebox.Image = Properties.Resources.ImageO;
                        picturebox.Tag = "O"; // حفظ الحالة في Tag
                        PlayerTurn = enPlayer.Player1;
                        LbTurn.Text = "Player1 [X]";
                        GameStatus.PlayCount++;
                        CheckWinner();
                        break;
                }
            }
            else
            {
                MessageBox.Show("This cell is already occupied. Please choose another one.");
            }

        }

        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color Red = Color.Red;
            Pen MyPen = new Pen(Red);

            MyPen.Width = 7;

            MyPen.StartCap = System.Drawing.Drawing2D.LineCap.Triangle;
            MyPen.EndCap = System.Drawing.Drawing2D.LineCap.Triangle;

            e.Graphics.DrawLine(MyPen, 655, 25, 655, 390);
            e.Graphics.DrawLine(MyPen, 480, 25, 480, 390);

            e.Graphics.DrawLine(MyPen, 350, 135, 785, 135);
            e.Graphics.DrawLine(MyPen, 350, 260, 785, 260);

        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            ChangeImage((PictureBox)sender);
        }

        private void pictur1_Click(object sender, EventArgs e)
        {
            ChangeImage(pictur1);
        }

        private void pictur2_Click(object sender, EventArgs e)
        {
            ChangeImage(pictur2);

        }

        private void pictur3_Click(object sender, EventArgs e)
        {
            ChangeImage(pictur3);
        }

        private void pictur4_Click(object sender, EventArgs e)
        {
            ChangeImage(pictur4);
        }

        private void pictur5_Click(object sender, EventArgs e)
        {
            ChangeImage(pictur5);
        }

        private void pictur6_Click(object sender, EventArgs e)
        {
            ChangeImage(pictur6);
        }

        private void pictur7_Click(object sender, EventArgs e)
        {
            ChangeImage(pictur7);
        }

        private void pictur8_Click(object sender, EventArgs e)
        {
            ChangeImage(pictur8);
        }

        private void pictur9_Click(object sender, EventArgs e)
        {
            ChangeImage(pictur9);
        }


        private void RestButton(PictureBox picture)
        {
            picture.Image = Properties.Resources.ImageQ;
            picture.Tag = "?";
            picture.BackColor = Color.Transparent;

        }
        private void RestartGame()
        {

            RestButton(pictur1);
            RestButton(pictur2);
            RestButton(pictur3);
            RestButton(pictur4);
            RestButton(pictur5);
            RestButton(pictur6);
            RestButton(pictur7);
            RestButton(pictur8);
            RestButton(pictur9);

            PlayerTurn = enPlayer.Player1;
            LbTurn.Text = "Player 1";
            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;
            GameStatus.Winner = enWinner.GameInProgress;
            LbWinner.Text = "In Progress";



        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();

        }

        private void btnResetGame_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
