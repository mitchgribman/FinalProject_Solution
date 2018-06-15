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
            int amountLeft = (int)(money * 100);
            numOfHundreds = Calculation(ref amountLeft, 100);
            numOfTwenties = Calculation(ref amountLeft, 20);
            numOfTens = Calculation(ref amountLeft, 10);
            numOfFives = Calculation(ref amountLeft, 5);
            numOfOnes = Calculation(ref amountLeft, 1);
            numOfQuarters = Calculation(ref amountLeft, .25);
            numOfDimes = Calculation(ref amountLeft, .1);
            numOfNickels = Calculation(ref amountLeft, .05);
            numOfPennies = Calculation(ref amountLeft, .01);
            string numOfHundredsLabel = Convert.ToString(numOfHundreds);
            label14.Text = numOfHundredsLabel;
            string numOfTwentiesLabel = Convert.ToString(numOfTwenties);
            label15.Text = numOfTwentiesLabel;
            string numOfTensLabel = Convert.ToString(numOfTens);
            label16.Text = numOfTensLabel;
            string numOfFivesLabel = Convert.ToString(numOfFives);
            label17.Text = numOfFivesLabel;
            string numOfOnesLabel = Convert.ToString(numOfOnes);
            label18.Text = numOfOnesLabel;
            string numOfQuartersLabel = Convert.ToString(numOfQuarters);
            label19.Text = numOfQuartersLabel;
            string numOfDimesLabel = Convert.ToString(numOfDimes);
            label20.Text = numOfDimesLabel;
            string numOfNickelsLabel = Convert.ToString(numOfNickels);
            label21.Text = numOfNickelsLabel;
            string numOfPenniesLabel = Convert.ToString(numOfPennies);
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
