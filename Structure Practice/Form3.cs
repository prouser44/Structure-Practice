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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e) //when form 3 loads
        { //sets each text box text equal to the desired bank account equivalent entered from form1
            txtName.Text = Form1.Bank[Form1.counter].Name; //if user chose to edit account "0", will display name from that bank account
            txtAdress.Text = Form1.Bank[Form1.counter].Address;
            txtAccountNumber.Text = Convert.ToString(Form1.Bank[Form1.counter].AccountNumber);
            txtBalance.Text = Convert.ToString(Form1.Bank[Form1.counter].Balance);
            txtOverdraft.Text = Convert.ToString(Form1.Bank[Form1.counter].Overdraft);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); //closes form3 is user clicks cancel
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Form1.Bank[Form1.counter].Name = txtName.Text; //overwrites name data of account user chose to edit with name entered in form3
            Form1.Bank[Form1.counter].Address = txtAdress.Text;
            Form1.Bank[Form1.counter].AccountNumber = Convert.ToInt32(txtAccountNumber.Text);
            Form1.Bank[Form1.counter].Balance = Convert.ToDouble(txtBalance.Text);
            Form1.Bank[Form1.counter].Overdraft = Convert.ToInt32(txtOverdraft.Text);
            this.Close();

        }
    }
}
