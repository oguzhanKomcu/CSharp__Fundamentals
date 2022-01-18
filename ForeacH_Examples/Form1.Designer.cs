namespace ForeacH_Examples
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
            this.textNewNumber = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNewNumber = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Examples1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Examples2 = new System.Windows.Forms.Button();
            this.Examples3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textNewNumber
            // 
            this.textNewNumber.Location = new System.Drawing.Point(139, 44);
            this.textNewNumber.Name = "textNewNumber";
            this.textNewNumber.Size = new System.Drawing.Size(111, 23);
            this.textNewNumber.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNewNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textNewNumber);
            this.groupBox1.Location = new System.Drawing.Point(501, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 144);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adding And Adding New Numbers";
            // 
            // btnNewNumber
            // 
            this.btnNewNumber.Location = new System.Drawing.Point(141, 87);
            this.btnNewNumber.Name = "btnNewNumber";
            this.btnNewNumber.Size = new System.Drawing.Size(109, 37);
            this.btnNewNumber.TabIndex = 3;
            this.btnNewNumber.Text = "CALCULATE";
            this.btnNewNumber.UseVisualStyleBackColor = true;
            this.btnNewNumber.Click += new System.EventHandler(this.btnNewNumber_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Number Add :";
            // 
            // Examples1
            // 
            this.Examples1.Location = new System.Drawing.Point(237, 12);
            this.Examples1.Name = "Examples1";
            this.Examples1.Size = new System.Drawing.Size(107, 36);
            this.Examples1.TabIndex = 3;
            this.Examples1.Text = "Examples1";
            this.Examples1.UseVisualStyleBackColor = true;
            this.Examples1.Click += new System.EventHandler(this.Examples1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(219, 409);
            this.listBox1.TabIndex = 4;
            // 
            // Examples2
            // 
            this.Examples2.Location = new System.Drawing.Point(237, 85);
            this.Examples2.Name = "Examples2";
            this.Examples2.Size = new System.Drawing.Size(105, 36);
            this.Examples2.TabIndex = 5;
            this.Examples2.Text = "Examples2";
            this.Examples2.UseVisualStyleBackColor = true;
            this.Examples2.Click += new System.EventHandler(this.Examples2_Click);
            // 
            // Examples3
            // 
            this.Examples3.Location = new System.Drawing.Point(233, 155);
            this.Examples3.Name = "Examples3";
            this.Examples3.Size = new System.Drawing.Size(107, 36);
            this.Examples3.TabIndex = 6;
            this.Examples3.Text = "Examples3";
            this.Examples3.UseVisualStyleBackColor = true;
            this.Examples3.Click += new System.EventHandler(this.Examples3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sorting teams A-Z";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sorting teams  Z-A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Querying the end-of-term student status\r\n document according to the grades in the" +
    " given list";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Examples3);
            this.Controls.Add(this.Examples2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Examples1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textNewNumber;
        private GroupBox groupBox1;
        private Label label1;
        private Button btnNewNumber;
        private Button Examples1;
        private ListBox listBox1;
        private Button Examples2;
        private Button Examples3;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}