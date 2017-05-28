using System;
using System.Windows.Forms;
using LargeScaleOptimization.Algorithms;

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

        unsafe int print_result_code(int* ierr, int* nom)
        {
            var a = ("\n   UTMLCP *********\n");
            a+=string.Format("\n IERR = %3i {0},   NOM = %3i {1}\n", *ierr, *nom);
            richTextBox1.Text = a;
            return 0;
        } /* print_result_code */

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

        private int MainAlgo(int[] a, int[]b,int[]c,int n, int m,int q,double[] up, ref int resultCode, ref int[] x)
        {

            return 0;
        }

        private void calcGomory_Click(object sender, EventArgs e)
        {
            var sg = new SimpleGenerator();
            sg.SetSize(20,20);
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
    }
}
