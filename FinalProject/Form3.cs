﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FinalProject
{
    //similar to Form2
    public partial class Form3 : Form
    {
        //variables
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

        [DllImport("winmm.dll", EntryPoint = "mciSendStringA",
    CharSet = CharSet.Ansi)]
        protected static extern int
    mciSendString(string lpstrCommand,
    StringBuilder lpstrReturnString, int uReturnLength,
    IntPtr hwndCallback);

        public void OpenCloseCD(bool Open)
        {
            if (Open)
            {
                mciSendString("set cdaudio door open", null, 0, IntPtr.Zero);
            }
            else
            {
                mciSendString("set cdaudio door closed", null, 0, IntPtr.Zero);
            }
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
                //hides error messages
                label4.Visible = false;
                label23.Visible = true;
                textBox1.Text = "";
            }
            else
            {
                //checks for insufficient funds
                if (Form1.bankBalance < wMoney)
                {
                    label4.Visible = true;
                    textBox1.Text = "";
                    //prompts user to enter valid input to continue
                }
                else
                {
                    label4.Visible = false;
                    wNumOfHundreds = Calculation(ref amountLeft, 100);
                wNumOfTwenties = Calculation(ref amountLeft, 20);
                wNumOfTens = Calculation(ref amountLeft, 10);
                wNumOfFives = Calculation(ref amountLeft, 5);
                wNumOfOnes = Calculation(ref amountLeft, 1);
                wNumOfQuarters = Calculation(ref amountLeft, .25);
                wNumOfDimes = Calculation(ref amountLeft, .1);
                wNumOfNickels = Calculation(ref amountLeft, .05);
                wNumOfPennies = Calculation(ref amountLeft, .01);
                string numOfHundredsLabel = Convert.ToString(wNumOfHundreds);
                label14.Text = numOfHundredsLabel;
                string numOfTwentiesLabel = Convert.ToString(wNumOfTwenties);
                label15.Text = numOfTwentiesLabel;
                string numOfTensLabel = Convert.ToString(wNumOfTens);
                label16.Text = numOfTensLabel;
                string numOfFivesLabel = Convert.ToString(wNumOfFives);
                label17.Text = numOfFivesLabel;
                string numOfOnesLabel = Convert.ToString(wNumOfOnes);
                label18.Text = numOfOnesLabel;
                string numOfQuartersLabel = Convert.ToString(wNumOfQuarters);
                label19.Text = numOfQuartersLabel;
                string numOfDimesLabel = Convert.ToString(wNumOfDimes);
                label20.Text = numOfDimesLabel;
                string numOfNickelsLabel = Convert.ToString(wNumOfNickels);
                label21.Text = numOfNickelsLabel;
                string numOfPenniesLabel = Convert.ToString(wNumOfPennies);
                label22.Text = numOfPenniesLabel;
                textBox1.Text = "";
                //subtracts withdrawal from global bankBalance
                Form1.bankBalance = Form1.bankBalance - wMoney;
                bool x = true;
                OpenCloseCD(x);
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

        //menu button to exit to main menu when clicked
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 firstForm = new Form1();
            this.Hide();
            firstForm.Show();
        }
    }
}
