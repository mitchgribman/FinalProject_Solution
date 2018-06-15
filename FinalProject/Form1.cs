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
    public partial class Form1 : Form
    {
        public int bankBalance { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
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
            bool x = true; 
            OpenCloseCD(x);
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

        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", 
            CharSet = CharSet.Ansi)]protected static extern int 
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
    }
}