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
        public double dMoney;
        public int dNumOfHundreds;
        public int dNumOfTwenties;
        public int dNumOfTens;
        public int dNumOfFives;
        public int dNumOfOnes;
        public int dNumOfQuarters;
        public int dNumOfDimes;
        public int dNumOfNickels;
        public int dNumOfPennies;
        public Form2()
        {
            InitializeComponent();
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
            dMoney = Convert.ToDouble(textBox1.Text);
            string dMoneyInput = Convert.ToString(dMoney);
            int amountLeft = (int)(dMoney * 100);
            dNumOfHundreds = Calculation(ref amountLeft, 100);
            dNumOfTwenties = Calculation(ref amountLeft, 20);
            dNumOfTens = Calculation(ref amountLeft, 10);
            dNumOfFives = Calculation(ref amountLeft, 5);
            dNumOfOnes = Calculation(ref amountLeft, 1);
            dNumOfQuarters = Calculation(ref amountLeft, .25);
            dNumOfDimes = Calculation(ref amountLeft, .1);
            dNumOfNickels = Calculation(ref amountLeft, .05);
            dNumOfPennies = Calculation(ref amountLeft, .01);
            string numOfHundredsLabel = Convert.ToString(dNumOfHundreds);
            label14.Text = numOfHundredsLabel;
            string numOfTwentiesLabel = Convert.ToString(dNumOfTwenties);
            label15.Text = numOfTwentiesLabel;
            string numOfTensLabel = Convert.ToString(dNumOfTens);
            label16.Text = numOfTensLabel;
            string numOfFivesLabel = Convert.ToString(dNumOfFives);
            label17.Text = numOfFivesLabel;
            string numOfOnesLabel = Convert.ToString(dNumOfOnes);
            label18.Text = numOfOnesLabel;
            string numOfQuartersLabel = Convert.ToString(dNumOfQuarters);
            label19.Text = numOfQuartersLabel;
            string numOfDimesLabel = Convert.ToString(dNumOfDimes);
            label20.Text = numOfDimesLabel;
            string numOfNickelsLabel = Convert.ToString(dNumOfNickels);
            label21.Text = numOfNickelsLabel;
            string numOfPenniesLabel = Convert.ToString(dNumOfPennies);
            label22.Text = numOfPenniesLabel;
        }
        
        public static int Calculation(ref int amountLeft, double y)
        {
            int typeOfChange = (int)(y * 100);
            int changeReturn = amountLeft / typeOfChange;
            amountLeft = amountLeft % typeOfChange;
            return changeReturn;
        }
    }
}
