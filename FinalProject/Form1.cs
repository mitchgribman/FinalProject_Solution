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
    public partial class Form1 : Form
    {
        //I created my very own public variable of bank balance used
        //across all my forms
        public static double bankBalance { get; set; }
        
        public Form1()
        {
        InitializeComponent();
        }
        //I simple menu where the buttons open and hide the following forms
        private void button1_Click(object sender, EventArgs e)
        {
            //I found this on the Internet to open, close and hide my forms
            Form2 secondForm = new Form2();
            secondForm.FormClosed += new FormClosedEventHandler
                (secondForm_FormClosed);
            this.Hide();
            secondForm.Show();
        }

        void secondForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 thirdForm = new Form3();
            thirdForm.FormClosed += new FormClosedEventHandler
                (thirdForm_FormClosed);
            this.Hide();
            thirdForm.Show();
        }

        void thirdForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        public static string AskUserForString(string x)
        {
            Console.Write("Please input {0}: ", x);
            string input = Console.ReadLine();
            return input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 fourthForm = new Form4();
            fourthForm.FormClosed += new FormClosedEventHandler
                (fourthForm_FormClosed);
            this.Hide();
            fourthForm.Show();
        }

        void fourthForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            bankBalance = 0;
        }
    }
}
