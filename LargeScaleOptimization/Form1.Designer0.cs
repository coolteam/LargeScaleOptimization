namespace LargeScaleOptimization
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
            this.calcButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.calcBattonInt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(12, 330);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(260, 41);
            this.calcButton.TabIndex = 0;
            this.calcButton.Text = "Reduce vector bool";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(573, 311);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // calcBattonInt
            // 
            this.calcBattonInt.Location = new System.Drawing.Point(326, 330);
            this.calcBattonInt.Name = "calcBattonInt";
            this.calcBattonInt.Size = new System.Drawing.Size(260, 41);
            this.calcBattonInt.TabIndex = 2;
            this.calcBattonInt.Text = "Reduce vector int";
            this.calcBattonInt.UseVisualStyleBackColor = true;
            this.calcBattonInt.Click += new System.EventHandler(this.calcBattonInt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 383);
            this.Controls.Add(this.calcBattonInt);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.calcButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button calcBattonInt;
    }
}

