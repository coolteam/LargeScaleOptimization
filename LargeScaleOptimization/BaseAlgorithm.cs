namespace LargeScaleOptimization
{
    public abstract class BaseAlgorithm
    {
        public long[] X = {0, 0, 0};
        public long[] C = {-4, -5, -1};
        public long[] B = {10, 11, 13};
        public long[,] A = {{3, 2, 0}, {1, 4, 0}, {3, 3, 1}};

        public void SetMainInputData()
        {
        }

        public void SetAdditionalInputData()
        {
        }

        public virtual OptimizationResult CalcResult()
        {
            return new OptimizationResult();
        }
    }

    public struct OptimizationResult
    {
        private long[] X;
        private long Min;
    }
}
