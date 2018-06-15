using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form3 : Form
    {
        public double wMoney;
        public int wNumOfHundreds;
        public int wNumOfTwenties;
        public int wNumOfTens;
        public int wNumOfFives;
        public int wNumOfOnes;
        public int wNumOfQuarters;
        public int wNumOfDimes;
        public int wNumOfNickels;
        public int wNumOfPennies;
        public Form3()
        {
            InitializeComponent();
            label23.Visible = false;
            label4.Visible = false;
        }

        void firstForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label23.Visible = false;
            wMoney = Convert.ToDouble(textBox1.Text);
            string dMoneyInput = Convert.ToString(wMoney);
            int amountLeft = (int)(wMoney * 100);
            if (wMoney < 0)
            {
                label23.Visible = true;
                textBox1.Text = "";
            }
            else
            {
                if (Form1.bankBalance < wMoney)
                {
                    label4.Visible = true;
                    textBox1.Text = "";
                }
                else
                {

                }
     
            }
        }

        public static int Calculation(ref int amountLeft, double y)
        {
            int typeOfChange = (int)(y * 100);
            int changeReturn = amountLeft / typeOfChange;
            amountLeft = amountLeft % typeOfChange;
            return changeReturn;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 firstForm = new Form1();
            this.Hide();
            firstForm.Show();
        }
    }
}
