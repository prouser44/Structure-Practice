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

        private void btnSave_Click(object sender, EventArgs e) //when user double clicks save on form2
        {
            //grabs the textbox value and sets it to variable in form2
            string name = txtName.Text; 
            string address = txtAdress.Text; 
            int accNum = Convert.ToInt32(txtAccountNumber.Text);
            double balance = Convert.ToDouble(txtBalance.Text);
            int overdraft = Convert.ToInt32(txtOverdraft.Text);

            //runs form1 method and sets the above variables as the argument
            Form1.newAccountData(name, address, accNum, balance, overdraft);
            
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show(frm2Name);
        }
    }
}
