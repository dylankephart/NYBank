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
    public partial class Form2 : Form
    {

        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = ""; //creates variables to hold values for text boxes 
        public static string SetValueForText4 = "";
        public static string SetValueForText5 = ""; //has to set as a string regardless for text boxes 

        public Form2()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SetValueForText1 = txtName.Text;
            SetValueForText2 = txtAddress.Text; //sets the values to text boxes, when button is clicked 
            SetValueForText3 = txtAccountNumber.Text;
            SetValueForText4 = txtBalance.Text;
            SetValueForText5 = txtOverdraft.Text;

            //string name = txtName.Text;
            //string address = txtAddress.Text;
            //int accountNumber = Convert.ToInt32(txtAccountNumber.Text);
            //double balance = Convert.ToDouble(txtBalance.Text);
            //int overdraft = Convert.ToInt32(txtOverdraft.Text);
            //new account must be both public and static for me to use it like this //
            

            this.Close(); 
        }
    }
}
