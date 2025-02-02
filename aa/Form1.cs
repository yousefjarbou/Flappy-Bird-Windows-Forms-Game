namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 6;
        int gravity = 10;
        int score = 0;
        bool gameOver = false;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Enabled = false;
            pictureBox1.Visible = false;
            scoreLable.Parent = ground;
            scoreLable.Top += 5;
            scoreLable.Left += 10;
            scoreNumber.Parent = ground;
            scoreNumber.Top += 5;
            scoreNumber.Left += 10;


        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            bird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreNumber.Text = score.ToString();

            if (pipeBottom.Left < -90)
            {
                pipeBottom.Left = new Random().Next(550, 700); ;
                score++;

                if (score < 5) pipeBottom.Top = new Random().Next(320, 380);

                else pipeBottom.Top = new Random().Next(290, 360);

            }


            if (pipeTop.Left < -100)
            {
                pipeTop.Left = new Random().Next(650, 800); ;
                score++;
                if (score < 5) { pipeTop.Top = new Random().Next(-90, -40); }
                else pipeTop.Top = new Random().Next(-70, 0);

            }
            if (bird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                bird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                bird.Bounds.IntersectsWith(ground.Bounds) || bird.Top < -20
                ) { endGame(); }

            if (score > 5 && score < 15)
            {
                pipeSpeed = 8;
            }
            if (score >= 15 && score < 20) { pipeSpeed = 10; }
            if (score >= 20) { pipeSpeed = 15; }


        }

        private void birdUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) { gravity = 10; }
            if (e.KeyCode == Keys.R && gameOver)
            {
                //run restart function
                RestartGame();
            }
        }

        private void RestartGame()
        {
            gameOver = false;
            bird.Location = new Point(113, 177);
            pipeBottom.Location = new Point(303, 324);
            pipeTop.Location = new Point(366, -22);

            score = 0;
            pipeSpeed = 8;
            scoreNumber.Text = "0";

            pictureBox1.Enabled = false;
            pictureBox1.Visible = false;
            gameTimer.Start();
        }

        private void birdDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) { gravity = -10; }
        }

        private void endGame()
        {
            gameTimer.Stop();
            gameOver = true;
            pictureBox1.Enabled = true;
            pictureBox1.Visible = true;
        }

        private void ground_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
