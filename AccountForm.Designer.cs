namespace ATM_SYSTEM
{
    partial class AccountForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.pictureBoxAccountAdmin = new System.Windows.Forms.PictureBox();
            this.pictureBoxAccountTrong = new System.Windows.Forms.PictureBox();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEscape = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.panelSlide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountTrong)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.panelLeft.Controls.Add(this.btnInfo);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 64);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(60, 836);
            this.panelLeft.TabIndex = 1;
            // 
            // btnInfo
            // 
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.Location = new System.Drawing.Point(3, 3);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(50, 50);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.panelSlide.Controls.Add(this.btnCheckBalance);
            this.panelSlide.Controls.Add(this.lblBalance);
            this.panelSlide.Controls.Add(this.pictureBoxAccountAdmin);
            this.panelSlide.Controls.Add(this.pictureBoxAccountTrong);
            this.panelSlide.Controls.Add(this.lblAccountName);
            this.panelSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlide.Location = new System.Drawing.Point(60, 64);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(194, 836);
            this.panelSlide.TabIndex = 2;
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(63)))), ((int)(((byte)(3)))));
            this.btnCheckBalance.FlatAppearance.BorderSize = 0;
            this.btnCheckBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckBalance.Font = new System.Drawing.Font("Century Gothic", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckBalance.ForeColor = System.Drawing.Color.White;
            this.btnCheckBalance.Location = new System.Drawing.Point(-3, 298);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(197, 49);
            this.btnCheckBalance.TabIndex = 29;
            this.btnCheckBalance.Text = "Check Balance";
            this.btnCheckBalance.UseVisualStyleBackColor = false;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.Font = new System.Drawing.Font("Century Gothic", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(6, 239);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(185, 56);
            this.lblBalance.TabIndex = 28;
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxAccountAdmin
            // 
            this.pictureBoxAccountAdmin.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxAccountAdmin.ErrorImage")));
            this.pictureBoxAccountAdmin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAccountAdmin.Image")));
            this.pictureBoxAccountAdmin.Location = new System.Drawing.Point(-3, 0);
            this.pictureBoxAccountAdmin.Name = "pictureBoxAccountAdmin";
            this.pictureBoxAccountAdmin.Size = new System.Drawing.Size(197, 150);
            this.pictureBoxAccountAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAccountAdmin.TabIndex = 27;
            this.pictureBoxAccountAdmin.TabStop = false;
            // 
            // pictureBoxAccountTrong
            // 
            this.pictureBoxAccountTrong.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxAccountTrong.ErrorImage")));
            this.pictureBoxAccountTrong.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAccountTrong.Image")));
            this.pictureBoxAccountTrong.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAccountTrong.Name = "pictureBoxAccountTrong";
            this.pictureBoxAccountTrong.Size = new System.Drawing.Size(194, 150);
            this.pictureBoxAccountTrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAccountTrong.TabIndex = 26;
            this.pictureBoxAccountTrong.TabStop = false;
            // 
            // lblAccountName
            // 
            this.lblAccountName.Font = new System.Drawing.Font("Century Gothic", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountName.ForeColor = System.Drawing.Color.White;
            this.lblAccountName.Location = new System.Drawing.Point(6, 157);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(185, 56);
            this.lblAccountName.TabIndex = 24;
            this.lblAccountName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(213)))), ((int)(((byte)(92)))));
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(254, 64);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1186, 836);
            this.panel.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.panelTop.Controls.Add(this.btnBack);
            this.panelTop.Controls.Add(this.btnEscape);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1440, 64);
            this.panelTop.TabIndex = 0;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(254, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 64);
            this.btnBack.TabIndex = 25;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEscape
            // 
            this.btnEscape.FlatAppearance.BorderSize = 0;
            this.btnEscape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscape.Image = ((System.Drawing.Image)(resources.GetObject("btnEscape.Image")));
            this.btnEscape.Location = new System.Drawing.Point(1364, 0);
            this.btnEscape.Name = "btnEscape";
            this.btnEscape.Size = new System.Drawing.Size(76, 64);
            this.btnEscape.TabIndex = 26;
            this.btnEscape.UseVisualStyleBackColor = true;
            this.btnEscape.Click += new System.EventHandler(this.btnEscape_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(161)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panelSlide);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelSlide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountTrong)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnEscape;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.PictureBox pictureBoxAccountAdmin;
        private System.Windows.Forms.PictureBox pictureBoxAccountTrong;
        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnBack;
    }
}