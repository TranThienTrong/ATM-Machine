namespace ATM_SYSTEM
{
    partial class ucLoan
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbReceipt = new System.Windows.Forms.RichTextBox();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtNumberOfYears = new System.Windows.Forms.TextBox();
            this.txtAmountOfLoan = new System.Windows.Forms.TextBox();
            this.btnLoanSystem = new System.Windows.Forms.Button();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbReceipt
            // 
            this.rtbReceipt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbReceipt.Font = new System.Drawing.Font("Century Gothic", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbReceipt.Location = new System.Drawing.Point(398, 149);
            this.rtbReceipt.Name = "rtbReceipt";
            this.rtbReceipt.Size = new System.Drawing.Size(568, 398);
            this.rtbReceipt.TabIndex = 46;
            this.rtbReceipt.Text = "";
            this.rtbReceipt.TextChanged += new System.EventHandler(this.rtbReceipt_TextChanged);
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalPayment.Font = new System.Drawing.Font("Century Gothic", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayment.Location = new System.Drawing.Point(168, 466);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(224, 81);
            this.lblTotalPayment.TabIndex = 45;
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.Font = new System.Drawing.Font("Century Gothic", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyPayment.Location = new System.Drawing.Point(168, 382);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(224, 74);
            this.lblMonthlyPayment.TabIndex = 44;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInterestRate.Font = new System.Drawing.Font("Century Gothic", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterestRate.Location = new System.Drawing.Point(168, 296);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(224, 65);
            this.txtInterestRate.TabIndex = 43;
            // 
            // txtNumberOfYears
            // 
            this.txtNumberOfYears.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumberOfYears.Font = new System.Drawing.Font("Century Gothic", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfYears.Location = new System.Drawing.Point(168, 222);
            this.txtNumberOfYears.Name = "txtNumberOfYears";
            this.txtNumberOfYears.Size = new System.Drawing.Size(224, 65);
            this.txtNumberOfYears.TabIndex = 42;
            // 
            // txtAmountOfLoan
            // 
            this.txtAmountOfLoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmountOfLoan.Font = new System.Drawing.Font("Century Gothic", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountOfLoan.Location = new System.Drawing.Point(168, 149);
            this.txtAmountOfLoan.Name = "txtAmountOfLoan";
            this.txtAmountOfLoan.Size = new System.Drawing.Size(224, 65);
            this.txtAmountOfLoan.TabIndex = 41;
            this.txtAmountOfLoan.TextChanged += new System.EventHandler(this.txtAmountOfLoan_TextChanged);
            // 
            // btnLoanSystem
            // 
            this.btnLoanSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(63)))), ((int)(((byte)(3)))));
            this.btnLoanSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoanSystem.FlatAppearance.BorderSize = 0;
            this.btnLoanSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoanSystem.Font = new System.Drawing.Font("Century Gothic", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoanSystem.ForeColor = System.Drawing.Color.White;
            this.btnLoanSystem.Location = new System.Drawing.Point(111, 595);
            this.btnLoanSystem.Name = "btnLoanSystem";
            this.btnLoanSystem.Size = new System.Drawing.Size(281, 96);
            this.btnLoanSystem.TabIndex = 50;
            this.btnLoanSystem.Text = "Loan";
            this.btnLoanSystem.UseVisualStyleBackColor = false;
            this.btnLoanSystem.Click += new System.EventHandler(this.btnLoanSystem_Click);
            // 
            // btnReceipt
            // 
            this.btnReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(63)))), ((int)(((byte)(3)))));
            this.btnReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceipt.FlatAppearance.BorderSize = 0;
            this.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceipt.Font = new System.Drawing.Font("Century Gothic", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceipt.ForeColor = System.Drawing.Color.White;
            this.btnReceipt.Location = new System.Drawing.Point(398, 595);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(281, 96);
            this.btnReceipt.TabIndex = 51;
            this.btnReceipt.Text = "Receipt";
            this.btnReceipt.UseVisualStyleBackColor = false;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(63)))), ((int)(((byte)(3)))));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(685, 595);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(281, 96);
            this.btnReset.TabIndex = 52;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbl
            // 
            this.lbl.Font = new System.Drawing.Font("Century Gothic", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(3, 130);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(159, 62);
            this.lbl.TabIndex = 53;
            this.lbl.Text = "Loan Amount";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 62);
            this.label1.TabIndex = 54;
            this.label1.Text = "Interest Rate";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 62);
            this.label2.TabIndex = 55;
            this.label2.Text = "Number Of Year";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 62);
            this.label3.TabIndex = 56;
            this.label3.Text = "Monthly Payment";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 62);
            this.label4.TabIndex = 57;
            this.label4.Text = "Total Payment";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ucLoan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnReceipt);
            this.Controls.Add(this.btnLoanSystem);
            this.Controls.Add(this.rtbReceipt);
            this.Controls.Add(this.lblTotalPayment);
            this.Controls.Add(this.lblMonthlyPayment);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtNumberOfYears);
            this.Controls.Add(this.txtAmountOfLoan);
            this.Name = "ucLoan";
            this.Size = new System.Drawing.Size(1186, 836);
            this.Load += new System.EventHandler(this.ucLoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbReceipt;
        private System.Windows.Forms.Label lblTotalPayment;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtNumberOfYears;
        private System.Windows.Forms.TextBox txtAmountOfLoan;
        private System.Windows.Forms.Button btnLoanSystem;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
