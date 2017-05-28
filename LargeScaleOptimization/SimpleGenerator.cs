﻿using System;

namespace LargeScaleOptimization
{
    public class SimpleGenerator
    {
        public long[,] A = { { 3, 2, 0 }, { 1, 4, 0 }, { 3, 3, 1 } };
        public long[] B = { 10, 11, 13 };
        public long[] C = { -4, -5, -1 };
        public long[] X = { 0, 0, 0 };

        private int _n;
        private int _m;
        private Random _rand;

        public void SetSize(int m, int n)
        {
            _n = n;
            _m = m;
            A = new long[_m, _n];
            B = new long[_m];
            C = new long[_n];
            X = new long[_n];
        }

        public void Generate()
        {
            X = new long[_n];
            A = new long[_m, _n];
            C = new long[_n];
            B = new long[_m];
            for (var i = 0; i < _n; ++i)
            {
                X[i] = _rand.Next(0, 10);
                C[i] = _rand.Next(-2, 0);
            }
            for (long j = 0; j < _m; j++)
            {
                var sum = 0l;
                for (long k = 0; k < _n; k++)
                {
                    A[j, k] = _rand.Next(0, 10);
                    sum += A[j, k]*X[k];
                }
                B[j] = sum + _rand.Next(0, 15);
            }
            var sum1 = 0l;
            for (var i = 0; i < _n; ++i)
            {
                sum1 += X[i];
                X[i] = 0;
            }
            var f = sum1;
        }
    }
}