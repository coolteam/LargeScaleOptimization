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
            this.buttonGenerateGridTab1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonSolveTab1 = new System.Windows.Forms.Button();
            this.listBoxResultTab1 = new System.Windows.Forms.ListBox();
            this.listBoxResultTab2 = new System.Windows.Forms.ListBox();
            this.buttonStoreTab2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.numericUpDownMTab2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownNTab2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonGenerateProblemTab2 = new System.Windows.Forms.Button();
            this.radioButtonILPTab2 = new System.Windows.Forms.RadioButton();
            this.radioButtonBLPTab2 = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputCGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputAGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSize)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMTab2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNTab2)).BeginInit();
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
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(886, 409);
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
            this.tabPage1.Text = "-";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxResultTab1);
            this.tabPage2.Controls.Add(this.buttonSolveTab1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.inputCGrid);
            this.tabPage2.Controls.Add(this.inputAGrid);
            this.tabPage2.Controls.Add(this.mSize);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.nSize);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.buttonGenerateGridTab1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(878, 383);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Тест МР";
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
            this.inputAGrid.Size = new System.Drawing.Size(677, 310);
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
            // buttonGenerateGridTab1
            // 
            this.buttonGenerateGridTab1.Location = new System.Drawing.Point(9, 68);
            this.buttonGenerateGridTab1.Name = "buttonGenerateGridTab1";
            this.buttonGenerateGridTab1.Size = new System.Drawing.Size(180, 41);
            this.buttonGenerateGridTab1.TabIndex = 5;
            this.buttonGenerateGridTab1.Text = "Генерувати";
            this.buttonGenerateGridTab1.UseVisualStyleBackColor = true;
            this.buttonGenerateGridTab1.Click += new System.EventHandler(this.buttonGenerateGrid_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.radioButtonBLPTab2);
            this.tabPage3.Controls.Add(this.radioButtonILPTab2);
            this.tabPage3.Controls.Add(this.listBoxResultTab2);
            this.tabPage3.Controls.Add(this.buttonStoreTab2);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.numericUpDownMTab2);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.numericUpDownNTab2);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.buttonGenerateProblemTab2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(878, 383);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Генер. Вх.Д";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(878, 305);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Зчит. Вх.Д.";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(878, 305);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Тест ВР";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(878, 305);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Гр. Ч-Р";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(878, 305);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Гр. Т-Р";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(878, 305);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Гр. Т-Ч";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(878, 305);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Про";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "0";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Цілочисельний алгоритм МВС",
            "Алгоритм Гоморі",
            "Булевий алгоритм МВС",
            "Алгоритм Балаша"});
            this.comboBox1.Location = new System.Drawing.Point(9, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "Вибір алгоритму:";
            // 
            // buttonSolveTab1
            // 
            this.buttonSolveTab1.Location = new System.Drawing.Point(9, 143);
            this.buttonSolveTab1.Name = "buttonSolveTab1";
            this.buttonSolveTab1.Size = new System.Drawing.Size(180, 41);
            this.buttonSolveTab1.TabIndex = 13;
            this.buttonSolveTab1.Text = "Розв\'язати";
            this.buttonSolveTab1.UseVisualStyleBackColor = true;
            this.buttonSolveTab1.Click += new System.EventHandler(this.buttonSolveTab1_Click);
            // 
            // listBoxResultTab1
            // 
            this.listBoxResultTab1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxResultTab1.FormattingEnabled = true;
            this.listBoxResultTab1.Location = new System.Drawing.Point(9, 190);
            this.listBoxResultTab1.Name = "listBoxResultTab1";
            this.listBoxResultTab1.Size = new System.Drawing.Size(180, 186);
            this.listBoxResultTab1.TabIndex = 14;
            // 
            // listBoxResultTab2
            // 
            this.listBoxResultTab2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxResultTab2.FormattingEnabled = true;
            this.listBoxResultTab2.Location = new System.Drawing.Point(9, 212);
            this.listBoxResultTab2.Name = "listBoxResultTab2";
            this.listBoxResultTab2.Size = new System.Drawing.Size(180, 160);
            this.listBoxResultTab2.TabIndex = 24;
            // 
            // buttonStoreTab2
            // 
            this.buttonStoreTab2.Location = new System.Drawing.Point(9, 165);
            this.buttonStoreTab2.Name = "buttonStoreTab2";
            this.buttonStoreTab2.Size = new System.Drawing.Size(180, 41);
            this.buttonStoreTab2.TabIndex = 23;
            this.buttonStoreTab2.Text = "Зберегти для розв\'язку";
            this.buttonStoreTab2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(196, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(676, 48);
            this.dataGridView1.TabIndex = 21;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Location = new System.Drawing.Point(195, 63);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(677, 310);
            this.dataGridView2.TabIndex = 20;
            // 
            // numericUpDownMTab2
            // 
            this.numericUpDownMTab2.Location = new System.Drawing.Point(69, 37);
            this.numericUpDownMTab2.Name = "numericUpDownMTab2";
            this.numericUpDownMTab2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMTab2.TabIndex = 19;
            this.numericUpDownMTab2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "m";
            // 
            // numericUpDownNTab2
            // 
            this.numericUpDownNTab2.Location = new System.Drawing.Point(69, 9);
            this.numericUpDownNTab2.Name = "numericUpDownNTab2";
            this.numericUpDownNTab2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNTab2.TabIndex = 17;
            this.numericUpDownNTab2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "n";
            // 
            // buttonGenerateProblemTab2
            // 
            this.buttonGenerateProblemTab2.Location = new System.Drawing.Point(9, 64);
            this.buttonGenerateProblemTab2.Name = "buttonGenerateProblemTab2";
            this.buttonGenerateProblemTab2.Size = new System.Drawing.Size(180, 41);
            this.buttonGenerateProblemTab2.TabIndex = 15;
            this.buttonGenerateProblemTab2.Text = "Генерувати";
            this.buttonGenerateProblemTab2.UseVisualStyleBackColor = true;
            // 
            // radioButtonILPTab2
            // 
            this.radioButtonILPTab2.AutoSize = true;
            this.radioButtonILPTab2.Checked = true;
            this.radioButtonILPTab2.Location = new System.Drawing.Point(9, 112);
            this.radioButtonILPTab2.Name = "radioButtonILPTab2";
            this.radioButtonILPTab2.Size = new System.Drawing.Size(49, 17);
            this.radioButtonILPTab2.TabIndex = 25;
            this.radioButtonILPTab2.TabStop = true;
            this.radioButtonILPTab2.Text = "ЦЛП";
            this.radioButtonILPTab2.UseVisualStyleBackColor = true;
            // 
            // radioButtonBLPTab2
            // 
            this.radioButtonBLPTab2.AutoSize = true;
            this.radioButtonBLPTab2.Location = new System.Drawing.Point(9, 135);
            this.radioButtonBLPTab2.Name = "radioButtonBLPTab2";
            this.radioButtonBLPTab2.Size = new System.Drawing.Size(48, 17);
            this.radioButtonBLPTab2.TabIndex = 26;
            this.radioButtonBLPTab2.Text = "БЛП";
            this.radioButtonBLPTab2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 432);
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMTab2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNTab2)).EndInit();
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
        private System.Windows.Forms.Button buttonGenerateGridTab1;
        private System.Windows.Forms.DataGridView inputCGrid;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Button buttonSolveTab1;
        private System.Windows.Forms.ListBox listBoxResultTab1;
        private System.Windows.Forms.RadioButton radioButtonBLPTab2;
        private System.Windows.Forms.RadioButton radioButtonILPTab2;
        private System.Windows.Forms.ListBox listBoxResultTab2;
        private System.Windows.Forms.Button buttonStoreTab2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.NumericUpDown numericUpDownMTab2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownNTab2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonGenerateProblemTab2;
    }
}

