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
    public partial class Form1 : Form
    {
        //public static string variable1; //sets a public variable that can be used between forms

        Account ethansAccount;
        public static string name2; //these are variables declared to be used in the public method (to use between forms)
        public static string address2;
        public static int accountNumber2;
        public static double balance2;
        public static int overdraft2;

        public static void newAccountData (string nme, string addrs, int accNum, double blnce, int ovrdrft)
        { //creates a public method that sets the local variables equal to the variables in the parameters of newAccountData method
            name2 = nme;
            address2 = addrs;
            accountNumber2 = accNum;
            balance2 = blnce;
            overdraft2 = ovrdrft;
        }

        enum AccountState
        {
            Active,
            Closed,
            Frozen,
            New,
            UnderAudit
        }

        struct Account
        {
            public AccountState State;
            public string Name;
            public string Address;
            public int AccountNumber;
            public double Balance;
            public int Overdraft;
        }

        private void TestShow(Account a)
        {
            MessageBox.Show(a.Name);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ethansAccount.Name = "Ethan Piper";
            ethansAccount.Balance = 100.00;
            ethansAccount.State = AccountState.Active;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            TestShow(ethansAccount); //dialog box appears with the name from ethansAccount
        }

        private void btnAddNewAccount_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(); //creates a new instance of form2 (named f)
            f.ShowDialog(); //makes the instance of form2 (named f btw) a dialog box....meaning the user can't leave the box until the X is clicked
        }
    }
}
