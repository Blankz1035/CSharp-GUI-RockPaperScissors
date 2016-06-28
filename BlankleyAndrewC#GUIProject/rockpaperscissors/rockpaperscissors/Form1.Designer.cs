namespace rockpaperscissors
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
            this.quit = new System.Windows.Forms.Button();
            this.options = new System.Windows.Forms.GroupBox();
            this.scissors = new System.Windows.Forms.Button();
            this.paper = new System.Windows.Forms.Button();
            this.rock = new System.Windows.Forms.Button();
            this.sorryyouloose = new System.Windows.Forms.Label();
            this.statistics = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.losses = new System.Windows.Forms.Label();
            this.draws = new System.Windows.Forms.Label();
            this.win = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.options.SuspendLayout();
            this.statistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // quit
            // 
            this.quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit.Location = new System.Drawing.Point(47, 306);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(75, 23);
            this.quit.TabIndex = 0;
            this.quit.Text = "Quit!";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // options
            // 
            this.options.BackColor = System.Drawing.Color.Silver;
            this.options.Controls.Add(this.scissors);
            this.options.Controls.Add(this.paper);
            this.options.Controls.Add(this.rock);
            this.options.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.options.Location = new System.Drawing.Point(214, 188);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(140, 108);
            this.options.TabIndex = 1;
            this.options.TabStop = false;
            this.options.Text = "OPTIONS!";
            // 
            // scissors
            // 
            this.scissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scissors.ForeColor = System.Drawing.Color.Yellow;
            this.scissors.Location = new System.Drawing.Point(19, 79);
            this.scissors.Name = "scissors";
            this.scissors.Size = new System.Drawing.Size(87, 23);
            this.scissors.TabIndex = 2;
            this.scissors.Text = "Scissors";
            this.scissors.UseVisualStyleBackColor = true;
            this.scissors.Click += new System.EventHandler(this.scissors_Click);
            // 
            // paper
            // 
            this.paper.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paper.ForeColor = System.Drawing.Color.Blue;
            this.paper.Location = new System.Drawing.Point(19, 50);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(87, 23);
            this.paper.TabIndex = 1;
            this.paper.Text = "Paper";
            this.paper.UseVisualStyleBackColor = true;
            this.paper.Click += new System.EventHandler(this.paper_Click);
            // 
            // rock
            // 
            this.rock.BackColor = System.Drawing.Color.Transparent;
            this.rock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rock.Location = new System.Drawing.Point(19, 21);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(87, 23);
            this.rock.TabIndex = 0;
            this.rock.Text = "Rock";
            this.rock.UseVisualStyleBackColor = false;
            this.rock.Click += new System.EventHandler(this.rock_Click);
            // 
            // sorryyouloose
            // 
            this.sorryyouloose.AutoSize = true;
            this.sorryyouloose.BackColor = System.Drawing.Color.Ivory;
            this.sorryyouloose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sorryyouloose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sorryyouloose.ForeColor = System.Drawing.Color.Black;
            this.sorryyouloose.Location = new System.Drawing.Point(131, 153);
            this.sorryyouloose.Name = "sorryyouloose";
            this.sorryyouloose.Size = new System.Drawing.Size(120, 22);
            this.sorryyouloose.TabIndex = 2;
            this.sorryyouloose.Text = "Sorry You Lost!";
            // 
            // statistics
            // 
            this.statistics.BackColor = System.Drawing.Color.Silver;
            this.statistics.Controls.Add(this.label3);
            this.statistics.Controls.Add(this.label2);
            this.statistics.Controls.Add(this.label1);
            this.statistics.Controls.Add(this.losses);
            this.statistics.Controls.Add(this.draws);
            this.statistics.Controls.Add(this.win);
            this.statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistics.Location = new System.Drawing.Point(37, 188);
            this.statistics.Name = "statistics";
            this.statistics.Size = new System.Drawing.Size(140, 108);
            this.statistics.TabIndex = 3;
            this.statistics.TabStop = false;
            this.statistics.Text = "Statistics!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "0\r\n";
            // 
            // losses
            // 
            this.losses.AutoSize = true;
            this.losses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.losses.ForeColor = System.Drawing.Color.Lime;
            this.losses.Location = new System.Drawing.Point(7, 77);
            this.losses.Name = "losses";
            this.losses.Size = new System.Drawing.Size(68, 18);
            this.losses.TabIndex = 2;
            this.losses.Text = "Losses:";
            // 
            // draws
            // 
            this.draws.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draws.ForeColor = System.Drawing.Color.Red;
            this.draws.Location = new System.Drawing.Point(7, 56);
            this.draws.Name = "draws";
            this.draws.Size = new System.Drawing.Size(61, 18);
            this.draws.TabIndex = 1;
            this.draws.Text = "Draws:";
            // 
            // win
            // 
            this.win.AutoSize = true;
            this.win.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.win.ForeColor = System.Drawing.Color.Indigo;
            this.win.Location = new System.Drawing.Point(7, 29);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(51, 18);
            this.win.TabIndex = 0;
            this.win.Text = "Wins:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::rockpaperscissors.Properties.Resources.Rockchoice;
            this.pictureBox3.Location = new System.Drawing.Point(214, 45);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(140, 94);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(214, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(214, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(37, 45);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(140, 94);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(37, 45);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(140, 94);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Image = global::rockpaperscissors.Properties.Resources.Rockchoice;
            this.pictureBox6.Location = new System.Drawing.Point(37, 45);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(140, 94);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(233, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Start Over!\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(78, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 25);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "COMPUTER  VS  HUMAN";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 335);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "Developed by Andy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::rockpaperscissors.Properties.Resources.rock;
            this.ClientSize = new System.Drawing.Size(395, 359);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.statistics);
            this.Controls.Add(this.sorryyouloose);
            this.Controls.Add(this.options);
            this.Controls.Add(this.quit);
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors Game ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.options.ResumeLayout(false);
            this.statistics.ResumeLayout(false);
            this.statistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.GroupBox options;
        private System.Windows.Forms.Button scissors;
        private System.Windows.Forms.Button paper;
        private System.Windows.Forms.Button rock;
        private System.Windows.Forms.Label sorryyouloose;
        private System.Windows.Forms.GroupBox statistics;
        private System.Windows.Forms.Label losses;
        private System.Windows.Forms.Label draws;
        private System.Windows.Forms.Label win;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

