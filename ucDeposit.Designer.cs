namespace ATM_SYSTEM
{
    partial class ucDeposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDeposit));
            this.txtAmountOfDeposit = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.pictureBoxChecked = new System.Windows.Forms.PictureBox();
            this.pictureBoxInvalid = new System.Windows.Forms.PictureBox();
            this.lblCheck = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChecked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInvalid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAmountOfDeposit
            // 
            this.txtAmountOfDeposit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmountOfDeposit.Font = new System.Drawing.Font("Century Gothic", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountOfDeposit.Location = new System.Drawing.Point(437, 410);
            this.txtAmountOfDeposit.Name = "txtAmountOfDeposit";
            this.txtAmountOfDeposit.Size = new System.Drawing.Size(281, 65);
            this.txtAmountOfDeposit.TabIndex = 27;
            this.txtAmountOfDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(63)))), ((int)(((byte)(3)))));
            this.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeposit.FlatAppearance.BorderSize = 0;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Font = new System.Drawing.Font("Century Gothic", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.Color.White;
            this.btnDeposit.Location = new System.Drawing.Point(437, 481);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(281, 96);
            this.btnDeposit.TabIndex = 28;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // pictureBoxChecked
            // 
            this.pictureBoxChecked.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxChecked.Image")));
            this.pictureBoxChecked.Location = new System.Drawing.Point(504, 198);
            this.pictureBoxChecked.Name = "pictureBoxChecked";
            this.pictureBoxChecked.Size = new System.Drawing.Size(140, 132);
            this.pictureBoxChecked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxChecked.TabIndex = 29;
            this.pictureBoxChecked.TabStop = false;
            // 
            // pictureBoxInvalid
            // 
            this.pictureBoxInvalid.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInvalid.Image")));
            this.pictureBoxInvalid.Location = new System.Drawing.Point(504, 198);
            this.pictureBoxInvalid.Name = "pictureBoxInvalid";
            this.pictureBoxInvalid.Size = new System.Drawing.Size(141, 132);
            this.pictureBoxInvalid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxInvalid.TabIndex = 30;
            this.pictureBoxInvalid.TabStop = false;
            // 
            // lblCheck
            // 
            this.lblCheck.Font = new System.Drawing.Font("Century Gothic", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheck.Location = new System.Drawing.Point(437, 344);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(281, 63);
            this.lblCheck.TabIndex = 31;
            this.lblCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucDeposit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.pictureBoxInvalid);
            this.Controls.Add(this.pictureBoxChecked);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.txtAmountOfDeposit);
            this.Name = "ucDeposit";
            this.Size = new System.Drawing.Size(1186, 836);
            this.Load += new System.EventHandler(this.ucDeposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChecked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInvalid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAmountOfDeposit;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.PictureBox pictureBoxChecked;
        private System.Windows.Forms.PictureBox pictureBoxInvalid;
        private System.Windows.Forms.Label lblCheck;
    }
}
