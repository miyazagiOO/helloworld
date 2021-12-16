using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // input
            // นี่คือคอมเม้น
            //textBoxC.Text = "Hello";
           //get input foem textbox
            string Input = textBoxC.Text;

            //convert to f
            //f = c x 9/5 + 32;
            double c = Convert.ToDouble(Input);
            double f = c * 9 / 5 + 32;
       
            //show input to textbox
            textBoxF.Text = f.ToString();
        

        }

        private void buttonConvert2_Click(object sender, EventArgs e)
        {

            //get input form textbox
            string input = textBoxF.Text;
            //c = f 5/9 x (F-32)
            double f = Convert.ToDouble(input);
            double c = (f - 32) * 5 / 9;

            textBoxC.Text = c.ToString();
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            textBoxC.Text = " ";
            textBoxF.Text = " ";
        }
    }
}
