namespace BasicCalculatorr
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.num1Txt = new System.Windows.Forms.TextBox();
            this.comboOperator = new System.Windows.Forms.ComboBox();
            this.num2Txt = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.computeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic Calculator";
          
            // 
            // num1Txt
            // 
            this.num1Txt.Location = new System.Drawing.Point(274, 121);
            this.num1Txt.Name = "num1Txt";
            this.num1Txt.Size = new System.Drawing.Size(163, 20);
            this.num1Txt.TabIndex = 1;
            // 
            // comboOperator
            // 
            this.comboOperator.FormattingEnabled = true;
            this.comboOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboOperator.Location = new System.Drawing.Point(334, 163);
            this.comboOperator.Name = "comboOperator";
            this.comboOperator.Size = new System.Drawing.Size(48, 21);
            this.comboOperator.TabIndex = 2;
            // 
            // num2Txt
            // 
            this.num2Txt.Location = new System.Drawing.Point(274, 213);
            this.num2Txt.Name = "num2Txt";
            this.num2Txt.Size = new System.Drawing.Size(163, 20);
            this.num2Txt.TabIndex = 3;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(323, 260);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(66, 25);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.Text = "Total:";
            // 
            // computeBtn
            // 
            this.computeBtn.BackColor = System.Drawing.Color.Red;
            this.computeBtn.Location = new System.Drawing.Point(316, 309);
            this.computeBtn.Name = "computeBtn";
            this.computeBtn.Size = new System.Drawing.Size(75, 23);
            this.computeBtn.TabIndex = 5;
            this.computeBtn.Text = "COMPUTE";
            this.computeBtn.UseVisualStyleBackColor = false;
            this.computeBtn.Click += new System.EventHandler(this.computeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.computeBtn);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.num2Txt);
            this.Controls.Add(this.comboOperator);
            this.Controls.Add(this.num1Txt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num1Txt;
        private System.Windows.Forms.ComboBox comboOperator;
        private System.Windows.Forms.TextBox num2Txt;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button computeBtn;
    }
}

