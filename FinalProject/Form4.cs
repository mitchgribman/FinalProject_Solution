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
            string displayBankBalance = Convert.ToString(Form1.bankBalance);
            label3.Text = displayBankBalance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 firstForm = new Form1();
            this.Hide();
            firstForm.Show();
        }
    }
}
