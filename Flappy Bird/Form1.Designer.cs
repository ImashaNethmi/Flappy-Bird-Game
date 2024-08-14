namespace Flappy_Bird
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
            ground = new PictureBox();
            flappyBird = new PictureBox();
            pipeTop = new PictureBox();
            pipeBottom = new PictureBox();
            scoreText = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            SuspendLayout();
            // 
            // ground
            // 
            ground.Image = Properties.Resources.ground;
            ground.Location = new Point(-1, 578);
            ground.Name = "ground";
            ground.Size = new Size(662, 90);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 0;
            ground.TabStop = false;
            // 
            // flappyBird
            // 
            flappyBird.Image = Properties.Resources.bird;
            flappyBird.Location = new Point(109, 224);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new Size(92, 88);
            flappyBird.SizeMode = PictureBoxSizeMode.StretchImage;
            flappyBird.TabIndex = 1;
            flappyBird.TabStop = false;
            // 
            // pipeTop
            // 
            pipeTop.Image = Properties.Resources.pipedown;
            pipeTop.Location = new Point(506, -13);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(92, 198);
            pipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeTop.TabIndex = 2;
            pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            pipeBottom.Image = Properties.Resources.pipe;
            pipeBottom.Location = new Point(342, 403);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(92, 191);
            pipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBottom.TabIndex = 2;
            pipeBottom.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.BackColor = Color.Khaki;
            scoreText.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreText.Location = new Point(109, 613);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(120, 33);
            scoreText.TabIndex = 3;
            scoreText.Text = "Score:0";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(658, 680);
            Controls.Add(flappyBird);
            Controls.Add(scoreText);
            Controls.Add(pipeBottom);
            Controls.Add(pipeTop);
            Controls.Add(ground);
            Name = "Form1";
            Text = "Flappy Bird";
            KeyDown += gamekeyisdown;
            KeyUp += gamekeyisup;
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ground;
        private PictureBox flappyBird;
        private PictureBox pipeTop;
        private PictureBox pipeBottom;
        private Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}
