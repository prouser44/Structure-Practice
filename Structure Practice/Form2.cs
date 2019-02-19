using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Structure_Practice
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the form (this refers to parent object)
        }
        
        public void btnSave_Click(object sender, EventArgs e) //when user double clicks save on form2
        {
            string name = txtName.Text; //saves text input to variable
            string address = txtAdress.Text; //saves text input to variable
            int accountNumber = Convert.ToInt32(txtAccountNumber.Text); //converts text input to int, then saves to variable
            double balance = Convert.ToDouble(txtBalance.Text); //converts text input to dbl, then saves to variable
            int overdraft = Convert.ToInt32(txtOverdraft.Text); //converts text input to int, then saves to variable

            //newAccountData must be both public and static for me to use it like this
            Form1.newAccountData(name, address, accountNumber, balance, overdraft);
            this.Close();

        }
    }
}
