using System;
using System.Collections.Generic;
using System.Linq;
using LargeScaleOptimization.Enum;

namespace LargeScaleOptimization.Algorithms
{
    public class ReduceVectorIntegerAlgorithm:BaseAlgorithm
    {
        public override OptimizationResult CalcResult()
        {
            var h = 0;
            var needContinue = true;
            var n = X.Length;
            var dict = new Dictionary<long[], long>();
            while (needContinue)
            {
                var tmpX = GetFeasibleSolution1(ref dict);
                if (tmpX == null)
                {
                    tmpX = GetFeasibleSolution2(ref dict);
                }
                if (tmpX == null)
                {
                    tmpX = GetFeasibleSolution3(ref dict);
                }
                if (tmpX != null)
                {
                    Array.Copy(tmpX, X, n);
                }
                else
                {
                    needContinue = false;
                }
                dict.Clear();
            }
            var sum = 0l;
            for (var i = 0; i < n; ++i)
            {
                sum += C[i]*X[i];
            }
            return new OptimizationResult {Min = sum, X = X, ResultCode = CalculationResult.OptimalSolutionFound};
        }

        public long[] GetFeasibleSolution1(ref  Dictionary<long[], long> dict)
        {
            var n = X.Length;
            var m = B.Length;
            var x = new long[n];
            Array.Copy(X,x,n);
            var r = 1l;
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
                    if (SatisfyPositive(x,n) && SatisfyRestriction(x,n, m))
                    {
                        var delta = GetDelta(x);
                        if (delta < 0)
                        {
                            var tmp = new long[n];
                            Array.Copy(x, tmp, n);
                            dict.Add(tmp, delta);
                        }
                    }
                    //str += VectorToStr(x);
                    x[i] -= p1;
                }
            }
            if (dict.Count == 0)
            {
                return null;
            }
            var max = dict.Values.Min();
            foreach (var el in dict)
            {
                if (el.Value == max)
                {
                    return el.Key;
                }
            }
            
