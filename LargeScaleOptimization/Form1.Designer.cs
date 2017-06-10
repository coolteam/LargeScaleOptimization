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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.inputCGrid = new System.Windows.Forms.DataGridView();
            this.inputAGrid = new System.Windows.Forms.DataGridView();
            this.mSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGenerateGrid = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputCGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputAGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSize)).BeginInit();
            this.SuspendLayout();
            // 
            // reduceVectorIntegerButton
            // 
            this.reduceVectorIntegerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reduceVectorIntegerButton.Location = new System.Drawing.Point(6, 258);
            this.reduceVectorIntegerButton.Name = "reduceVectorIntegerButton";
            this.reduceVectorIntegerButton.Size = new System.Drawing.Size(183, 41);
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
            this.richTextBox1.Location = new System.Drawing.Point(6, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(866, 204);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // calcGomory
            // 
            this.calcGomory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.calcGomory.Location = new System.Drawing.Point(690, 258);
            this.calcGomory.Name = "calcGomory";
            this.calcGomory.Size = new System.Drawing.Size(182, 41);
            this.calcGomory.TabIndex = 2;
            this.calcGomory.Text = "GomoryInteger";
            this.calcGomory.UseVisualStyleBackColor = true;
            this.calcGomory.Click += new System.EventHandler(this.calcGomory_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(359, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reduceVectorBoolButton
            // 
            this.reduceVectorBoolButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reduceVectorBoolButton.Location = new System.Drawing.Point(6, 211);
            this.reduceVectorBoolButton.Name = "reduceVectorBoolButton";
            this.reduceVectorBoolButton.Size = new System.Drawing.Size(183, 41);
            this.reduceVectorBoolButton.TabIndex = 4;
            this.reduceVectorBoolButton.Text = "ReduceVectorBool";
            this.reduceVectorBoolButton.UseVisualStyleBackColor = true;
            this.reduceVectorBoolButton.Click += new System.EventHandler(this.reduceVectorBoolButton_Click);
            // 
            // BalashBoolButton
            // 
            this.BalashBoolButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BalashBoolButton.Location = new System.Drawing.Point(690, 211);
            this.BalashBoolButton.Name = "BalashBoolButton";
            this.BalashBoolButton.Size = new System.Drawing.Size(182, 41);
            this.BalashBoolButton.TabIndex = 5;
            this.BalashBoolButton.Text = "BalashBool";
            this.BalashBoolButton.UseVisualStyleBackColor = true;
            this.BalashBoolButton.Click += new System.EventHandler(this.BalashBoolButton_Click);
            // 
            // buttonTestLPSolve
            // 
            this.buttonTestLPSolve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTestLPSolve.Location = new System.Drawing.Point(359, 258);
            this.buttonTestLPSolve.Name = "buttonTestLPSolve";
            this.buttonTestLPSolve.Size = new System.Drawing.Size(137, 41);
            this.buttonTestLPSolve.TabIndex = 6;
            this.buttonTestLPSolve.Text = "test LPSolve";
            this.buttonTestLPSolve.UseVisualStyleBackColor = true;
            this.buttonTestLPSolve.Click += new System.EventHandler(this.buttonTestLPSolve_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(886, 331);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.BalashBoolButton);
            this.tabPage1.Controls.Add(this.buttonTestLPSolve);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.reduceVectorBoolButton);
            this.tabPage1.Controls.Add(this.reduceVectorIntegerButton);
            this.tabPage1.Controls.Add(this.calcGomory);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(878, 305);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.inputCGrid);
            this.tabPage2.Controls.Add(this.inputAGrid);
            this.tabPage2.Controls.Add(this.mSize);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.nSize);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.buttonGenerateGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(878, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // inputCGrid
            // 
            this.inputCGrid.AllowUserToAddRows = false;
            this.inputCGrid.AllowUserToDeleteRows = false;
            this.inputCGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputCGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.inputCGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputCGrid.ColumnHeadersVisible = false;
            this.inputCGrid.Location = new System.Drawing.Point(196, 13);
            this.inputCGrid.Name = "inputCGrid";
            this.inputCGrid.RowHeadersVisible = false;
            this.inputCGrid.Size = new System.Drawing.Size(676, 48);
            this.inputCGrid.TabIndex = 11;
            // 
            // inputAGrid
            // 
            this.inputAGrid.AllowUserToAddRows = false;
            this.inputAGrid.AllowUserToDeleteRows = false;
            this.inputAGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputAGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.inputAGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputAGrid.ColumnHeadersVisible = false;
            this.inputAGrid.Location = new System.Drawing.Point(195, 67);
            this.inputAGrid.Name = "inputAGrid";
            this.inputAGrid.RowHeadersVisible = false;
            this.inputAGrid.Size = new System.Drawing.Size(677, 232);
            this.inputAGrid.TabIndex = 10;
            // 
            // mSize
            // 
            this.mSize.Location = new System.Drawing.Point(69, 41);
            this.mSize.Name = "mSize";
            this.mSize.Size = new System.Drawing.Size(120, 20);
            this.mSize.TabIndex = 9;
            this.mSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "m";
            // 
            // nSize
            // 
            this.nSize.Location = new System.Drawing.Point(69, 13);
            this.nSize.Name = "nSize";
            this.nSize.Size = new System.Drawing.Size(120, 20);
            this.nSize.TabIndex = 7;
            this.nSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "n";
            // 
            // buttonGenerateGrid
            // 
            this.buttonGenerateGrid.Location = new System.Drawing.Point(6, 67);
            this.buttonGenerateGrid.Name = "buttonGenerateGrid";
            this.buttonGenerateGrid.Size = new System.Drawing.Size(183, 41);
            this.buttonGenerateGrid.TabIndex = 5;
            this.buttonGenerateGrid.Text = "GenerateGrid";
            this.buttonGenerateGrid.UseVisualStyleBackColor = true;
            this.buttonGenerateGrid.Click += new System.EventHandler(this.buttonGenerateGrid_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 354);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "RVM Solver";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputCGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputAGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSize)).EndInit();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView inputAGrid;
        private System.Windows.Forms.NumericUpDown mSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGenerateGrid;
        private System.Windows.Forms.DataGridView inputCGrid;
    }
}

