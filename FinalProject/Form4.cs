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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            //takes global double bankBalance and converts it to string
            //rounds to 2 decimal places (hundreth)
            //Displays it on label3
            double roundBankBalance = Math.Round(Form1.bankBalance, 2);
            string displayBankBalance = Convert.ToString(roundBankBalance);
            label3.Text = displayBankBalance;
        }

        //menu button to exit to menu when clicked
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 firstForm = new Form1();
            this.Hide();
            firstForm.Show();
        }
    }
}
