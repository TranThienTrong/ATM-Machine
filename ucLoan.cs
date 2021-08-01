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
    public partial class ucLoan : UserControl
    {
        // Variables declaration
        protected double interestRate, monthlyInterestRate, loanAmount, monthlyPayment, totalPayment;
        protected int numberOfYears;
        protected String iMonthlyPayment, iTotalPayment,iInterestRate;

        // Class Instance Initialization
        private static ucLoan _instance;
        public static ucLoan Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucLoan();
                }
                return _instance;
            }
        }

        private void txtAmountOfLoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbReceipt_TextChanged(object sender, EventArgs e)
        {

        }

        public ucLoan()
        {
            InitializeComponent();
        }

        private void ucLoan_Load(object sender, EventArgs e)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReceipt_Click(object sender, EventArgs e)
        {
            rtbReceipt.AppendText("Amount of Loan" + "\t" + txtAmountOfLoan.Text + "\n");
            rtbReceipt.AppendText("Number of Years" + "\t" + txtNumberOfYears.Text + "\n");
            rtbReceipt.AppendText("Interest Rate" + "\t" + iInterestRate + "\n");
            rtbReceipt.AppendText("Monthly Payment" + "\t" + lblMonthlyPayment.Text + "\n");
            rtbReceipt.AppendText( "----------------------------------------------" + "\n");
            rtbReceipt.AppendText("Total Payment" + "\t" + lblTotalPayment.Text + "\n");
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountOfLoan.Clear();
            txtNumberOfYears.Clear();
            txtInterestRate.Clear();
            lblMonthlyPayment.Text = "";
            lblTotalPayment.Text = "";
            rtbReceipt.Clear();
            btnLoanSystem.Enabled = true;
        }

      

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoanSystem_Click(object sender, EventArgs e)
        {
            // Convert string value in text box to double value
            loanAmount = Convert.ToDouble(txtAmountOfLoan.Text);
            numberOfYears = Convert.ToInt32(txtNumberOfYears.Text);
            interestRate = Convert.ToDouble(txtInterestRate.Text);
            if (loanAmount >= 10000)
            {
                numberOfYears = 0;
                interestRate = 0;
                loanAmount = 0;
                rtbReceipt.AppendText("ERROR");
                btnReceipt.Enabled = false;
            }
            // Caculate monthly Interest Rate
            monthlyInterestRate = interestRate / 1200;

            // Caculate Monthly Payment
            monthlyPayment = loanAmount * 
                             monthlyInterestRate / 
                             (
                             1 - (1 / 
                             Math.Pow(1 + monthlyInterestRate, numberOfYears * 12)
                             ));

            // The balance amount of account increase in the same amount of DepositAmount value 
            AccountForm.amount += loanAmount;
            AccountForm.loan = loanAmount;

            // Monththly Payment Label Show monthlyPayment value
            iMonthlyPayment = Convert.ToString(monthlyPayment);
            iMonthlyPayment = String.Format("{0:C}", monthlyPayment);
            lblMonthlyPayment.Text = (iMonthlyPayment);

            // Total Payment Label Show totalPayment value
            totalPayment = monthlyPayment * numberOfYears * 12;
            iTotalPayment = String.Format("{0:C}", totalPayment);
            lblTotalPayment.Text = (iTotalPayment);

            iInterestRate = txtInterestRate.Text+" %";
            txtInterestRate.Text = iInterestRate;      
            
            // In Case Of Accident, Do Not Let User Click This Button Again
            btnLoanSystem.Enabled = false;
        }

    } // End ucLoan 
} // End namespace
