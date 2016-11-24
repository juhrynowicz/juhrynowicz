namespace Ping_Pong
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.playground = new System.Windows.Forms.Panel();
            this.gmOver = new System.Windows.Forms.Label();
            this.Space = new System.Windows.Forms.Label();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.Racket2 = new System.Windows.Forms.PictureBox();
            this.Racket1 = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Score = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racket2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racket1)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.BackColor = System.Drawing.SystemColors.ControlText;
            this.playground.Controls.Add(this.gmOver);
            this.playground.Controls.Add(this.Space);
            this.playground.Controls.Add(this.Ball);
            this.playground.Controls.Add(this.Racket2);
            this.playground.Controls.Add(this.Racket1);
            this.playground.Location = new System.Drawing.Point(0, 50);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(692, 577);
            this.playground.TabIndex = 0;
            // 
            // gmOver
            // 
            this.gmOver.AutoSize = true;
            this.gmOver.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gmOver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gmOver.Location = new System.Drawing.Point(276, 219);
            this.gmOver.Name = "gmOver";
            this.gmOver.Size = new System.Drawing.Size(91, 33);
            this.gmOver.TabIndex = 4;
            this.gmOver.Text = "gmOver";
            // 
            // Space
            // 
            this.Space.AutoSize = true;
            this.Space.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Space.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Space.Location = new System.Drawing.Point(274, 148);
            this.Space.Name = "Space";
            this.Space.Size = new System.Drawing.Size(258, 33);
            this.Space.TabIndex = 3;
            this.Space.Text = "Press SPACE to continue";
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Ball.Location = new System.Drawing.Point(118, 304);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(20, 20);
            this.Ball.TabIndex = 2;
            this.Ball.TabStop = false;
            // 
            // Racket2
            // 
            this.Racket2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Racket2.Location = new System.Drawing.Point(250, 33);
            this.Racket2.Name = "Racket2";
            this.Racket2.Size = new System.Drawing.Size(200, 20);
            this.Racket2.TabIndex = 1;
            this.Racket2.TabStop = false;
            // 
            // Racket1
            // 
            this.Racket1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Racket1.Location = new System.Drawing.Point(250, 520);
            this.Racket1.Name = "Racket1";
            this.Racket1.Size = new System.Drawing.Size(200, 20);
            this.Racket1.TabIndex = 0;
            this.Racket1.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Interval = 10;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Score.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Score.Location = new System.Drawing.Point(12, 14);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(103, 33);
            this.Score.TabIndex = 1;
            this.Score.Text = "Player 1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(567, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = ":Player 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(542, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(112, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(692, 623);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.playground);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racket2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racket1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox Racket2;
        private System.Windows.Forms.PictureBox Racket1;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Space;
        private System.Windows.Forms.Label gmOver;
    }
}

