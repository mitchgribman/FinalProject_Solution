using System;
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
    //My form2 and form3 are very similar
    public partial class Form2 : Form
    {
        //declares variables that will be used below
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
            label23.Visible = false;
        }

        //I found this on this internet to eject CD drive 
        //symbolizing the deposit/withdrawal hole in an ATM
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
        //Menu button returns you to menu if needed
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

        private void button2_Click(object sender, EventArgs e)
        {
            label23.Visible = false;
            //converts dMoney to string for display
            dMoney = Convert.ToDouble(textBox1.Text);
            string dMoneyInput = Convert.ToString(dMoney);
            int amountLeft = (int)(dMoney * 100);
            //checks whether dMoney is above 0
            //if not it will display error message and prompt user to re-input
            //if yes it will continue
            if (dMoney < 0)
            {
                label23.Visible = true;
                textBox1.Text = "";
            }
            else
            {
                //I referenced Ch4_Program6 to get a similar way
                //of determining change that needs to be given

                //sends it into calculation method to get numbers
                dNumOfHundreds = Calculation(ref amountLeft, 100);
                dNumOfTwenties = Calculation(ref amountLeft, 20);
                dNumOfTens = Calculation(ref amountLeft, 10);
                dNumOfFives = Calculation(ref amountLeft, 5);
                dNumOfOnes = Calculation(ref amountLeft, 1);
                dNumOfQuarters = Calculation(ref amountLeft, .25);
                dNumOfDimes = Calculation(ref amountLeft, .1);
                dNumOfNickels = Calculation(ref amountLeft, .05);
                dNumOfPennies = Calculation(ref amountLeft, .01);

                //converts to string to display
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
                textBox1.Text = "";
                //adds the deposit requested to the global bankBalance
                Form1.bankBalance = Form1.bankBalance + dMoney;
                //opens the CD drive for the "deposit"
                bool x = true;
                OpenCloseCD(x);
            }
        }

        //calculation method
        public static int Calculation(ref int amountLeft, double y)
        {
            int typeOfChange = (int)(y * 100);
            int changeReturn = amountLeft / typeOfChange;
            amountLeft = amountLeft % typeOfChange;
            return changeReturn;
        }
    }
}
