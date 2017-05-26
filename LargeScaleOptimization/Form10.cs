using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LargeScaleOptimization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            var a1 = new[] {1, 1, 2, 1, 1, 1, 2, 1, 1, 1, 2, 1, 1, 1, 2, 1};
            var c1 = new[] {2, -1, 2, -2, 2, -3, 2, -4};
            var b = new[] {2, 4};
            var n = 4;
            var m = 2;
            var q = 1;
            var x = new[] {0, 0, 0, 0};
            var up = new[] {600d, 1d};
            int resultCode = -1;
            var a = VectopPack(a1);
            var c = VectopPack(c1);
            var min = MainAlgo(a, b, c, n, m, q, up, ref resultCode, ref x);
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

        private int MainAlgo(int[] a, int[]b,int[]c,int n, int m,int q,double[] up, ref int resultCode, ref int[] x)
        {

            return 0;
        }

        private void calcBattonInt_Click(object sender, EventArgs e)
        {
            var rvi = new ReduceVectorInt();
            var a = string.Empty;
            rvi.GenerateDataSet();
            var min = rvi.GetMinBy3Algo(out a);
            richTextBox1.Text = min + Environment.NewLine + rvi.ResultToString();
            richTextBox1.Text += Environment.NewLine + a;
        }
    }
}
