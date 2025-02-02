namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pipeTop = new PictureBox();
            pipeBottom = new PictureBox();
            bird = new PictureBox();
            ground = new PictureBox();
            scoreLable = new Label();
            scoreNumber = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pipeTop
            // 
            pipeTop.Image = Properties.Resources.toppipe;
            pipeTop.Location = new Point(366, -22);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(87, 173);
            pipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeTop.TabIndex = 0;
            pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            pipeBottom.Image = Properties.Resources.bottompipe;
            pipeBottom.Location = new Point(303, 324);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(87, 172);
            pipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBottom.TabIndex = 1;
            pipeBottom.TabStop = false;
            // 
            // bird
            // 
            bird.Image = Properties.Resources.bird;
            bird.Location = new Point(113, 177);
            bird.Name = "bird";
            bird.Size = new Size(63, 48);
            bird.SizeMode = PictureBoxSizeMode.StretchImage;
            bird.TabIndex = 2;
            bird.TabStop = false;
            // 
            // ground
            // 
            ground.Image = Properties.Resources.ground___Copy;
            ground.Location = new Point(-13, 459);
            ground.Name = "ground";
            ground.Size = new Size(543, 289);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 3;
            ground.TabStop = false;
            ground.Click += ground_Click;
            // 
            // scoreLable
            // 
            scoreLable.AutoSize = true;
            scoreLable.BackColor = Color.Transparent;
            scoreLable.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreLable.Location = new Point(-1, -4);
            scoreLable.Name = "scoreLable";
            scoreLable.Size = new Size(89, 31);
            scoreLable.TabIndex = 4;
            scoreLable.Text = "Score:";
            // 
            // scoreNumber
            // 
            scoreNumber.AutoSize = true;
            scoreNumber.BackColor = Color.Transparent;
            scoreNumber.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreNumber.Location = new Point(82, -4);
            scoreNumber.Name = "scoreNumber";
            scoreNumber.Size = new Size(32, 31);
            scoreNumber.TabIndex = 5;
            scoreNumber.Text = "0";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.restartImage;
            pictureBox1.Location = new Point(200, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(521, 534);
            Controls.Add(pictureBox1);
            Controls.Add(scoreNumber);
            Controls.Add(scoreLable);
            Controls.Add(bird);
            Controls.Add(pipeTop);
            Controls.Add(ground);
            Controls.Add(pipeBottom);
            Name = "Form1";
            Text = "Flappy Bird";
            KeyDown += birdDown;
            KeyUp += birdUp;
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)bird).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pipeTop;
        private PictureBox pipeBottom;
        private PictureBox bird;
        private PictureBox ground;
        private Label scoreLable;
        private Label scoreNumber;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox pictureBox1;
    }
}
