using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace tärning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0;
      
            int[] talArray = new int[50]; //skapa en array med 50 platser
        Random r ;      //Gör ett slumptal mellan 5 och 50  
        int slump ;

        Random p = new Random();      //Gör ett slumptal mellan 5 och 50  
        int tärning = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

            
           
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            r = new Random();      //Gör ett slumptal mellan 5 och 50
            slump = r.Next(5, 50);
            kasta_tärning();
            SetAllInvisible();
        }
        private void kasta_tärning()
        {         

            for (int i = 0; i < slump; i++)
            {
                tärning = p.Next(1, 6);
                talArray[i] = tärning;
            }
                      
           
            timer1.Enabled = true;

        }
        private void SetAllInvisible()
        {

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;            
              //  SetAllInvisible();
                if (talArray[i] == 1)
                    pictureBox1.Visible = true;
                if (talArray[i] == 2)
                    pictureBox2.Visible = true;
                if (talArray[i] == 3)
                    pictureBox3.Visible = true;
                if (talArray[i] == 4)
                    pictureBox4.Visible = true;
                if (talArray[i] == 5)
                    pictureBox5.Visible = true;
                if (talArray[i] == 6)
                    pictureBox6.Visible = true;
            if (i > slump)
                timer1.Enabled = false;
        }
        
    }
}
