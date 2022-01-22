namespace Custom_Functions
{
    partial class AtmApp2
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
            this.groupBoxSignUp = new System.Windows.Forms.GroupBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textUserId = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.groupBoxHomePage = new System.Windows.Forms.GroupBox();
            this.labelBalance = new System.Windows.Forms.Label();
            this.textTransactions = new System.Windows.Forms.TextBox();
            this.labelHomePageFullName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCashWithdrawal = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.groupBoxSignIn = new System.Windows.Forms.GroupBox();
            this.btnSignİn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textSignİnPassword = new System.Windows.Forms.TextBox();
            this.textSignİnUserID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxSignUp.SuspendLayout();
            this.groupBoxHomePage.SuspendLayout();
            this.groupBoxSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSignUp
            // 
            this.groupBoxSignUp.Controls.Add(this.btnSignUp);
            this.groupBoxSignUp.Controls.Add(this.label4);
            this.groupBoxSignUp.Controls.Add(this.label3);
            this.groupBoxSignUp.Controls.Add(this.label2);
            this.groupBoxSignUp.Controls.Add(this.label1);
            this.groupBoxSignUp.Controls.Add(this.textUserId);
            this.groupBoxSignUp.Controls.Add(this.textPassword);
            this.groupBoxSignUp.Controls.Add(this.textLastName);
            this.groupBoxSignUp.Controls.Add(this.textFirstName);
            this.groupBoxSignUp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSignUp.Location = new System.Drawing.Point(21, 12);
            this.groupBoxSignUp.Name = "groupBoxSignUp";
            this.groupBoxSignUp.Size = new System.Drawing.Size(316, 276);
            this.groupBoxSignUp.TabIndex = 1;
            this.groupBoxSignUp.TabStop = false;
            this.groupBoxSignUp.Text = "Sign Up";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSignUp.Location = new System.Drawing.Point(193, 193);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(96, 58);
            this.btnSignUp.TabIndex = 2;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(35, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "PASSWORD : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(35, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "User ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name : ";
            // 
            // textUserId
            // 
            this.textUserId.Location = new System.Drawing.Point(151, 112);
            this.textUserId.Name = "textUserId";
            this.textUserId.Size = new System.Drawing.Size(138, 27);
            this.textUserId.TabIndex = 0;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(151, 151);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(138, 27);
            this.textPassword.TabIndex = 0;
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(151, 73);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(138, 27);
            this.textLastName.TabIndex = 0;
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(151, 32);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(138, 27);
            this.textFirstName.TabIndex = 0;
            // 
            // groupBoxHomePage
            // 
            this.groupBoxHomePage.Controls.Add(this.labelBalance);
            this.groupBoxHomePage.Controls.Add(this.textTransactions);
            this.groupBoxHomePage.Controls.Add(this.labelHomePageFullName);
            this.groupBoxHomePage.Controls.Add(this.label8);
            this.groupBoxHomePage.Controls.Add(this.label7);
            this.groupBoxHomePage.Controls.Add(this.btnCashWithdrawal);
            this.groupBoxHomePage.Controls.Add(this.btnDeposit);
            this.groupBoxHomePage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxHomePage.Location = new System.Drawing.Point(671, 26);
            this.groupBoxHomePage.Name = "groupBoxHomePage";
            this.groupBoxHomePage.Size = new System.Drawing.Size(312, 262);
            this.groupBoxHomePage.TabIndex = 4;
            this.groupBoxHomePage.TabStop = false;
            this.groupBoxHomePage.Text = "Home Page";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBalance.Location = new System.Drawing.Point(165, 59);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(0, 30);
            this.labelBalance.TabIndex = 5;
            // 
            // textTransactions
            // 
            this.textTransactions.Location = new System.Drawing.Point(153, 111);
            this.textTransactions.Name = "textTransactions";
            this.textTransactions.Size = new System.Drawing.Size(131, 27);
            this.textTransactions.TabIndex = 4;
            // 
            // labelHomePageFullName
            // 
            this.labelHomePageFullName.AutoSize = true;
            this.labelHomePageFullName.Location = new System.Drawing.Point(24, 36);
            this.labelHomePageFullName.Name = "labelHomePageFullName";
            this.labelHomePageFullName.Size = new System.Drawing.Size(0, 20);
            this.labelHomePageFullName.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(51, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 30);
            this.label7.TabIndex = 1;
            this.label7.Text = "Balance :";
            // 
            // btnCashWithdrawal
            // 
            this.btnCashWithdrawal.Location = new System.Drawing.Point(65, 165);
            this.btnCashWithdrawal.Name = "btnCashWithdrawal";
            this.btnCashWithdrawal.Size = new System.Drawing.Size(100, 60);
            this.btnCashWithdrawal.TabIndex = 0;
            this.btnCashWithdrawal.Text = "Cash Withdrawal";
            this.btnCashWithdrawal.UseVisualStyleBackColor = true;
            this.btnCashWithdrawal.Click += new System.EventHandler(this.btnCashWithdrawal_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(188, 165);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(96, 60);
            this.btnDeposit.TabIndex = 0;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // groupBoxSignIn
            // 
            this.groupBoxSignIn.Controls.Add(this.btnSignİn);
            this.groupBoxSignIn.Controls.Add(this.label6);
            this.groupBoxSignIn.Controls.Add(this.label5);
            this.groupBoxSignIn.Controls.Add(this.textSignİnPassword);
            this.groupBoxSignIn.Controls.Add(this.textSignİnUserID);
            this.groupBoxSignIn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSignIn.Location = new System.Drawing.Point(369, 26);
            this.groupBoxSignIn.Name = "groupBoxSignIn";
            this.groupBoxSignIn.Size = new System.Drawing.Size(264, 182);
            this.groupBoxSignIn.TabIndex = 3;
            this.groupBoxSignIn.TabStop = false;
            this.groupBoxSignIn.Text = "Sign İn";
            // 
            // btnSignİn
            // 
            this.btnSignİn.Location = new System.Drawing.Point(161, 111);
            this.btnSignİn.Name = "btnSignİn";
            this.btnSignİn.Size = new System.Drawing.Size(84, 50);
            this.btnSignİn.TabIndex = 2;
            this.btnSignİn.Text = "Sign İn";
            this.btnSignİn.UseVisualStyleBackColor = true;
            this.btnSignİn.Click += new System.EventHandler(this.btnSignİn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(23, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(36, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "User ID :";
            // 
            // textSignİnPassword
            // 
            this.textSignİnPassword.Location = new System.Drawing.Point(123, 70);
            this.textSignİnPassword.Name = "textSignİnPassword";
            this.textSignİnPassword.Size = new System.Drawing.Size(122, 27);
            this.textSignİnPassword.TabIndex = 0;
            // 
            // textSignİnUserID
            // 
            this.textSignİnUserID.Location = new System.Drawing.Point(123, 33);
            this.textSignİnUserID.Name = "textSignİnUserID";
            this.textSignİnUserID.Size = new System.Drawing.Size(122, 27);
            this.textSignİnUserID.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(36, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 30);
            this.label8.TabIndex = 1;
            this.label8.Text = "PROCESS :";
            // 
            // AtmApp2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 450);
            this.Controls.Add(this.groupBoxHomePage);
            this.Controls.Add(this.groupBoxSignIn);
            this.Controls.Add(this.groupBoxSignUp);
            this.Name = "AtmApp2";
            this.Text = "AtmApp2";
            this.Load += new System.EventHandler(this.AtmApp2_Load);
            this.groupBoxSignUp.ResumeLayout(false);
            this.groupBoxSignUp.PerformLayout();
            this.groupBoxHomePage.ResumeLayout(false);
            this.groupBoxHomePage.PerformLayout();
            this.groupBoxSignIn.ResumeLayout(false);
            this.groupBoxSignIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxSignUp;
        private Button btnSignUp;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textUserId;
        private TextBox textPassword;
        private TextBox textLastName;
        private TextBox textFirstName;
        private GroupBox groupBoxHomePage;
        private Label label7;
        private Button btnCashWithdrawal;
        private Button btnDeposit;
        private GroupBox groupBoxSignIn;
        private Button btnSignİn;
        private Label label6;
        private Label label5;
        private TextBox textSignİnPassword;
        private TextBox textSignİnUserID;
        private Label labelHomePageFullName;
        private Label labelBalance;
        private TextBox textTransactions;
        private Label label8;
    }
}