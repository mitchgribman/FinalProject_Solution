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
    public partial class Form2 : Form
    {
        public double money;
        public int numOfHundreds;
        public int numOfTwenties;
        public int numOfTens;
        public int numOfFives;
        public int numOfOnes;
        public int numOfQuarters;
        public int numOfDimes;
        public int numOfNickels;
        public int numOfPennies;
        public Form2()
        {
            InitializeComponent();
        }

        public static int Calculation(ref int amountLeft, double y)
        {
            int typeOfChange = (int)(y * 100);
            int changeReturn = amountLeft / typeOfChange;
            amountLeft = amountLeft % typeOfChange;
            return changeReturn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 firstForm = new Form1();
            this.Hide();
            firstForm.Show();
        }

        void firstForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            money = Convert.ToDouble(textBox1.Text);
            string moneyInput = Convert.ToString(money);
            label3.Text = moneyInput;
        }
        private int Calculation(ref int amountLeft, double y)
        {
            int typeOfChange = (int)(y * 100);
            int changeReturn = amountLeft / typeOfChange;
            amountLeft = amountLeft % typeOfChange;
            return changeReturn;
        }
    }
