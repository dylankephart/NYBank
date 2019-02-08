using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYBank
{
    public partial class Form1 : Form
    {
        Account dylansAccount;

        const int MAX_CUST = 100;
        Account[] Bank = new Account[MAX_CUST];

        enum AccountState
        {
            Active,
            Closed,
            Frozen,
            New,
            UnderAudit,
        }

        struct Account
        {
            public AccountState State; //creates variables for AccountState 
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
        {    //sets dylansaccount 
            dylansAccount.Name = "Dylan Kephart"; //sets account name 
            dylansAccount.Balance = 1000000.04; //set account balance 
            dylansAccount.State = AccountState.Active; //has to equal to the enum AccountState 
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            TestShow(dylansAccount);
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            lblName.Text = Form2.SetValueForText1; //sets the labels to values set in form 2 
            lblAddress.Text = Form2.SetValueForText2;
            lblAccountNumber.Text = Form2.SetValueForText3; 
            lblBalance.Text = Form2.SetValueForText4;
            lblOverdraft.Text = Form2.SetValueForText5;
        }
    }
}
