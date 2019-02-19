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
        public static int counter = 0;
        const int MAX_CUST = 100;
        public static Account[] Bank = new Account[MAX_CUST];

        public enum AccountState
        {
            Active,
            Closed,
            Frozen,
            New,
            UnderAudit
        }

        public struct Account
        {
            public AccountState State;
            public string Name;
            public string Address;
            public int AccountNumber;
            public double Balance;
            public int Overdraft;
        }

        public static void newAccountData (string nme, string addrs, int accNum, double blnce, int ovrdrft)
        { //creates a public method that sets the local variables equal to the variables in the parameters of newAccountData method
            
            int counter = 0; //start counting at 0
            for (int i = 0; i < MAX_CUST; i++) //loop through all indexes of array to find next available index
            {
                if (Bank[i].Name == null) //checking for first unset bank account name in bank array
                {
                    counter = i; //marks first index of available bank name with counter it's on (could be 4, 5, 454, ect)
                    break; //ends for loop automatically
                }
            }
            //sets the first available bank account equal to matching parameters of method
            Bank[counter].State = AccountState.New;
            Bank[counter].Name = nme;
            Bank[counter].Address = addrs;
            Bank[counter].AccountNumber = accNum;
            Bank[counter].Balance = blnce;
            Bank[counter].Overdraft = ovrdrft;
            //what to do with accounts in list box
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
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear(); //clrars list box
            int counter = 0; //start counting at zero
            for (int i = 0; i < Bank.Length; i++)
            {
                if (Bank[i].Name == null) //checking for first unset bank account name in bank array
                {
                    counter = i; //marks first index of available bank name with counter it's on (could be 4, 5, 454, ect)
                    break; //ends for loop automatically
                }
                listBox1.Items.Add(i + " " + Bank[i].State + " " + Bank[i].Name + " " + Bank[i].Address + " " + Bank[i].AccountNumber + " " + Bank[i].Balance + " " + Bank[i].Overdraft);
            }
            
        }

        private void btnAddNewAccount_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(); //creates a new instance of form2 (named f)
            f.ShowDialog(); //makes the instance of form2 (named f btw) a dialog box....meaning the user can't leave the box until the X is clicked
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        public void btnEditAcc_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            counter = Convert.ToInt32(txtEditAcc.Text); //converts edit text into int, saves that int to variable counter, use counter to find bank in bank array for form3
        }
    }
}
