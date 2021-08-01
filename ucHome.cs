using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/**
* @author Tran Thien Trong - GCS290283
*
* @date - 10/October/2019 
*/

namespace ATM_SYSTEM
{
    public partial class ucHome : UserControl
    {
        // Class Instance Initialization
        private static ucHome _instance;

        // Get ucHome instance
        public static ucHome Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucHome();
                }
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }

        // Initialize all component in ucHome
        public ucHome()
        {
            InitializeComponent();
        }

        private void ucHome_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Fill the panel with Deposit User Control
        /// The Back Button is visible, lead you back to ucHome is clicked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (!AccountForm.Instance.panelContainer.Controls.ContainsKey("ucDeposit"))
            {
            
                ucDeposit un = new ucDeposit();
                un.Dock = DockStyle.Fill; // Fill the panel with ucDeposit
                AccountForm.Instance.panelContainer.Controls.Add(un);
            
            }

            AccountForm.Instance.panelContainer.Controls["ucDeposit"].BringToFront();
            AccountForm.Instance.BackButton.Visible = true;
        }


        /// <summary>
        /// Fill the panel with Loan User Control
        /// The Back Button is visible, lead you back to ucHome is clicked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoan_Click(object sender, EventArgs e)
        {
            if (!AccountForm.Instance.panelContainer.Controls.ContainsKey("ucLoan"))
            {
                ucLoan un = new ucLoan();
                un.Dock = DockStyle.Fill; // Fill the panel with ucDeposit
                AccountForm.Instance.panelContainer.Controls.Add(un);
            }

            AccountForm.Instance.panelContainer.Controls["ucLoan"].BringToFront();
            AccountForm.Instance.BackButton.Visible = true;
        }

        /// <summary>
        /// Fill the panel with Withdrawal User Control
        /// The Back Button is visible, lead you back to ucHome is clicked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWithDrawal_Click(object sender, EventArgs e)
        {
            if (!AccountForm.Instance.panelContainer.Controls.ContainsKey("ucWithdraw"))
            {
                ucWithdrawal un = new ucWithdrawal();
                un.Dock = DockStyle.Fill;
                AccountForm.Instance.panelContainer.Controls.Add(un);
            }
            AccountForm.Instance.panelContainer.Controls["ucWithdrawal"].BringToFront();
            AccountForm.Instance.BackButton.Visible = true;
        }

        /// <summary>
        /// After Print Receipt Button is clicked, 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            // Initialize string variables for printing purpose
            string deposit = "Your Deposit Amount: " + AccountForm.deposit.ToString();
            string withdraw = "Your Withdraw Amount: " + AccountForm.withdraw.ToString();
            string loan = "Your Loan Amount: " + AccountForm.loan.ToString();
            string balance = "Your Balance Amount: " + AccountForm.amount.ToString();

            // Initialize string variables for current Date and Time
            string date ="Date: " +DateTime.Now.ToString("MM-dd-yyyy");
            string time ="Time: " +DateTime.Now.ToString("hh:mm:ss");


            // Initialize Array List
            var arrayList = new System.Collections.ArrayList();
            

            // Initialize direction where the receipt is saved
            //string dir = @"ATM_SYSTEM\Receipt History\Receipt.txt";
            string dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Receipt History\Receipt.txt"; ;


            // Check if deposit, withdrawal and loan variables form Account Form has changed
            if (AccountForm.deposit > 0)
            {
                arrayList.Add(deposit); // Add deposit value to the last index of arrayList
            }
            if (AccountForm.withdraw > 0)
            {
                arrayList.Add(withdraw); // Add withdraw value to to the last index of arrayList
            }
            if (AccountForm.loan > 0)
            {
                arrayList.Add(loan); // Add loan value to the last index of arrayList
            }
            if (AccountForm.amount > 0)
            {
                arrayList.Add("----------------------------------------------- ");
                arrayList.Add(balance); // Add withdraw value to the last index of arrayList
            }

            
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(dir))
            {
                file.WriteLine("\nTransaction " + date +" "+" at "+ time);
                file.WriteLine("\nUser name: "+AccountForm.accountName);
               
                for (int i = 0; i < arrayList.Count; i++)
                {
                    // Write Each Value Of Array List From index 0-last index into the new line
                    file.WriteLine(arrayList[i]);
                }
            }
             lblReceipt.Text ="Save receipt at: "+ dir;
        }
    } // End ucHome
} // End namespace
