using System;
using LargeScaleOptimization.Enum;

namespace LargeScaleOptimization.Algorithms
{
    public abstract class BaseAlgorithm
    {
        /* Integer test data set*/
        //public long[,] A = { { 3, 2, 0 }, { 1, 4, 0 }, { 3, 3, 1 } };
        //public long[] B = { 10, 11, 13 };
        //public long[] C = { -4, -5, -1 };
        //public long[] X = { 0, 0, 0 };

        /* Bool (RVM) test data set*/
        //public long[,] A = {{1, 1, 1, 1}, {1, 1, 1, 1}};
        //public long[] B = {2, 4};
        //public long[] C = {-1, -2, -3, -4};
        //public long[] X = {0, 0, 0, 0};

        /* Bool (Balash) test data set*/
        public long[,] A =
        {
            {1, 1, 0, 1, 0, 0},
            {1, 0, 1, 0, 2, 0},
            {0, 1, 1, 0, 0, 1},
            {0, 0, 0, 1, 1, 1},
            {-1, -1, 0, -1, 0, 0},
            {-1, 0, -1, 0, -1, 0},
            {0, -1, -1, 0, 0, -1},
            {0, 0, 0, -1, -1, -1}
        };
        public long[] B = {2, 2, 2, 2, -1, -1, -1, -1};
        public long[] C = {1, 1, 1, 1, 1, 1};
        public long[] X = {0, 0, 0, 0, 0, 0};

        public void SetMainInputData(long[,] a, long[] b, long[] c, long[] x)
        {
            A = a;
            B = b;
            C = c;
            X = x;
        }

        public virtual OptimizationResult CalcResult()
        {
            return new OptimizationResult();
        }

        public string FormatResultAsString(OptimizationResult optimizationResult)
        {
            var result = optimizationResult.ResultCode.ToString();
            if (optimizationResult.ResultCode != CalculationResult.FeasibleSolutionNotFound)
            {
                result += Environment.NewLine + "Max: " + optimizationResult.Min;
                result += Environment.NewLine + "Solution: " + string.Join(",", optimizationResult.X);
            }
            return result;
        }
    }

    public struct OptimizationResult
    {
        public long[] X;
        public long Min;
        public CalculationResult ResultCode;
    }
}
