using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        int gravity = 1;
        int jump = -10;
        int birdVelocity = 0;
        int score = 0;
        int pipeGap = 150;

        bool isGameOver = false;
        Random rnd = new Random();

        // Hız kontrolü
        float pipeSpeed = 3f;         // başlangıç hızı
        float maxPipeSpeed = 20f;     // maksimum hız
        float speedIncrement = 0.01f; // her tick artış miktarı

        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (isGameOver)
                {
                    RestartGame();
                }
                else
                {
                    birdVelocity = jump;
                }
            }
        }

        private void RestartGame()
        {
            birdPictureBox.Top = 200;
            birdVelocity = 0;

            topPipe.Left = 500;
            bottomPipe.Left = 500;

            score = 0;
            scoreLabel.Text = "Score: 0";

            isGameOver = false;

            pipeSpeed = 5f; // hız sıfırlanır

            gameTimer.Start();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // Kuş hareketi
            birdPictureBox.Top += birdVelocity;
            birdVelocity += gravity;

            // Boru hızını artır, maxPipeSpeed'i geçme
            if (pipeSpeed < maxPipeSpeed)
            {
                pipeSpeed += speedIncrement;
            }

            // Boruları sola kaydır
            topPipe.Left -= (int)pipeSpeed;
            bottomPipe.Left -= (int)pipeSpeed;

            // Borular ekranın solundan çıkarsa tekrar sağa gönder ve rastgele yükseklik ayarla
            if (topPipe.Right < 0)
            {
                int topHeight = rnd.Next(50, this.ClientSize.Height - pipeGap - 50);
                topPipe.Height = topHeight;

                bottomPipe.Top = topHeight + pipeGap;
                bottomPipe.Height = this.ClientSize.Height - bottomPipe.Top;

                topPipe.Left = 500;
                bottomPipe.Left = 500;

                score++;
                scoreLabel.Text = "Score: " + score;
            }

            // Çarpışma ve ekran altına düşme kontrolü
            if (birdPictureBox.Top + birdPictureBox.Height > this.ClientSize.Height ||
                birdPictureBox.Bounds.IntersectsWith(topPipe.Bounds) ||
                birdPictureBox.Bounds.IntersectsWith(bottomPipe.Bounds))
            {
                gameTimer.Stop();
                MessageBox.Show("Oyun Bitti!");
                isGameOver = true;
            }
        }
    }


}
