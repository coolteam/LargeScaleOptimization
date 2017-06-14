using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using LargeScaleOptimization.Algorithms;
using LpSolveDotNet;

namespace LargeScaleOptimization
{
    public partial class Form1 : Form
    {

        private long[,] _A;
        private long[] _B;
        private long[] _C;
        private long[] _X;
        private int _n;
        private int _m;
        private bool _isBLP;
        private Guid _dataSetNo;
        private OptimizationResult _lastResult;

        public Form1()
        {
            InitializeComponent();
        }

        private void ReduceVector_Click(object sender, EventArgs e)
        {
            var sg = new SimpleGenerator();
            sg.SetSize(20, 20);
            sg.Generate();
            var rva = new ReduceVectorIntegerAlgorithm();
            //ga.SetMax(-10);
            rva.SetMainInputData(sg.A, sg.B, sg.C, sg.X);
            var result = rva.CalcResult();
            richTextBox1.Text = rva.FormatResultAsString(result);
        }

        private void reduceVectorBoolButton_Click(object sender, EventArgs e)
        {
            var sg = new SimpleGenerator();
            sg.SetSize(20, 20);
            //sg.Generate();
            var rvba = new ReduceVectorBoolAlgorithm();
            //ga.SetMax(-10);
            //rvba.SetMainInputData(sg.A, sg.B, sg.C, sg.X);
            var result = rvba.CalcResult();
            richTextBox1.Text = rvba.FormatResultAsString(result);
        }

        private void buttonTestLPSolve_Click(object sender, EventArgs e)
        {
            var a = LpSolve.read_MPS("neos16.mps", 1);
            var n = a.get_Nrows();
            var m = a.get_Norig_columns();
            var c = a.get_rh(90);
            double[] test = new double[m + 1];
            for (var i = 0; i < n; ++i)
            {
                var en = a.get_rh(i);
                var es = a.get_row(i, test);
                if (a.get_rh(i) != 0)
                {

                    var d = a.get_rh(i);
                }
            }
            var sd = a.solve();
            var fs = a.get_objective();
            double[] x = new double[m];
            a.get_variables(x);
            a.set_outputfile("log.txt");
            a.print_scales();
        }

        private void BalashBoolButton_Click(object sender, EventArgs e)
        {
            var sg = new SimpleGenerator();
            sg.SetSize(20, 20);
            //sg.Generate();
            var bba = new BalashBoolAlgorithm();
            //ga.SetMax(-10);
            //rvba.SetMainInputData(sg.A, sg.B, sg.C, sg.X);
            var result = bba.CalcResult();
            richTextBox1.Text = bba.FormatResultAsString(result);
        }

        private int[] VectopPack(int[] a)
        {
            var n = a.Length;
            var result = new int[n/2];
            for (var i = 1; i <= n; i += 2)
            {
                var k = (i - 1)/2+1 ;
                result[k-1] = a[i-1] + a[i]*1000;
            }
            return result;
        }

        private void calcGomory_Click(object sender, EventArgs e)
        {
            var sg = new SimpleGenerator();
            sg.SetSize(15,15);
            sg.Generate();
            var ga = new GomoryIntegerAlgorithm();
            //ga.SetMax(-10);
            ga.SetMainInputData(sg.A, sg.B, sg.C, sg.X);
            var result = ga.CalcResult();
            richTextBox1.Text = ga.FormatResultAsString(result);
        }

        public void FormSetSize(int m, int n)
        {
            _n = n;
            _m = m;
            _A = new long[_m, _n];
            _B = new long[_m];
            _C = new long[_n];
            _X = new long[_n];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var str1 = Radius1();
            //var str2 = Radius2();
            //var str3 = Radius3();
            //richTextBox1.Text = "radius1" + Environment.NewLine + str1 + Environment.NewLine + "radius2" +
            //                    Environment.NewLine + str2 + "radius3" + Environment.NewLine + str3;
        }

        private string VectorToStr(int[] x)
        {
            return "("+ string.Join(",",x)+ "); ";
        }

        private void buttonGenerateGrid_Click(object sender, EventArgs e)
        {
            var n = (int) nSize.Value;
            var m = (int) mSize.Value;
            UiHelper.SetGridSettings(inputAGrid, inputCGrid, n, m);
        }

