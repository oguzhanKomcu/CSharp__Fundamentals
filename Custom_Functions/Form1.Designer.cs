namespace Custom_Functions
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
            this.btnFactorialFunction = new System.Windows.Forms.Button();
            this.textFactorialNumber = new System.Windows.Forms.TextBox();
            this.btnExample1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textNumber1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.textWeight = new System.Windows.Forms.TextBox();
            this.btnBmi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFactorialFunction);
            this.groupBox1.Controls.Add(this.textFactorialNumber);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Factorial Calculation Function";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Number : ";
            // 
            // btnFactorialFunction
            // 
            this.btnFactorialFunction.Location = new System.Drawing.Point(101, 73);
            this.btnFactorialFunction.Name = "btnFactorialFunction";
            this.btnFactorialFunction.Size = new System.Drawing.Size(114, 34);
            this.btnFactorialFunction.TabIndex = 1;
            this.btnFactorialFunction.Text = "CALCULATE";
            this.btnFactorialFunction.UseVisualStyleBackColor = true;
            this.btnFactorialFunction.Click += new System.EventHandler(this.btnFactorialFunction_Click);
            // 
            // textFactorialNumber
            // 
            this.textFactorialNumber.Location = new System.Drawing.Point(101, 39);
            this.textFactorialNumber.Name = "textFactorialNumber";
            this.textFactorialNumber.Size = new System.Drawing.Size(114, 23);
            this.textFactorialNumber.TabIndex = 0;
            // 
            // btnExample1
            // 
            this.btnExample1.Location = new System.Drawing.Point(106, 49);
            this.btnExample1.Name = "btnExample1";
            this.btnExample1.Size = new System.Drawing.Size(95, 39);
            this.btnExample1.TabIndex = 1;
            this.btnExample1.Text = "Example1";
            this.btnExample1.UseVisualStyleBackColor = true;
            this.btnExample1.Click += new System.EventHandler(this.btnExample1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mile To Km \r\nConverter Function";
            // 
            // textNumber1
            // 
            this.textNumber1.Location = new System.Drawing.Point(106, 20);
            this.textNumber1.Name = "textNumber1";
            this.textNumber1.Size = new System.Drawing.Size(95, 23);
            this.textNumber1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "MİLE : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExample1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textNumber1);
            this.groupBox2.Location = new System.Drawing.Point(12, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 130);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mile -Km Function";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBmi);
            this.groupBox3.Controls.Add(this.textWeight);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textHeight);
            this.groupBox3.Location = new System.Drawing.Point(12, 308);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 161);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Body Mass Index Function";
            // 
            // textHeight
            // 
            this.textHeight.Location = new System.Drawing.Point(122, 37);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(100, 23);
            this.textHeight.TabIndex = 0;
            // 
            // textWeight
            // 
            this.textWeight.Location = new System.Drawing.Point(122, 71);
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(100, 23);
            this.textWeight.TabIndex = 0;
            // 
            // btnBmi
            // 
            this.btnBmi.Location = new System.Drawing.Point(123, 109);
            this.btnBmi.Name = "btnBmi";
            this.btnBmi.Size = new System.Drawing.Size(99, 34);
            this.btnBmi.TabIndex = 1;
            this.btnBmi.Text = "CALCULATE";
            this.btnBmi.UseVisualStyleBackColor = true;
            this.btnBmi.Click += new System.EventHandler(this.btnBmi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "HEIGHT  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "WEIGHT :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Body Mass Index :";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(662, 503);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textFactorialNumber;
        private Label label1;
        private Button btnFactorialFunction;
        private Button btnExample1;
        private Label label2;
        private TextBox textNumber1;
        private Label label3;
        private Label label4;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnBmi;
        private TextBox textWeight;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textHeight;
    }
}