namespace XO_Game
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
            this.label1 = new System.Windows.Forms.Label();
            this.LbTurn = new System.Windows.Forms.Label();
            this.LbWinner = new System.Windows.Forms.Label();
            this.btnResetGame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictur2 = new System.Windows.Forms.PictureBox();
            this.pictur3 = new System.Windows.Forms.PictureBox();
            this.pictur6 = new System.Windows.Forms.PictureBox();
            this.pictur5 = new System.Windows.Forms.PictureBox();
            this.pictur4 = new System.Windows.Forms.PictureBox();
            this.pictur7 = new System.Windows.Forms.PictureBox();
            this.pictur8 = new System.Windows.Forms.PictureBox();
            this.pictur9 = new System.Windows.Forms.PictureBox();
            this.pictur1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictur2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictur3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictur6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictur5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictur4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictur7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictur8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictur9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictur1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(49, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 52);
            this.label1.TabIndex = 9;
            this.label1.Text = "XO Game";
            // 
            // LbTurn
            // 
            this.LbTurn.AutoSize = true;
            this.LbTurn.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTurn.ForeColor = System.Drawing.Color.Black;
            this.LbTurn.Location = new System.Drawing.Point(129, 229);
            this.LbTurn.Name = "LbTurn";
            this.LbTurn.Size = new System.Drawing.Size(169, 36);
            this.LbTurn.TabIndex = 10;
            this.LbTurn.Text = "Player1 [X]";
            // 
            // LbWinner
            // 
            this.LbWinner.AutoSize = true;
            this.LbWinner.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbWinner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LbWinner.Location = new System.Drawing.Point(34, 287);
            this.LbWinner.Name = "LbWinner";
            this.LbWinner.Size = new System.Drawing.Size(195, 36);
            this.LbWinner.TabIndex = 11;
            this.LbWinner.Text = "Winner is : ?";
            // 
            // btnResetGame
            // 
            this.btnResetGame.BackColor = System.Drawing.Color.Firebrick;
            this.btnResetGame.FlatAppearance.BorderSize = 0;
            this.btnResetGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetGame.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetGame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnResetGame.Location = new System.Drawing.Point(81, 345);
            this.btnResetGame.Name = "btnResetGame";
            this.btnResetGame.Size = new System.Drawing.Size(139, 37);
            this.btnResetGame.TabIndex = 12;
            this.btnResetGame.Text = "Reset Game";
            this.btnResetGame.UseVisualStyleBackColor = false;
            this.btnResetGame.Click += new System.EventHandler(this.btnResetGame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::XO_Game.Properties.Resources.ImageGame;
            this.pictureBox1.Location = new System.Drawing.Point(81, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "0";
            // 
            // pictur2
            // 
            this.pictur2.Image = global::XO_Game.Properties.Resources.ImageQ;
            this.pictur2.Location = new System.Drawing.Point(512, 39);
            this.pictur2.Name = "pictur2";
            this.pictur2.Size = new System.Drawing.Size(93, 80);
            this.pictur2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictur2.TabIndex = 8;
            this.pictur2.TabStop = false;
            this.pictur2.Tag = "?";
            this.pictur2.Click += new System.EventHandler(this.pictur2_Click);
            // 
            // pictur3
            // 
            this.pictur3.Image = global::XO_Game.Properties.Resources.ImageQ;
            this.pictur3.Location = new System.Drawing.Point(680, 39);
            this.pictur3.Name = "pictur3";
            this.pictur3.Size = new System.Drawing.Size(93, 80);
            this.pictur3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictur3.TabIndex = 7;
            this.pictur3.TabStop = false;
            this.pictur3.Tag = "?";
            this.pictur3.Click += new System.EventHandler(this.pictur3_Click);
            // 
            // pictur6
            // 
            this.pictur6.Image = global::XO_Game.Properties.Resources.ImageQ;
            this.pictur6.Location = new System.Drawing.Point(680, 164);
            this.pictur6.Name = "pictur6";
            this.pictur6.Size = new System.Drawing.Size(93, 80);
            this.pictur6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictur6.TabIndex = 6;
            this.pictur6.TabStop = false;
            this.pictur6.Tag = "?";
            this.pictur6.Click += new System.EventHandler(this.pictur6_Click);
            // 
            // pictur5
            // 
            this.pictur5.Image = global::XO_Game.Properties.Resources.ImageQ;
            this.pictur5.Location = new System.Drawing.Point(512, 164);
            this.pictur5.Name = "pictur5";
            this.pictur5.Size = new System.Drawing.Size(93, 80);
            this.pictur5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictur5.TabIndex = 5;
            this.pictur5.TabStop = false;
            this.pictur5.Tag = "?";
            this.pictur5.Click += new System.EventHandler(this.pictur5_Click);
            // 
            // pictur4
            // 
            this.pictur4.Image = global::XO_Game.Properties.Resources.ImageQ;
            this.pictur4.Location = new System.Drawing.Point(353, 164);
            this.pictur4.Name = "pictur4";
            this.pictur4.Size = new System.Drawing.Size(93, 80);
            this.pictur4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictur4.TabIndex = 4;
            this.pictur4.TabStop = false;
            this.pictur4.Tag = "?";
            this.pictur4.Click += new System.EventHandler(this.pictur4_Click);
            // 
            // pictur7
            // 
            this.pictur7.Image = global::XO_Game.Properties.Resources.ImageQ;
            this.pictur7.Location = new System.Drawing.Point(353, 293);
            this.pictur7.Name = "pictur7";
            this.pictur7.Size = new System.Drawing.Size(93, 80);
            this.pictur7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictur7.TabIndex = 3;
            this.pictur7.TabStop = false;
            this.pictur7.Tag = "?";
            this.pictur7.Click += new System.EventHandler(this.pictur7_Click);
            // 
            // pictur8
            // 
            this.pictur8.Image = global::XO_Game.Properties.Resources.ImageQ;
            this.pictur8.Location = new System.Drawing.Point(512, 293);
            this.pictur8.Name = "pictur8";
            this.pictur8.Size = new System.Drawing.Size(93, 80);
            this.pictur8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictur8.TabIndex = 2;
            this.pictur8.TabStop = false;
            this.pictur8.Tag = "?";
            this.pictur8.Click += new System.EventHandler(this.pictur8_Click);
            // 
            // pictur9
            // 
            this.pictur9.Image = global::XO_Game.Properties.Resources.ImageQ;
            this.pictur9.Location = new System.Drawing.Point(680, 293);
            this.pictur9.Name = "pictur9";
            this.pictur9.Size = new System.Drawing.Size(93, 80);
            this.pictur9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictur9.TabIndex = 1;
            this.pictur9.TabStop = false;
            this.pictur9.Tag = "?";
            this.pictur9.Click += new System.EventHandler(this.pictur9_Click);
            // 
            // pictur1
            // 
            this.pictur1.Image = global::XO_Game.Properties.Resources.ImageQ;
            this.pictur1.Location = new System.Drawing.Point(353, 39);
            this.pictur1.Name = "pictur1";
            this.pictur1.Size = new System.Drawing.Size(93, 80);
            this.pictur1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictur1.TabIndex = 0;
            this.pictur1.TabStop = false;
            this.pictur1.Tag = "?";
            this.pictur1.Click += new System.EventHandler(this.pictur1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(34, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 36);
            this.label3.TabIndex = 14;
            this.label3.Text = "Turn :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(882, 468);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnResetGame);
            this.Controls.Add(this.LbWinner);
            this.Controls.Add(this.LbTurn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictur2);
            this.Controls.Add(this.pictur3);
            this.Controls.Add(this.pictur6);
            this.Controls.Add(this.pictur5);
            this.Controls.Add(this.pictur4);
            this.Controls.Add(this.pictur7);
            this.Controls.Add(this.pictur8);
            this.Controls.Add(this.pictur9);
            this.Controls.Add(this.pictur1);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictur2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictur3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictur6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictur5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictur4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictur7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictur8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictur9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictur1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictur1;
        private System.Windows.Forms.PictureBox pictur9;
        private System.Windows.Forms.PictureBox pictur8;
        private System.Windows.Forms.PictureBox pictur7;
        private System.Windows.Forms.PictureBox pictur4;
        private System.Windows.Forms.PictureBox pictur5;
        private System.Windows.Forms.PictureBox pictur6;
        private System.Windows.Forms.PictureBox pictur3;
        private System.Windows.Forms.PictureBox pictur2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbTurn;
        private System.Windows.Forms.Label LbWinner;
        private System.Windows.Forms.Button btnResetGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}

