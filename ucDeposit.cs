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
    public partial class ucDeposit : UserControl
    {
        // Variables Initialization
        public static double DepositAmount=0.0F;

        // Class Instance Initialization
        private static ucDeposit _instance;
        public static ucDeposit Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucDeposit();
                }
                return _instance;
            }
        }
        public ucDeposit()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When Deposit User Control is loaded, hide all valid marks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucDeposit_Load(object sender, EventArgs e)
        {
            pictureBoxChecked.Hide();
            pictureBoxInvalid.Hide();
        }

        /// <summary>
        /// Increase balance amount
        /// Show valid/invalid checkmark
        /// Show Successful/Error sentence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            DepositAmount = Convert.ToDouble(txtAmountOfDeposit.Text);

            if (DepositAmount > 0)
            {
                // The balance amount of account increase in the same amount of DepositAmount value 
                AccountForm.amount += DepositAmount;
                AccountForm.deposit = DepositAmount;

                // Show Valid Check Mark
                pictureBoxChecked.Show();
                pictureBoxInvalid.Hide();

                // Success Sentence                
                lblCheck.Text = "Success";

                // Set text box empty
                txtAmountOfDeposit.Text = "";   
            }
            else
            {
                // Show Valid Check Mark
                pictureBoxInvalid.Show();
                pictureBoxChecked.Hide();

                // Error Sentence  
                lblCheck.Text = "Error";
                
                // Set text box empty
                txtAmountOfDeposit.Text = "";
            }
        }
    } // End Class
} // End namespace
