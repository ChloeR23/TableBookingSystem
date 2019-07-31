using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool isPanel2Open = false;
        bool isPanel3Open = false;
        bool isPanel4Open = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isPanel2Open)
            {
                panel2.Height -= 20;
                if (panel2.Height == 0)
                {
                    timer1.Stop();
                    isPanel2Open = false;
                }
            }
            else if (!isPanel2Open)
            {
                panel2.Height += 20;
                if (panel2.Height == 240)
                {
                    timer1.Stop();
                    isPanel2Open = true;
                }
            }
            }
        

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isPanel3Open)
            {
                panel3.Height -= 20;
                if (panel3.Height == 0)
                {
                    timer2.Stop();
                    isPanel3Open = false;
                }
            }
            else if (!isPanel3Open)
            {
                panel3.Height += 20;
                if (panel3.Height == 40)
                {
                    timer2.Stop();
                    isPanel3Open = true;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isPanel4Open)
            {
                panel4.Height -= 20;
                if (panel4.Height == 0)
                {
                    timer3.Stop();
                    isPanel4Open = false;
                }
            }
            else if (!isPanel4Open)
            {
                panel4.Height += 20;
                if (panel4.Height == 240)
                {
                    timer3.Stop();
                    isPanel4Open = true;
                }
            }
        }

        private void label10_Click_1(object sender, EventArgs e)
        {
            //display 18:00 next to Time under booking
            label16.Text = "18:00";
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            //display 1 next to number of people under booking
            label18.Text = "1";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //display 2 next to number of people under booking
            label18.Text = "2";
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            //display 3 next to number of people under booking
            label18.Text = "3";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //display 4 next to number of people under booking
            label18.Text = "4";
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            //display 5 next to number of people under booking
            label18.Text = "5";
        }

        private void label9_Click(object sender, EventArgs e)
        {
            //display 6 next to number of people under booking
            label18.Text = "6";
        }

        private void label15_Click(object sender, EventArgs e)
        {
            //display 16:00 next to Time under booking
            label16.Text = "16:00";
        }

        private void label14_Click(object sender, EventArgs e)
        {
            //display 17:00 next to Time under booking
            label16.Text = "17:00";
        }

        private void label11_Click(object sender, EventArgs e)
        {
            //display 19:00 next to Time under booking
            label16.Text = "19:00";
        }

        private void label12_Click_1(object sender, EventArgs e)
        {
            //display 20:00 next to Time under booking
            label16.Text = "20:00";
        }

        private void label13_Click(object sender, EventArgs e)
        {
            //display 21:00 next to Time under booking
            label16.Text = "21:00";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label17.Text = dateTimePicker1.Value.ToShortDateString();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (textBox1.Text.Length >= 0)
            {
                if (!rEmail.IsMatch(textBox1.Text))
                {
                    MessageBox.Show("Invalid E-Mail Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.SelectAll();
                }
            }

            //if label 16, 17 or 18 is blank
            else if (label18.Text.Length == 0)
            {
                // display message
                label18.Text = "Select Amount";
            }
            else if (label17.Text.Length == 0)
            {
                // display message
                label17.Text = "Pick A Date";
            }

            else if (label16.Text.Length == 0)
            {
                // display message
                label16.Text = "Pick A Time";
            }

            else 
            {
                //display booking request details and message that the restaruanrt will e-mail with confirmation of booking
                label25.Text = "Your Booking Request Has Been Sent To The Restaurant.";
                   label27.Text = "You will be contacted with confirmation via e-mail.";
            }
        }

      
    }
}
