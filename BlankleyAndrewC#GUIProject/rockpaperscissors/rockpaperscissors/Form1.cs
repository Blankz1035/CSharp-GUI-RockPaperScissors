using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace rockpaperscissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int wins = 0;
        int looses = 0;
        int draw = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            
        }
       
        
        private void rock_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;

            Random rnd = new Random();
            
            int comp = rnd.Next(1, 4);
            
            
            if (comp == 1)
            {
                ++draw;
                pictureBox6.Visible = true;
                sorryyouloose.Text = "Its a Draw!";
                label2.Text = draw .ToString();
                
            }
            else if (comp == 2)
            {
                ++wins;
                pictureBox5.Visible = true;
                sorryyouloose.Text = "Your a Winner!";
                label1.Text = wins.ToString();
            }
            else if (comp == 3)
            {
                ++looses;
                pictureBox4.Visible = true;
                sorryyouloose.Text = "You LOOSE!";
                label3.Text = looses.ToString();

            }

        }

        private void paper_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;

            Random rnd = new Random();

            int comp = rnd.Next(1, 4);


            if (comp == 1)
            {
                ++draw;
                pictureBox4.Visible = true;
                sorryyouloose.Text = "Its a Draw!";
                label2.Text = draw.ToString();

            }
            else if (comp == 2)
            {
                ++wins;
                pictureBox6.Visible = true;
                sorryyouloose.Text = "Your a Winner!";
                label1.Text = wins.ToString();
            }
            else if (comp == 3)
            {
                ++looses;
                pictureBox5.Visible = true;
                sorryyouloose.Text = "You LOOSE!";
                label3.Text = looses.ToString();

            }

        }

        private void scissors_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;

            Random rnd = new Random();

            int comp = rnd.Next(1, 4);


            if (comp == 1)
            {
                ++draw;
                pictureBox5.Visible = true;
                sorryyouloose.Text = "Its a Draw!";
                label2.Text = draw.ToString();

            }
            else if (comp == 2)
            {
                ++wins;
                pictureBox4.Visible = true;
                sorryyouloose.Text = "Your a Winner!";
                label1.Text = wins.ToString();
            }
            else if (comp == 3)
            {
                ++looses;
                pictureBox6.Visible = true;
                sorryyouloose.Text = "You LOOSE!";
                label3.Text = looses.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = String.Empty;
            label2.Text = String.Empty;
            label3.Text = String.Empty;
            wins = 0;
            draw = 0;
            looses = 0;
        }

        private void quit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Results!\nWins: " + wins + "\nDraws: " + draw + "\nLosses: " + looses + "\n\nCome Back Soon!");

            this.Close();
            
        }

       
    }
}
