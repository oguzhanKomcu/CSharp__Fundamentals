namespace Dice_Game_Project
{
    partial class DiceGame2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBarbut2 = new System.Windows.Forms.Button();
            this.labelBalance = new System.Windows.Forms.Label();
            this.textBetAmount = new System.Windows.Forms.TextBox();
            this.labelResault = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnBarbut2);
            this.groupBox1.Controls.Add(this.labelBalance);
            this.groupBox1.Controls.Add(this.textBetAmount);
            this.groupBox1.Controls.Add(this.labelResault);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(40, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 297);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DİCE GAME ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Bet Amount :";
            // 
            // btnBarbut2
            // 
            this.btnBarbut2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBarbut2.Location = new System.Drawing.Point(130, 197);
            this.btnBarbut2.Name = "btnBarbut2";
            this.btnBarbut2.Size = new System.Drawing.Size(129, 40);
            this.btnBarbut2.TabIndex = 0;
            this.btnBarbut2.Text = "Roll The Dice";
            this.btnBarbut2.UseVisualStyleBackColor = true;
            this.btnBarbut2.Click += new System.EventHandler(this.btnBarbut2_Click);
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBalance.Location = new System.Drawing.Point(130, 58);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(0, 25);
            this.labelBalance.TabIndex = 2;
            // 
            // textBetAmount
            // 
            this.textBetAmount.Location = new System.Drawing.Point(130, 156);
            this.textBetAmount.Name = "textBetAmount";
            this.textBetAmount.Size = new System.Drawing.Size(129, 23);
            this.textBetAmount.TabIndex = 1;
            // 
            // labelResault
            // 
            this.labelResault.AutoSize = true;
            this.labelResault.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResault.Location = new System.Drawing.Point(130, 91);
            this.labelResault.Name = "labelResault";
            this.labelResault.Size = new System.Drawing.Size(0, 25);
            this.labelResault.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "BALANCE :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "RESAULT :";
            // 
            // DiceGame2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 384);
            this.Controls.Add(this.groupBox1);
            this.Name = "DiceGame2";
            this.Text = "DiceGame2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DiceGame2_FormClosing);
            this.Load += new System.EventHandler(this.DiceGame2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Button btnBarbut2;
        private Label labelBalance;
        private TextBox textBetAmount;
        private Label labelResault;
        private Label label1;
        private Label label2;
    }
}