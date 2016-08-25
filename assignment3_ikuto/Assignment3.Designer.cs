namespace assignment3_ikuto
{
    partial class Assignment3
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
            this.bankTabs = new System.Windows.Forms.TabControl();
            this.loginTab = new System.Windows.Forms.TabPage();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.accountIDTbx = new System.Windows.Forms.TextBox();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.amountTbx = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.transactTypeCbx = new System.Windows.Forms.ComboBox();
            this.accountTypeCbx = new System.Windows.Forms.ComboBox();
            this.balanceLv = new System.Windows.Forms.Label();
            this.accountIDLv = new System.Windows.Forms.Label();
            this.transactionLvx = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.accountHolderIDLv = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bankTabs.SuspendLayout();
            this.loginTab.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bankTabs
            // 
            this.bankTabs.Controls.Add(this.loginTab);
            this.bankTabs.Controls.Add(this.mainTab);
            this.bankTabs.Location = new System.Drawing.Point(12, 12);
            this.bankTabs.Name = "bankTabs";
            this.bankTabs.SelectedIndex = 0;
            this.bankTabs.Size = new System.Drawing.Size(591, 400);
            this.bankTabs.TabIndex = 0;
            // 
            // loginTab
            // 
            this.loginTab.Controls.Add(this.loginBtn);
            this.loginTab.Controls.Add(this.label2);
            this.loginTab.Controls.Add(this.passwordTbx);
            this.loginTab.Controls.Add(this.label1);
            this.loginTab.Controls.Add(this.accountIDTbx);
            this.loginTab.Location = new System.Drawing.Point(4, 22);
            this.loginTab.Name = "loginTab";
            this.loginTab.Padding = new System.Windows.Forms.Padding(3);
            this.loginTab.Size = new System.Drawing.Size(583, 374);
            this.loginTab.TabIndex = 0;
            this.loginTab.Text = "Login";
            this.loginTab.UseVisualStyleBackColor = true;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.LightBlue;
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Location = new System.Drawing.Point(197, 220);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(180, 26);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // passwordTbx
            // 
            this.passwordTbx.Location = new System.Drawing.Point(277, 181);
            this.passwordTbx.Name = "passwordTbx";
            this.passwordTbx.Size = new System.Drawing.Size(100, 20);
            this.passwordTbx.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account ID";
            // 
            // accountIDTbx
            // 
            this.accountIDTbx.Location = new System.Drawing.Point(277, 140);
            this.accountIDTbx.Name = "accountIDTbx";
            this.accountIDTbx.Size = new System.Drawing.Size(100, 20);
            this.accountIDTbx.TabIndex = 0;
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.logoutBtn);
            this.mainTab.Controls.Add(this.accountHolderIDLv);
            this.mainTab.Controls.Add(this.label6);
            this.mainTab.Controls.Add(this.label3);
            this.mainTab.Controls.Add(this.groupBox1);
            this.mainTab.Controls.Add(this.accountTypeCbx);
            this.mainTab.Controls.Add(this.balanceLv);
            this.mainTab.Controls.Add(this.accountIDLv);
            this.mainTab.Controls.Add(this.transactionLvx);
            this.mainTab.Location = new System.Drawing.Point(4, 22);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainTab.Size = new System.Drawing.Size(583, 374);
            this.mainTab.TabIndex = 1;
            this.mainTab.Text = "Main";
            this.mainTab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.amountTbx);
            this.groupBox1.Controls.Add(this.submitBtn);
            this.groupBox1.Controls.Add(this.transactTypeCbx);
            this.groupBox1.Location = new System.Drawing.Point(234, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 107);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transact";
            // 
            // amountTbx
            // 
            this.amountTbx.Location = new System.Drawing.Point(63, 46);
            this.amountTbx.Name = "amountTbx";
            this.amountTbx.Size = new System.Drawing.Size(100, 20);
            this.amountTbx.TabIndex = 8;
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.submitBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn.Location = new System.Drawing.Point(63, 72);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(100, 23);
            this.submitBtn.TabIndex = 6;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // transactTypeCbx
            // 
            this.transactTypeCbx.FormattingEnabled = true;
            this.transactTypeCbx.Items.AddRange(new object[] {
            "Withdraw",
            "Deposit",
            "Transfer"});
            this.transactTypeCbx.Location = new System.Drawing.Point(63, 19);
            this.transactTypeCbx.Name = "transactTypeCbx";
            this.transactTypeCbx.Size = new System.Drawing.Size(100, 21);
            this.transactTypeCbx.TabIndex = 5;
            // 
            // accountTypeCbx
            // 
            this.accountTypeCbx.FormattingEnabled = true;
            this.accountTypeCbx.Location = new System.Drawing.Point(9, 59);
            this.accountTypeCbx.Name = "accountTypeCbx";
            this.accountTypeCbx.Size = new System.Drawing.Size(100, 21);
            this.accountTypeCbx.TabIndex = 3;
            this.accountTypeCbx.SelectedIndexChanged += new System.EventHandler(this.accountTypeCbx_SelectedIndexChanged);
            // 
            // balanceLv
            // 
            this.balanceLv.AutoSize = true;
            this.balanceLv.Location = new System.Drawing.Point(6, 93);
            this.balanceLv.Name = "balanceLv";
            this.balanceLv.Size = new System.Drawing.Size(46, 13);
            this.balanceLv.TabIndex = 2;
            this.balanceLv.Text = "Balance";
            // 
            // accountIDLv
            // 
            this.accountIDLv.AutoSize = true;
            this.accountIDLv.Location = new System.Drawing.Point(113, 13);
            this.accountIDLv.Name = "accountIDLv";
            this.accountIDLv.Size = new System.Drawing.Size(61, 13);
            this.accountIDLv.TabIndex = 1;
            this.accountIDLv.Text = "Account ID";
            // 
            // transactionLvx
            // 
            this.transactionLvx.Location = new System.Drawing.Point(9, 156);
            this.transactionLvx.Name = "transactionLvx";
            this.transactionLvx.Size = new System.Drawing.Size(568, 212);
            this.transactionLvx.TabIndex = 0;
            this.transactionLvx.UseCompatibleStateImageBehavior = false;
            this.transactionLvx.View = System.Windows.Forms.View.Details;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Account ID : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Account Holder ID";
            // 
            // accountHolderIDLv
            // 
            this.accountHolderIDLv.AutoSize = true;
            this.accountHolderIDLv.Location = new System.Drawing.Point(113, 37);
            this.accountHolderIDLv.Name = "accountHolderIDLv";
            this.accountHolderIDLv.Size = new System.Drawing.Size(95, 13);
            this.accountHolderIDLv.TabIndex = 7;
            this.accountHolderIDLv.Text = "Account Holder ID";
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.logoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Location = new System.Drawing.Point(459, 13);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(100, 23);
            this.logoutBtn.TabIndex = 10;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Type";
            // 
            // Assignment3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 424);
            this.Controls.Add(this.bankTabs);
            this.Name = "Assignment3";
            this.Text = "IKUTO BANK";
            this.Load += new System.EventHandler(this.Assignment3_Load);
            this.bankTabs.ResumeLayout(false);
            this.loginTab.ResumeLayout(false);
            this.loginTab.PerformLayout();
            this.mainTab.ResumeLayout(false);
            this.mainTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl bankTabs;
        private System.Windows.Forms.TabPage loginTab;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox accountIDTbx;
        private System.Windows.Forms.TabPage mainTab;
        private System.Windows.Forms.ListView transactionLvx;
        private System.Windows.Forms.Label balanceLv;
        private System.Windows.Forms.Label accountIDLv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox amountTbx;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.ComboBox transactTypeCbx;
        private System.Windows.Forms.ComboBox accountTypeCbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label accountHolderIDLv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label label5;
    }
}

