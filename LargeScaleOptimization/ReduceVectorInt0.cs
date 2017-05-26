using System;
using System.Collections.Generic;
using System.Linq;

namespace LargeScaleOptimization
{
    public class ReduceVectorInt
    {
        public int[] X = {0, 0, 0};
        public int[] C = {-4, -5, -1};
        public int[] B = {10, 11, 13};
        public int[,] A = {{3, 2, 0}, {1, 4, 0}, {3, 3, 1}};
        public int Min = int.MaxValue;

        public void GenerateDataSet()
        {
            var rnd = new Random();
            var n = 4;
            var m = 3;
            X = new int[n];
            A = new int[m,n];
            C = new int[n];
            B = new int[m];
            for (var i = 0; i < n; ++i)
            {
                X[i] = 0;
                C[i] = rnd.Next(-10, 10);
                
                for (int j = 0; j < m; ++j)
                {
                    A[j,i]= rnd.Next(-10, 10);
                }
            }
            for (int j = 0; j < m; ++j)
            {
                B[j] = (int) Math.Round(rnd.NextDouble()*1.5*n + 0.9*n);
            }
        }

        public int GetMinBy3Algo(out string desc)
        {
            desc = "-----START-----" + Environment.NewLine;
            var r = 2;
            var h = 0;
            var delta = int.MaxValue;
            var checkedList = new List<int[]>();
            var dict = new Dictionary<int[], int>();
            while (delta >= 0)
            {
                A:
                ++h;
                
                var x = new int[X.Length];
                for (var j0 = 0; j0 < C.Length; ++j0)
                {
                    for (var p0 = -r; p0 <= r; ++p0)
                    {
                        for (var j = 0; j < C.Length; ++j)
                        {
                            for (var p = -r; p <= r; ++p)
                            {
                                Array.Copy(X, x, X.Length);
                                x[j0] = X[j0] + p0;
                                x[j] = X[j] + p;
                                //if (checkedList.Contains(x))
                                //{
                                //    continue;
                                //}
                                //var tmp = new int[x.Length];
                                //Array.Copy(x,tmp,x.Length);
                                //checkedList.Add(tmp);
                                desc += string.Format("({0},{1},{2}); ", x[0], x[1],x[2]);
                                if (x[j0] < 0 || x[j] < 0)
                                {
                                    continue;
                                }
                                var otherPoint = false;
                                if (p == 0||p0==0)
                                {
                                    for (int i = 0; i < X.Length; ++i)
                                    {
                                        if (x[i] != X[i])
                                        {
                                            otherPoint = true;
                                            break;
                                        }
                                    }
                                    if (!otherPoint)
                                    {
                                        continue;
                                    }
                                }


                                var allow = true;
                                for (var k = 0; k < A.GetLength(0); ++k)
                                {
                                    var sum = 0;
                                    for (var l = 0; l < A.GetLength(1); ++l)
                                    {
                                        sum += A[k, l]*x[l];
                                    }
                                    if (sum > B[k])
                                    {
                                        allow = false;
                                        break;
                                    }
                                }
                                if (allow)
                                {
                                    var sum = 0;
                                    for (int i = 0; i < X.Length; ++i)
                                    {
                                        sum += C[i]*(x[i]-X[i]);
                                    }
                                    if (sum < 0)
                                    {
                                        var contains = false;
                                        foreach (var intse in checkedList)
                                        {
                                            var eq = !x.Where((t, i) => t != intse[i]).Any();
                                            if (eq)
                                            {
                                                contains = true;
                                                break;
                                            }
                                        }
                                        if (contains)
                                        {
                                            continue;
                                        }
                                        var tmp = new int[x.Length];
                                        Array.Copy(x, tmp, x.Length);
                                        checkedList.Add(tmp);
                                        var sol = new int[x.Length];
                                        Array.Copy(x,sol,x.Length);
                                        dict.Add(sol,sum);

                                        //Array.Copy(x, X, X.Length);
                                        //desc = desc.Substring(0, desc.Length - 2);
                                        //var b = string.Empty;
                                        //foreach (var el in x)
                                        //{
                                        //    b += el + ",";
                                        //}
                                        //b = b.Substring(0, b.Length - 1);
                                        //desc += string.Format("-----({0})-----", b) + Environment.NewLine; ;
                                        //goto A;
                                    }
                                }
                            }
                        }
                    }
                }
                
                if (dict.Values.Count == 0)
                {
                    break;
                }
                var min = dict.Values.Min();
                var sss = dict.Aggregate((left, right) => left.Value < right.Value ? left : right).Key;
                Array.Copy(sss, X, X.Length);
                dict.Clear();
                checkedList.Clear();
                goto A;
            }
            desc += Environment.NewLine+"-----FINISH-----";
            var f = 0;
            for (var i = 0; i < X.Length; ++i)
            {
                f += C[i] * X[i];
            }
            return f;
        }

        public string ResultToString()
        {
            return string.Join(",", X);
        }
    }
}
