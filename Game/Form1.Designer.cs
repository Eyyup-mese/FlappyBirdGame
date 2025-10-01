namespace Game
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.birdPictureBox = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.bottomPipe = new System.Windows.Forms.PictureBox();
            this.topPipe = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.birdPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPipe)).BeginInit();
            this.SuspendLayout();
            // 
            // birdPictureBox
            // 
            this.birdPictureBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.birdPictureBox.Location = new System.Drawing.Point(120, 213);
            this.birdPictureBox.Name = "birdPictureBox";
            this.birdPictureBox.Size = new System.Drawing.Size(50, 40);
            this.birdPictureBox.TabIndex = 0;
            this.birdPictureBox.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 25;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // bottomPipe
            // 
            this.bottomPipe.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bottomPipe.Location = new System.Drawing.Point(500, 300);
            this.bottomPipe.Name = "bottomPipe";
            this.bottomPipe.Size = new System.Drawing.Size(80, 150);
            this.bottomPipe.TabIndex = 1;
            this.bottomPipe.TabStop = false;
            // 
            // topPipe
            // 
            this.topPipe.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.topPipe.Location = new System.Drawing.Point(500, 0);
            this.topPipe.Name = "topPipe";
            this.topPipe.Size = new System.Drawing.Size(80, 150);
            this.topPipe.TabIndex = 2;
            this.topPipe.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(1038, 142);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(51, 16);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "score:0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 451);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.topPipe);
            this.Controls.Add(this.bottomPipe);
            this.Controls.Add(this.birdPictureBox);
            this.Location = new System.Drawing.Point(500, 0);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.birdPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox birdPictureBox;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox bottomPipe;
        private System.Windows.Forms.PictureBox topPipe;
        private System.Windows.Forms.Label scoreLabel;
    }
}