        private void buttonSolveTab1_Click(object sender, EventArgs e)
        {
            if (inputAGrid.ColumnCount == 0)
            {
                MessageBox.Show(@"Спочатку потрібно згенерувати потрібного розміру гріди та заповнити їх", @"Info");
            }
        }

        private void buttonStoreTab2_Click(object sender, EventArgs e)
        {
            _isBLP = radioButtonBLPTab2.Checked;
            int n = (int)numericUpDownNTab2.Value;
            int m = (int)numericUpDownMTab2.Value;
            FormSetSize(m, n);
            for (var i = 0; i < n; ++i)
            {
                for (var j = 0; j < m; ++j)
                {
                    _A[j, i] = long.Parse(inputAGridTab2[i*2, j].Value.ToString());
                }
                _C[i] = long.Parse(inputCGridTab2[i*2, 0].Value.ToString());
            }
            for (var j = 0; j < m; ++j)
            {
                _B[j] = long.Parse(inputAGridTab2[n*2 + 1, j].Value.ToString());
            }
        }

        private void buttonGenerateProblemTab2_Click(object sender, EventArgs e)
        {
            _dataSetNo = Guid.NewGuid();
            var isBLP = radioButtonBLPTab2.Checked;
            int n = (int)numericUpDownNTab2.Value;
            int m = (int)numericUpDownMTab2.Value;
            UiHelper.SetGridSettings(inputAGridTab2, inputCGridTab2, n, m);
            var sg = new SimpleGenerator();
            sg.SetSize(m,n);
            sg.Generate(isBLP);
            for (var i = 0; i < n; ++i)
            {
                for (var j = 0; j < m; ++j)
                {
                    inputAGridTab2[i*2, j].Value = sg.A[j, i];
                }
                inputCGridTab2[i*2, 0].Value = sg.C[i];
            }
            for (var j = 0; j < m; ++j)
            {
                inputAGridTab2[n*2+1, j].Value = sg.B[j];
            }
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((TabControl) sender).SelectedIndex == 4)
            {
                radioButtonBLPTab4.Checked = _isBLP;
                radioButtonILPTab4.Checked = !_isBLP;
                comboBoxAlgoTab4.Items.Clear();
                if (_isBLP)
                {
                    comboBoxAlgoTab4.Items.Add("Метод вектора спаду (БЛП)");
                    comboBoxAlgoTab4.Items.Add("Метод Балаша");
                }
                else
                {
                    comboBoxAlgoTab4.Items.Add("Метод вектора спаду (ЦЛП)");
                    comboBoxAlgoTab4.Items.Add("Метод Гоморі");
                }
                comboBoxAlgoTab4.SelectedIndex = -1;
                UiHelper.SetGridSettings(inputAGridTab4, inputCGridTab4, _n, _m);
                for (var i = 0; i < _n; ++i)
                {
                    for (var j = 0; j < _m; ++j)
                    {
                        inputAGridTab4[i * 2, j].Value = _A[j, i];
                    }
                    inputCGridTab4[i * 2, 0].Value = _C[i];
                }
                for (var j = 0; j < _m; ++j)
                {
                    inputAGridTab4[_n * 2 + 1, j].Value = _B[j];
                }
            }
        }

        private void buttonSolveTab4_Click(object sender, EventArgs e)
        {
            BaseAlgorithm algo = null;
            if ( _isBLP)
            {
                if (comboBoxAlgoTab4.SelectedIndex == 0)
                {
                    algo = new ReduceVectorBoolAlgorithm();
                }
                if (comboBoxAlgoTab4.SelectedIndex == 1)
                {
                    algo = new BalashBoolAlgorithm();
                }
            }
            else
            {
                if (comboBoxAlgoTab4.SelectedIndex == 0)
                {
                    algo = new ReduceVectorIntegerAlgorithm();
                }
                if (comboBoxAlgoTab4.SelectedIndex == 1)
                {
                    algo = new GomoryIntegerAlgorithm();
                }
            }
            if (algo == null)
            {
                MessageBox.Show(@"Select correct algorithm", @"info");
                return;
            }
            algo.SetMainInputData(_A, _B, _C, _X);
            var result = algo.CalcResult();
            richTextBoxResultTab4.Text = algo.FormatResultAsString(result);
            _lastResult = result;
        }

