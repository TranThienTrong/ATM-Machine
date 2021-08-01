using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class AccountForm : Form
    {
        // Account Variables Declaration
        public static double amount;
        public static string accountName;

        // Transaction Variables Initialization
        public static double loan = 0.0F;
        public static double deposit = 0.0F;
        public static double withdraw = 0.0F;

        // Slide Variables Declaration
        protected int panelWidth;
        protected bool isHidden;

        // Initialize instance of Account Form
        private static AccountForm _instance;
     
        public static AccountForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AccountForm();
                }
                return _instance;
            }
        }
        
        public Panel panelContainer
        {
            get { return panel; }
            set { panel = value; }
        }
        public Button BackButton
        {
            get { return btnBack; }
            set { btnBack = value; }
        }
        public AccountForm()
        {
            InitializeComponent();
            
            panelWidth = panelSlide.Width;
            isHidden = false; // Show Panel Slide from the begining
        }
       
        /// <summary>
        /// When the AccountForm is loaded, on the PanelSlide, show account aname and avatar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccountForm_Load(object sender, EventArgs e)
        {
            amount = MainForm.amount;
            accountName = MainForm.accountName;

            // Show account name
            lblAccountName.Text = "Hello! " + accountName;
            
            pictureBoxAccountAdmin.Hide();
            pictureBoxAccountTrong.Hide();
            if (accountName == "Admin")
            {
                // Show Admin Avatar, Hide The Others
                pictureBoxAccountAdmin.Show();
                pictureBoxAccountTrong.Hide();
            }
            else
            {
                // Show Trong Avatar, Hide The Others
                pictureBoxAccountAdmin.Hide();
                pictureBoxAccountTrong.Show();
            }

            btnBack.Visible = false; // Hide Back Button
            _instance = this;

            // Filled panel with User Control ucHome
            ucHome uc = new ucHome();
            uc.Dock = DockStyle.Fill;
            panel.Controls.Add(uc);
        }

        // Slide effect
        private void btnInfo_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        
        /// <summary>
        /// Make the slide effect for menu button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isHidden)
            {
                panelSlide.Width += 10;
                if (panelSlide.Width >= panelWidth)
                {
                    timer1.Stop();
                    isHidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panelSlide.Width -= 10;
                if (panelSlide.Width <= 0)
                {
                    timer1.Stop();
                    isHidden = true;
                    this.Refresh();
                }
            }
        }

        /// <summary>
        /// Show The Current Amount of Balance on lblBalance 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            lblBalance.Text = Convert.ToString(amount); // Set amount number as label Balance text
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // As ucHome is the Main User Control
            // if another User Controls Fill In The Panel
            // the Back Button Will Appear
            if (panel.Controls.Contains(ucHome.Instance) == false)
                {
                    panel.Controls.Add(ucHome.Instance);
                    ucHome.Instance.Dock = DockStyle.Fill;
                    ucHome.Instance.BringToFront();
                }
                else if (panel.Controls.Contains(ucHome.Instance) == true)
                {
                    ucHome.Instance.BringToFront();
                }

            btnBack.Visible = false;
        }

        // When ucHome bring to front, the back button will invisible again   
        private void btnEscape_Click(object sender, EventArgs e)
        {
            this.Dispose();  // Dispose the current form
            ucHome.Instance = null;
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

       
      
    

