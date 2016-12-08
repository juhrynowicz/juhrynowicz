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
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel1 = new System.Windows.Forms.Label();
            this.scoreLabel2 = new System.Windows.Forms.Label();
            this.scoreLabel4 = new System.Windows.Forms.Label();
            this.scoreLabel3 = new System.Windows.Forms.Label();
            this.Racket1 = new System.Windows.Forms.PictureBox();
            this.Racket2 = new System.Windows.Forms.PictureBox();
            this.aBall = new System.Windows.Forms.PictureBox();
            this.powerUp = new System.Windows.Forms.PictureBox();
            this.com1Menu = new System.Windows.Forms.Label();
            this.networkMenu = new System.Windows.Forms.Label();
            this.vsBot = new System.Windows.Forms.Label();
            this.spaceLabel = new System.Windows.Forms.Label();
            this.goLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Racket1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racket2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerUp)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Interval = 10;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // scoreLabel1
            // 
            this.scoreLabel1.AutoSize = true;
            this.scoreLabel1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.scoreLabel1.Location = new System.Drawing.Point(12, 14);
            this.scoreLabel1.Name = "scoreLabel1";
            this.scoreLabel1.Size = new System.Drawing.Size(103, 33);
            this.scoreLabel1.TabIndex = 1;
            this.scoreLabel1.Text = "Player 1:";
            // 
            // scoreLabel2
            // 
            this.scoreLabel2.AutoSize = true;
            this.scoreLabel2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.scoreLabel2.Location = new System.Drawing.Point(567, 14);
            this.scoreLabel2.Name = "scoreLabel2";
            this.scoreLabel2.Size = new System.Drawing.Size(103, 33);
            this.scoreLabel2.TabIndex = 2;
            this.scoreLabel2.Text = ":Player 2";
            // 
            // scoreLabel4
            // 
            this.scoreLabel4.AutoSize = true;
            this.scoreLabel4.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreLabel4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.scoreLabel4.Location = new System.Drawing.Point(542, 14);
            this.scoreLabel4.Name = "scoreLabel4";
            this.scoreLabel4.Size = new System.Drawing.Size(29, 33);
            this.scoreLabel4.TabIndex = 4;
            this.scoreLabel4.Text = "0";
            // 
            // scoreLabel3
            // 
            this.scoreLabel3.AutoSize = true;
            this.scoreLabel3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreLabel3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.scoreLabel3.Location = new System.Drawing.Point(112, 14);
            this.scoreLabel3.Name = "scoreLabel3";
            this.scoreLabel3.Size = new System.Drawing.Size(29, 33);
            this.scoreLabel3.TabIndex = 3;
            this.scoreLabel3.Text = "0";
            // 
            // Racket1
            // 
            this.Racket1.Location = new System.Drawing.Point(256, 524);
            this.Racket1.Name = "Racket1";
            this.Racket1.Size = new System.Drawing.Size(200, 20);
            this.Racket1.TabIndex = 5;
            this.Racket1.TabStop = false;
            // 
            // Racket2
            // 
            this.Racket2.Location = new System.Drawing.Point(256, 70);
            this.Racket2.Name = "Racket2";
            this.Racket2.Size = new System.Drawing.Size(200, 20);
            this.Racket2.TabIndex = 6;
            this.Racket2.TabStop = false;
            // 
            // aBall
            // 
            this.aBall.Enabled = false;
            this.aBall.Location = new System.Drawing.Point(660, 507);
            this.aBall.Name = "aBall";
            this.aBall.Size = new System.Drawing.Size(20, 20);
            this.aBall.TabIndex = 7;
            this.aBall.TabStop = false;
            // 
            // powerUp
            // 
            this.powerUp.Enabled = false;
            this.powerUp.Location = new System.Drawing.Point(12, 537);
            this.powerUp.Name = "powerUp";
            this.powerUp.Size = new System.Drawing.Size(35, 35);
            this.powerUp.TabIndex = 8;
            this.powerUp.TabStop = false;
            this.powerUp.Visible = false;
            // 
            // com1Menu
            // 
            this.com1Menu.AutoSize = true;
            this.com1Menu.BackColor = System.Drawing.SystemColors.ControlText;
            this.com1Menu.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.com1Menu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.com1Menu.Location = new System.Drawing.Point(211, 211);
            this.com1Menu.Name = "com1Menu";
            this.com1Menu.Size = new System.Drawing.Size(307, 47);
            this.com1Menu.TabIndex = 9;
            this.com1Menu.Text = "1 vs 1 (1 Computer)";
            this.com1Menu.Click += new System.EventHandler(this.label4_Click);
            // 
            // networkMenu
            // 
            this.networkMenu.AutoSize = true;
            this.networkMenu.BackColor = System.Drawing.SystemColors.ControlText;
            this.networkMenu.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.networkMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.networkMenu.Location = new System.Drawing.Point(211, 268);
            this.networkMenu.Name = "networkMenu";
            this.networkMenu.Size = new System.Drawing.Size(258, 47);
            this.networkMenu.TabIndex = 10;
            this.networkMenu.Text = "1 vs 1 (Network)";
            this.networkMenu.Click += new System.EventHandler(this.label5_Click);
            // 
            // vsBot
            // 
            this.vsBot.AutoSize = true;
            this.vsBot.BackColor = System.Drawing.SystemColors.ControlText;
            this.vsBot.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vsBot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vsBot.Location = new System.Drawing.Point(211, 315);
            this.vsBot.Name = "vsBot";
            this.vsBot.Size = new System.Drawing.Size(188, 47);
            this.vsBot.TabIndex = 11;
            this.vsBot.Text = "1 vs 1 (Bot)";
            this.vsBot.Click += new System.EventHandler(this.vsBot_Click);
            // 
            // spaceLabel
            // 
            this.spaceLabel.AutoSize = true;
            this.spaceLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.spaceLabel.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.spaceLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.spaceLabel.Location = new System.Drawing.Point(211, 362);
            this.spaceLabel.Name = "spaceLabel";
            this.spaceLabel.Size = new System.Drawing.Size(349, 47);
            this.spaceLabel.TabIndex = 12;
            this.spaceLabel.Text = "Press Space to Continue";
            // 
            // goLabel
            // 
            this.goLabel.AutoSize = true;
            this.goLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.goLabel.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.goLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.goLabel.Location = new System.Drawing.Point(270, 164);
            this.goLabel.Name = "goLabel";
            this.goLabel.Size = new System.Drawing.Size(186, 47);
            this.goLabel.TabIndex = 13;
            this.goLabel.Text = "Game Over \r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(692, 573);
            this.Controls.Add(this.goLabel);
            this.Controls.Add(this.spaceLabel);
            this.Controls.Add(this.vsBot);
            this.Controls.Add(this.networkMenu);
            this.Controls.Add(this.com1Menu);
            this.Controls.Add(this.powerUp);
            this.Controls.Add(this.aBall);
            this.Controls.Add(this.Racket2);
            this.Controls.Add(this.Racket1);
            this.Controls.Add(this.scoreLabel4);
            this.Controls.Add(this.scoreLabel3);
            this.Controls.Add(this.scoreLabel2);
            this.Controls.Add(this.scoreLabel1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Racket1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racket2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label scoreLabel1;
        private System.Windows.Forms.Label scoreLabel2;
        private System.Windows.Forms.Label scoreLabel4;
        private System.Windows.Forms.Label scoreLabel3;
        private System.Windows.Forms.PictureBox Racket1;
        private System.Windows.Forms.PictureBox Racket2;
        private System.Windows.Forms.PictureBox aBall;
        private System.Windows.Forms.PictureBox powerUp;
        private System.Windows.Forms.Label com1Menu;
        private System.Windows.Forms.Label networkMenu;
        private System.Windows.Forms.Label vsBot;
        private System.Windows.Forms.Label spaceLabel;
        private System.Windows.Forms.Label goLabel;
    }
}