        private void buttonStoreTab4_Click(object sender, EventArgs e)
        {
            var line = string.Format("{0};{1};{2};{3};{4};{5};{6};{7}", _isBLP, comboBoxAlgoTab4.SelectedIndex, _m, _n,
                _lastResult.Min, _lastResult.TimeDiff, _lastResult.IterCount, _dataSetNo);
          
            using (StreamWriter sw = File.AppendText("Data.txt"))
            {
                sw.WriteLine(line);
            }
        }

        private void buttonAutoCalcTab5_Click(object sender, EventArgs e)
        {
            var maxS = 11;
            var rc = (int)numericUpDownRecalcNo.Value;
            for (var i = 2; i < maxS; ++i)
            {
                numericUpDownNTab2.Value = i;
                numericUpDownMTab2.Value = i;
                radioButtonBLPTab2.Checked = true;
                radioButtonBLPTab2.Checked = false;
                FormSetSize(i, i);
                for (var j = 0; j < rc; ++j)
                {
                    tabControl1.SelectTab(2);
                    buttonGenerateProblemTab2_Click(sender, e);
                    buttonStoreTab2_Click(sender, e);
                    tabControl1.SelectTab(4);
                    buttonGenerateProblemTab2_Click(tabControl1, e);
                    comboBoxAlgoTab4.SelectedIndex = 0;
                    buttonSolveTab4_Click(sender, e);
                    buttonStoreTab4_Click(sender, e);
                    comboBoxAlgoTab4.SelectedIndex = 1;
                    buttonSolveTab4_Click(sender, e);
                    buttonStoreTab4_Click(sender, e);
                }
            }
        }

        private void buttonBuild1Tab5_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines("Data.txt");
            var list = new System.Collections.Generic.List<ResultData>(lines.Length);
            foreach (var line in lines)
            {
                var row = line.Split(';');
                var rd = new ResultData()
                {
                    IsBLP = row[0]=="true",
                    Type = int.Parse(row[1]),
                    M = int.Parse(row[2]),
                    N= int.Parse(row[3]),
                    Value = long.Parse(row[4]),
                    TimeDiff = TimeSpan.Parse(row[5]),
                    IterCount = long.Parse(row[6]),
                    DataSetNo = Guid.Parse(row[7])
                };
                list.Add(rd);
            }
            var avg0 = list.Where(x => x.N == 10 && x.M == 10 && x.Type == 0).Average(x => x.TimeDiff.Ticks);
            var avg1 = list.Where(x => x.N == 10 && x.M == 10 && x.Type == 1).Average(x => x.TimeDiff.Ticks);
            var ts0 = TimeSpan.FromTicks((long)Math.Round(avg0));
            var ts1 = TimeSpan.FromTicks((long)Math.Round(avg1));
            var avgV0 = list.Where(x => x.N == 9 && x.M == 9 && x.Type == 0).Average(x => x.Value);
            var avgV1 = list.Where(x => x.N == 9 && x.M == 9 && x.Type == 1).Average(x => x.Value);
            var percent = (1 - Math.Abs(avgV0)/ Math.Abs(avgV1)) *100;
            chartTopTab5.Series["Series1"].Points.Clear();
            chartTopTab5.Series["Series2"].Points.Clear();
            chartTopTab5.Series["Series1"].LegendText = "БАМВС";
            chartTopTab5.Series["Series2"].LegendText = "Балаша";
            for (var i = 2; i < 11; ++i)
            {
                var ticks0 = list.Where(x => x.N == i && x.M == i && x.Type == 0).Average(x => x.TimeDiff.Ticks);
                var avgT0= TimeSpan.FromTicks((long)Math.Round(ticks0));
                chartTopTab5.Series["Series1"].Points.AddXY(i, avgT0.TotalMilliseconds);
                var ticks1 = list.Where(x => x.N == i && x.M == i && x.Type == 1).Average(x => x.TimeDiff.Ticks);
                var avgT1 = TimeSpan.FromTicks((long)Math.Round(ticks1));
                chartTopTab5.Series["Series2"].Points.AddXY(i,avgT1.TotalMilliseconds);
            }
            chartTopTab5.ChartAreas[0].AxisY.IsLogarithmic = true;
            chartTopTab5.ChartAreas[0].AxisX.IsLogarithmic = false;
            chartTopTab5.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }
    }

    public struct ResultData
    {
        public bool IsBLP;
        public int Type;
        public int M;
        public int N;
        public long Value;
        public TimeSpan TimeDiff;
        public long IterCount;
        public Guid DataSetNo;
    }
}
