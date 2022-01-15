namespace _04_FoR_CYCLE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.textSayi1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btExample3 = new System.Windows.Forms.Button();
            this.btnPrimeNumbers = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFactorial);
            this.groupBox1.Controls.Add(this.textSayi1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Factorial Calculation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number :";
            // 
            // btnFactorial
            // 
            this.btnFactorial.Location = new System.Drawing.Point(102, 103);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(141, 36);
            this.btnFactorial.TabIndex = 1;
            this.btnFactorial.Text = "CALCULATİON";
            this.btnFactorial.UseVisualStyleBackColor = true;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // textSayi1
            // 
            this.textSayi1.Location = new System.Drawing.Point(102, 47);
            this.textSayi1.Name = "textSayi1";
            this.textSayi1.Size = new System.Drawing.Size(141, 33);
            this.textSayi1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(453, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(167, 319);
            this.listBox1.TabIndex = 2;
            // 
            // btExample3
            // 
            this.btExample3.Location = new System.Drawing.Point(319, 26);
            this.btExample3.Name = "btExample3";
            this.btExample3.Size = new System.Drawing.Size(107, 41);
            this.btExample3.TabIndex = 4;
            this.btExample3.Text = "NBA W-C";
            this.btExample3.UseVisualStyleBackColor = true;
            this.btExample3.Click += new System.EventHandler(this.btExample3_Click);
            // 
            // btnPrimeNumbers
            // 
            this.btnPrimeNumbers.Location = new System.Drawing.Point(319, 86);
            this.btnPrimeNumbers.Name = "btnPrimeNumbers";
            this.btnPrimeNumbers.Size = new System.Drawing.Size(108, 37);
            this.btnPrimeNumbers.TabIndex = 5;
            this.btnPrimeNumbers.Text = "Prime Numbers";
            this.btnPrimeNumbers.UseVisualStyleBackColor = true;
            this.btnPrimeNumbers.Click += new System.EventHandler(this.btnPrimeNumbers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.btnPrimeNumbers);
            this.Controls.Add(this.btExample3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnFactorial;
        private TextBox textSayi1;
        private Label label1;
        private ListBox listBox1;
        private Button btExample3;
        private Button btnPrimeNumbers;
    }
}