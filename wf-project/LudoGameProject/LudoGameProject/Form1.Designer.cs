namespace LudoGameProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.Diceresult = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bluePawn = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.redPawn = new System.Windows.Forms.PictureBox();
            this.greenPawn = new System.Windows.Forms.PictureBox();
            this.yellowPawn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenPawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowPawn)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1074, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Roll Dice";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Diceresult
            // 
            this.Diceresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diceresult.Location = new System.Drawing.Point(1074, 213);
            this.Diceresult.Multiline = true;
            this.Diceresult.Name = "Diceresult";
            this.Diceresult.Size = new System.Drawing.Size(75, 124);
            this.Diceresult.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(801, 417);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 63);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(545, 801);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 65);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(160, 546);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(63, 61);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(417, 161);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(62, 62);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // bluePawn
            // 
            this.bluePawn.BackColor = System.Drawing.Color.Transparent;
            this.bluePawn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bluePawn.BackgroundImage")));
            this.bluePawn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bluePawn.Location = new System.Drawing.Point(864, 542);
            this.bluePawn.Name = "bluePawn";
            this.bluePawn.Size = new System.Drawing.Size(65, 65);
            this.bluePawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bluePawn.TabIndex = 9;
            this.bluePawn.TabStop = false;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(1074, 477);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 11;
            this.start.Text = "Start Game";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1074, 361);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "You are Blue";
            // 
            // redPawn
            // 
            this.redPawn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("redPawn.BackgroundImage")));
            this.redPawn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redPawn.Location = new System.Drawing.Point(414, 864);
            this.redPawn.Name = "redPawn";
            this.redPawn.Size = new System.Drawing.Size(65, 65);
            this.redPawn.TabIndex = 13;
            this.redPawn.TabStop = false;
            // 
            // greenPawn
            // 
            this.greenPawn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("greenPawn.BackgroundImage")));
            this.greenPawn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.greenPawn.Location = new System.Drawing.Point(94, 417);
            this.greenPawn.Name = "greenPawn";
            this.greenPawn.Size = new System.Drawing.Size(65, 65);
            this.greenPawn.TabIndex = 14;
            this.greenPawn.TabStop = false;
            // 
            // yellowPawn
            // 
            this.yellowPawn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yellowPawn.BackgroundImage")));
            this.yellowPawn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yellowPawn.Location = new System.Drawing.Point(544, 95);
            this.yellowPawn.Name = "yellowPawn";
            this.yellowPawn.Size = new System.Drawing.Size(65, 65);
            this.yellowPawn.TabIndex = 15;
            this.yellowPawn.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1213, 749);
            this.Controls.Add(this.yellowPawn);
            this.Controls.Add(this.greenPawn);
            this.Controls.Add(this.redPawn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.start);
            this.Controls.Add(this.bluePawn);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Diceresult);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenPawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowPawn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Diceresult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox bluePawn;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox redPawn;
        private System.Windows.Forms.PictureBox greenPawn;
        private System.Windows.Forms.PictureBox yellowPawn;
    }
}

