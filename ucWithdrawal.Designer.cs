namespace ATM_SYSTEM
{
    partial class ucWithdrawal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucWithdrawal));
            this.lblCheck = new System.Windows.Forms.Label();
            this.pictureBoxInvalid = new System.Windows.Forms.PictureBox();
            this.pictureBoxChecked = new System.Windows.Forms.PictureBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.txtAmountOfWithdrawal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInvalid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChecked)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCheck
            // 
            this.lblCheck.Font = new System.Drawing.Font("Century Gothic", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheck.Location = new System.Drawing.Point(453, 369);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(281, 63);
            this.lblCheck.TabIndex = 36;
            this.lblCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxInvalid
            // 
            this.pictureBoxInvalid.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInvalid.Image")));
            this.pictureBoxInvalid.Location = new System.Drawing.Point(522, 234);
            this.pictureBoxInvalid.Name = "pictureBoxInvalid";
            this.pictureBoxInvalid.Size = new System.Drawing.Size(141, 132);
            this.pictureBoxInvalid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxInvalid.TabIndex = 35;
            this.pictureBoxInvalid.TabStop = false;
            // 
            // pictureBoxChecked
            // 
            this.pictureBoxChecked.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxChecked.Image")));
            this.pictureBoxChecked.Location = new System.Drawing.Point(522, 234);
            this.pictureBoxChecked.Name = "pictureBoxChecked";
            this.pictureBoxChecked.Size = new System.Drawing.Size(140, 132);
            this.pictureBoxChecked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxChecked.TabIndex = 34;
            this.pictureBoxChecked.TabStop = false;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(63)))), ((int)(((byte)(3)))));
            this.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWithdraw.FlatAppearance.BorderSize = 0;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Font = new System.Drawing.Font("Century Gothic", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.Location = new System.Drawing.Point(453, 506);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(281, 96);
            this.btnWithdraw.TabIndex = 33;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // txtAmountOfWithdrawal
            // 
            this.txtAmountOfWithdrawal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmountOfWithdrawal.Font = new System.Drawing.Font("Century Gothic", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountOfWithdrawal.Location = new System.Drawing.Point(453, 435);
            this.txtAmountOfWithdrawal.Name = "txtAmountOfWithdrawal";
            this.txtAmountOfWithdrawal.Size = new System.Drawing.Size(281, 65);
            this.txtAmountOfWithdrawal.TabIndex = 32;
            this.txtAmountOfWithdrawal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ucWithdrawal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.pictureBoxInvalid);
            this.Controls.Add(this.pictureBoxChecked);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.txtAmountOfWithdrawal);
            this.Name = "ucWithdrawal";
            this.Size = new System.Drawing.Size(1186, 836);
            this.Load += new System.EventHandler(this.ucWithdrawal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInvalid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChecked)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.PictureBox pictureBoxInvalid;
        private System.Windows.Forms.PictureBox pictureBoxChecked;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.TextBox txtAmountOfWithdrawal;
    }
}
