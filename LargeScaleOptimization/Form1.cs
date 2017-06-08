using System;
using System.Windows.Forms;
using LargeScaleOptimization.Algorithms;
using LpSolveDotNet;

namespace LargeScaleOptimization
{
    public partial class Form1 : Form
    {
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

        private void button1_Click(object sender, EventArgs e)
        {
            var str1 = Radius1();
            var str2 = Radius2();
            var str3 = Radius3();
            richTextBox1.Text = "radius1" + Environment.NewLine + str1 + Environment.NewLine + "radius2" +
                                Environment.NewLine + str2 + "radius3" + Environment.NewLine + str3;
        }

        private string Radius1()
        {
            var X = new int[] {0, 0, 0, 0, 0};
            var n = X.Length;
            var x = new int[n];
            var r = 1;
            var str = string.Empty;
            for (var i = 0; i < n; ++i)
            {
                for (var p1 = -r; p1 <= r; ++p1)
                {
                    if (p1 == 0)
                    {
                        continue;
                    }
                    x[i] += p1;
                    //CalcDelta(x, X);
                    str += VectorToStr(x);
                    x[i] -= p1;
                }
            }
            return str;
        }

        private string Radius2()
        {
            var X = new int[] {0, 0, 0, 0, 0};
            var n = X.Length;
            var x = new int[n];
            const int r = 2;
            var str = string.Empty;
            var p1Arr = new[] {-r, r};
            var p2Arr = new[]
            {
                new[] {-r + 1, -r + 1},
                new[] {-r + 1, r - 1},
                new[] {r - 1, -r + 1},
                new[] {r - 1, r - 1}
            };
            for (var i = 0; i < n; ++i)
            {
                for (var p = 0; p < p1Arr.Length; ++p)
                {
                    x[i] += p1Arr[p];
                    //todo calc
                    str += VectorToStr(x);
                    x[i] -= p1Arr[p];
                }
                for (var j = i + 1; j < n; ++j)
                {
                    for (var p = 0; p < p2Arr.Length; ++p)
                    {
                        x[i] += p2Arr[p][0];
                        x[j] += p2Arr[p][1];
                        //todo calc
                        str += VectorToStr(x);
                        x[i] -= p2Arr[p][0];
                        x[j] -= p2Arr[p][1];
                    }
                }
            }
            return str;
        }

        private string Radius3()
        {
            var X = new int[] { 0, 0, 0, 0, 0 };
            var n = X.Length;
            var x = new int[n];
            const int r = 3;
            var str = string.Empty;
            var p1Arr = new[] { -r, r };
            var p2Arr = new[]
            {
                new[] {-r + 1, -r + 2},
                new[] {-r + 1, r - 2},
                new[] {-r + 2, -r + 1},
                new[] {-r + 2, r - 1},
                new[] {r - 1, -r + 2},
                new[] {r - 1, r - 2},
                new[] {r - 2, -r + 1},
                new[] {r - 2, r - 1},
            };
            var p3Arr = new[]
            {
                new[] {-r + 2, -r + 2, -r + 2},
                new[] {-r + 2, -r + 2, r - 2},
                new[] {-r + 2, r - 2, -r + 2},
                new[] {-r + 2, r - 2, r - 2},
                new[] {r - 2, -r + 2, -r + 2},
                new[] {r - 2, -r + 2, r - 2},
                new[] {r - 2, r - 2, -r + 2},
                new[] {r - 2, r - 2, r - 2},
            };
            for (var i = 0; i < n; ++i)
            {
                for (var p = 0; p < p1Arr.Length; ++p)
                {
                    x[i] += p;
                    //todo calc
                    str += VectorToStr(x);
                    x[i] -= p;
                }
                for (var j = i + 1; j < n; ++j)
                {
                    for (var p = 0; p < p2Arr.Length; ++p)
                    {
                        x[i] += p2Arr[p][0];
                        x[j] += p2Arr[p][1];
                        //todo calc
                        str += VectorToStr(x);
                        x[i] -= p2Arr[p][0];
                        x[j] -= p2Arr[p][1];
                    }
                    for (var k = j + 1; k < n; ++k)
                    {
                        for (var p = 0; p < p3Arr.Length; ++p)
                        {
                            x[i] += p3Arr[p][0];
                            x[j] += p3Arr[p][1];
                            x[k] += p3Arr[p][2];
                            //todo calc
                            str += VectorToStr(x);
                            x[i] -= p3Arr[p][0];
                            x[j] -= p3Arr[p][1];
                            x[k] -= p3Arr[p][2];
                        }
                    }
                    //str += Environment.NewLine;
                }
                //str += Environment.NewLine;
            }
            return str;
        }

        private string VectorToStr(int[] x)
        {
            return "("+ string.Join(",",x)+ "); ";
        }

        private void buttonGenerateGrid_Click(object sender, EventArgs e)
        {
            var n = (int) nSize.Value;
            var m = (int)mSize.Value;
            inputAGrid.ColumnCount = 2*n + 2;
            inputAGrid.RowCount = m;
            inputCGrid.RowCount = 1;
            inputCGrid.ColumnCount = 2*n + 2;
            for (var i = 0; i < 2*n; i += 2)
            {
                inputAGrid.Columns[i ].ReadOnly = false;
                inputAGrid.Columns[i + 1].ReadOnly = true;
                inputAGrid[i, 0].Value = 0;
                inputAGrid[i+1, 0].Value = "x" + (i/2+1);
            }
            inputAGrid.Columns[2*n].ReadOnly = true;
            inputAGrid[2*n, 0].Value = "<=";
            inputAGrid[2*n + 1, 0].Value = 0;
        }
    }
}
