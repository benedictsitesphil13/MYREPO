using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Enumeration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = true;
            panel2.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Age = Convert.ToInt32(AgeTxt.Text);
            int[] A = { 15, 20, 30, 50 };

            if (Age >= A[0] && Age < A[1])
            {
                MessageBox.Show("Hi " + NameTxt.Text + " please join our youth club!");
            }

            else if (Age >= A[1] && Age < A[2])
            {
                MessageBox.Show("Hi " + NameTxt.Text + " please join our young people's club!");
            }

            else if (Age >= A[2] && Age < A[3])
            {
                MessageBox.Show("Hi " + NameTxt.Text + " please join our swinger's club!");
            }

            else if (Age >= A[3])
            {
                MessageBox.Show("Hi " + NameTxt.Text + " please join our senior citizens club!");
            }

            else
            {
                MessageBox.Show("Hi " + NameTxt.Text + " Dont fill up this form!");
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               "STAR SIGN: " +
               "\n\n" +
               this.SignTxt.Text +
               "\n\n" +
               "CHARACTERISTICS: " +
               "\n\n" +
               this.CharTxt.Text+
               "\n\n"+
               "Star sign summary");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
