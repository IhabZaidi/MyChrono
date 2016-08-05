using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace MyChrono
{
    public partial class Form1 : Form
    {
        int ihab = 0;
        double total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (button1.Text == "Start")
            {
                button1.Text = "Pause";
                mytimer.Start();
                textBox1.Enabled = false;
                textBox2.Text = textBox2.Text;
                textBox2.Enabled = false;

            }
            else {
                button1.Text = "Start";
                textBox1.Enabled = false;
                mytimer.Stop();
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(@"C:\Users\Ihabou\Desktop\IhabWork\TimeText.txt", textBox1.Text + " : " + label2.Text.ToString());

            }
            catch (Exception ex) {
                MessageBox.Show("Not Saved", "error");
            }
        }
        private void mytimer_Tick(object sender, EventArgs e)
        {
            try
            {
                ihab = ihab + 1;
                label2.Text = ihab.ToString();
                double price = Convert.ToDouble(textBox2.Text) / 60;
                total = price * Convert.ToDouble(label2.Text);
                textBox3.Text = total.ToString();
            }
            catch (Exception ex) { 
            
            }
        }
    }
}
