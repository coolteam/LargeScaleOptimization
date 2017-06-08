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
            this.reduceVectorIntegerButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.calcGomory = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.reduceVectorBoolButton = new System.Windows.Forms.Button();
            this.BalashBoolButton = new System.Windows.Forms.Button();
            this.buttonTestLPSolve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reduceVectorIntegerButton
            // 
            this.reduceVectorIntegerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reduceVectorIntegerButton.Location = new System.Drawing.Point(13, 251);
            this.reduceVectorIntegerButton.Name = "reduceVectorIntegerButton";
            this.reduceVectorIntegerButton.Size = new System.Drawing.Size(260, 41);
            this.reduceVectorIntegerButton.TabIndex = 0;
            this.reduceVectorIntegerButton.Text = "ReduceVectorInteger";
            this.reduceVectorIntegerButton.UseVisualStyleBackColor = true;
            this.reduceVectorIntegerButton.Click += new System.EventHandler(this.ReduceVector_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(13, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(573, 232);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // calcGomory
            // 
            this.calcGomory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calcGomory.Location = new System.Drawing.Point(420, 251);
            this.calcGomory.Name = "calcGomory";
            this.calcGomory.Size = new System.Drawing.Size(166, 41);
            this.calcGomory.TabIndex = 2;
            this.calcGomory.Text = "GomoryInteger";
            this.calcGomory.UseVisualStyleBackColor = true;
            this.calcGomory.Click += new System.EventHandler(this.calcGomory_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(278, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reduceVectorBoolButton
            // 
            this.reduceVectorBoolButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reduceVectorBoolButton.Location = new System.Drawing.Point(13, 302);
            this.reduceVectorBoolButton.Name = "reduceVectorBoolButton";
            this.reduceVectorBoolButton.Size = new System.Drawing.Size(260, 41);
            this.reduceVectorBoolButton.TabIndex = 4;
            this.reduceVectorBoolButton.Text = "ReduceVectorBool";
            this.reduceVectorBoolButton.UseVisualStyleBackColor = true;
            this.reduceVectorBoolButton.Click += new System.EventHandler(this.reduceVectorBoolButton_Click);
            // 
            // BalashBoolButton
            // 
            this.BalashBoolButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BalashBoolButton.Location = new System.Drawing.Point(420, 302);
            this.BalashBoolButton.Name = "BalashBoolButton";
            this.BalashBoolButton.Size = new System.Drawing.Size(166, 41);
            this.BalashBoolButton.TabIndex = 5;
            this.BalashBoolButton.Text = "BalashBool";
            this.BalashBoolButton.UseVisualStyleBackColor = true;
            this.BalashBoolButton.Click += new System.EventHandler(this.BalashBoolButton_Click);
            // 
            // buttonTestLPSolve
            // 
            this.buttonTestLPSolve.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTestLPSolve.Location = new System.Drawing.Point(276, 251);
            this.buttonTestLPSolve.Name = "buttonTestLPSolve";
            this.buttonTestLPSolve.Size = new System.Drawing.Size(138, 41);
            this.buttonTestLPSolve.TabIndex = 6;
            this.buttonTestLPSolve.Text = "test LPSolve";
            this.buttonTestLPSolve.UseVisualStyleBackColor = true;
            this.buttonTestLPSolve.Click += new System.EventHandler(this.buttonTestLPSolve_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 355);
            this.Controls.Add(this.buttonTestLPSolve);
            this.Controls.Add(this.BalashBoolButton);
            this.Controls.Add(this.reduceVectorBoolButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.calcGomory);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.reduceVectorIntegerButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reduceVectorIntegerButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button calcGomory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button reduceVectorBoolButton;
        private System.Windows.Forms.Button BalashBoolButton;
        private System.Windows.Forms.Button buttonTestLPSolve;
    }
}

