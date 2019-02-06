using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tärning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kasta_tärning();
        }
        private void kasta_tärning()
        {
            int[] talArray = new int[50]; //skapa en array med 50 platser
            Random r = new Random();      //Gör ett slumptal mellan 5 och 50  
            int slump = r.Next(5, 50);

            Random p = new Random();      //Gör ett slumptal mellan 5 och 50  
            int tärning = 0;

            for (int i = 0; i < slump; i++)
            {
                tärning = p.Next(1, 6);
                talArray[i] = tärning;
            }

           
            for (int i = 0; i < slump; i++)
            {
                if (talArray[i] == 1)
                    pictureBox1.Enabled = true;
                if (talArray[i] == 1)
                    pictureBox2.Enabled = true;
                if (talArray[i] == 1)
                    pictureBox3.Enabled = true;
                if (talArray[i] == 1)
                    pictureBox4.Enabled = true;
                if (talArray[i] == 1)
                    pictureBox5.Enabled = true;
                if (talArray[i] == 1)
                    pictureBox6.Enabled = true;
            }
        }
    }
}