            return null;
        }

        public long[] GetFeasibleSolution2(ref Dictionary<long[], long> dict)
        {
            var n = X.Length;
            var m = B.Length;
            var x = new long[n];
            Array.Copy(X, x, n);
            const int r = 2;
            var str = string.Empty;
            var p1Arr = new[] { -r, r };
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
                    if (SatisfyPositive(x, n) && SatisfyRestriction(x, n, m))
                    {
                        var delta = GetDelta(x);
                        if (delta < 0)
                        {
                            var tmp = new long[n];
                            Array.Copy(x, tmp, n);
                            dict.Add(tmp, delta);
                        }
                    }
                    //str += VectorToStr(x);
                    x[i] -= p1Arr[p];
                }
                for (var j = i + 1; j < n; ++j)
                {
                    for (var p = 0; p < p2Arr.Length; ++p)
                    {
                        x[i] += p2Arr[p][0];
                        x[j] += p2Arr[p][1];
                        if (SatisfyPositive(x, n) && SatisfyRestriction(x, n, m))
                        {
                            var delta = GetDelta(x);
                            if (delta < 0)
                            {
                                var tmp = new long[n];
                                Array.Copy(x, tmp, n);
                                dict.Add(tmp, delta);
                            }
                        }
                        //str += VectorToStr(x);
                        x[i] -= p2Arr[p][0];
                        x[j] -= p2Arr[p][1];
                    }
                }
            }
            if (dict.Count == 0)
            {
                return null;
            }
            var max = dict.Values.Min();
            foreach (var el in dict)
            {
                if (el.Value == max)
                {
                    return el.Key;
                }
            }
            return null;
        }

        public long[] GetFeasibleSolution3(ref Dictionary<long[], long> dict)
        {
            var n = X.Length;
            var m = B.Length;
            var x = new long[n];
            Array.Copy(X, x, n);
            const long r = 3L;
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
                    if (SatisfyPositive(x, n) && SatisfyRestriction(x, n, m))
                    {
                        var delta = GetDelta(x);
                        if (delta < 0)
                        {
                            var tmp = new long[n];
                            Array.Copy(x, tmp, n);
                            dict.Add(tmp, delta);
                        }
                    }
                    //str += VectorToStr(x);
                    x[i] -= p;
                }
                for (var j = i + 1; j < n; ++j)
                {
                    for (var p = 0; p < p2Arr.Length; ++p)
                    {
                        x[i] += p2Arr[p][0];
                        x[j] += p2Arr[p][1];
                        if (SatisfyPositive(x, n) && SatisfyRestriction(x, n, m))
                        {
                            var delta = GetDelta(x);
                            if (delta < 0)
                            {
                                var tmp = new long[n];
                                Array.Copy(x, tmp, n);
                                dict.Add(tmp, delta);
                            }
                        }
                        //str += VectorToStr(x);
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
                            if (SatisfyPositive(x, n) && SatisfyRestriction(x, n, m))
                            {
                                var delta = GetDelta(x);
                                if (delta < 0)
                                {
                                    var tmp = new long[n];
                                    Array.Copy(x, tmp, n);
                                    dict.Add(tmp, delta);
                                }
                            }
                            //str += VectorToStr(x);
                            x[i] -= p3Arr[p][0];
                            x[j] -= p3Arr[p][1];
                            x[k] -= p3Arr[p][2];
                        }
                    }
                    //str += Environment.NewLine;
                }
                //str += Environment.NewLine;
            }
            if (dict.Count == 0)
            {
                return null;
            }
            var max = dict.Values.Min();
            foreach (var el in dict)
            {
                if (el.Value == max)
                {
                    return el.Key;
                }
            }
            return null;
        }

        private bool SatisfyPositive(long[]x,int n)
        {
            for (var i = 0; i < n; ++i)
            {
                if (x[i] < 0)
                {
                    return false;
                }
            }
            return true;
        }

        private bool SatisfyRestriction(long[]x,int n, int m)
        {
            for (var j = 0; j < m; ++j)
            {
                var sum = 0L;
                for (var i = 0; i < n; ++i)
                {
                    sum += A[j, i]*x[i];
                }
                if (sum > B[j])
                {
                    return false;
                }
            }
            return true;
        }

        private long GetDelta(long[] x)
        {
            var sum = 0L;
            for (var i = 0; i < x.Length; i++)
            {
                sum += C[i]*(x[i] - X[i]);
            }
            return sum;
        }

        public long GetMinBy3Algo(out string desc)
        {
            desc = "-----START-----" + Environment.NewLine;
            var r = 2;
            var h = 0;
            var delta = int.MaxValue;
            var checkedList = new List<int[]>();
            var dict = new Dictionary<long[], long>();
            while (delta >= 0)
            {
                A:
                ++h;
                
                var x = new long[X.Length];
                for (var j0 = 0; j0 < C.Length; ++j0)
                {
                    for (var p0 = -r; p0 <= r; ++p0)
                    {
                        for (var j = j0; j < C.Length; ++j)
                        {
                            for (var p = -r; p <= r; ++p)
                            {
                                if (Math.Abs(p0) + Math.Abs(p) > r || (p0 == 0 && p == 0))
                                {
                                    continue;
                                }
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

                                //desc += string.Format("({0},{1},{2}); ", x[0], x[1],x[2]);
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
                                    var sum = 0l;
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
                                    var sum = 0l;
                                    for (long i = 0; i < X.Length; ++i)
                                    {
                                        sum += C[i]*(x[i]-X[i]);
                                    }
                                    if (sum < 0)
                                    {
                                        //var contains = false;
                                        //foreach (var intse in checkedList)
                                        //{
                                        //    var eq = !x.Where((t, i) => t != intse[i]).Any();
                                        //    if (eq)
                                        //    {
                                        //        contains = true;
                                        //        break;
                                        //    }
                                        //}
                                        //if (contains)
                                        //{
                                        //    continue;
                                        //}
                                        //var tmp = new int[x.Length];
                                        //Array.Copy(x, tmp, x.Length);
                                        //checkedList.Add(tmp);
                                        var sol = new long[x.Length];
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
            var f = 0l;
            for (var i = 0; i < X.Length; ++i)
            {
                f += C[i] * X[i];
            }
            return f;
        }
    }
}
