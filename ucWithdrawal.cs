using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
* @author Tran Thien Trong - GCS290283
*
* @date - 10/October/2019 
*/

namespace ATM_SYSTEM
{
    public partial class ucWithdrawal : UserControl
    {
        // Variables Initialization
        public double withdrawAmount;

        // Class Instance Initialization
        private static ucWithdrawal _instance;
        public static ucWithdrawal Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucWithdrawal();
                }
                return _instance;
            }
        }
        public ucWithdrawal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When Withdrawal User Control is loaded, hide all valid marks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucWithdrawal_Load(object sender, EventArgs e)
        {
            pictureBoxChecked.Hide();
            pictureBoxInvalid.Hide();
        }

        /// <summary>
        /// Decrease balance amount
        /// Show valid/invalid checkmark
        /// Show Successful/Error sentence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            withdrawAmount = Convert.ToDouble(txtAmountOfWithdrawal.Text);
                
                // withdrawAmount must be positive number and less than balance 100 values
                if (withdrawAmount > 0 && withdrawAmount < AccountForm.amount-100) {
                    
                    // The balance amount of account increase in the same amount of DepositAmount value     
                    AccountForm.amount -= withdrawAmount;
                    AccountForm.withdraw = withdrawAmount;

                    // Show Valid Check Mark
                    pictureBoxChecked.Show();
                    pictureBoxInvalid.Hide();

                    // Success Sentence  
                    lblCheck.Text = "Success";

                    // Set text box empty
                    txtAmountOfWithdrawal.Text = "";
                }
                else
                {
                    // Show Invalid Check Mark
                    pictureBoxInvalid.Show();
                    pictureBoxChecked.Hide();
                
                    // Error Sentence 
                    lblCheck.Text = "Error";

                    // Set text box empty
                    txtAmountOfWithdrawal.Text = "";
                }
        }
    } // End ucWithdrawal
} // End name space
