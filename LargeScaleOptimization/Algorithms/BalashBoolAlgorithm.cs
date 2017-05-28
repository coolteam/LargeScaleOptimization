using System;
using System.Collections.Generic;
using LargeScaleOptimization.Enum;

namespace LargeScaleOptimization.Algorithms
{
    public class BalashBoolAlgorithm : BaseAlgorithm
    {

        public override unsafe OptimizationResult CalcResult()
        {
            /* Initialized data */
            long[] a1Value = {1, 1};
            long[] c1Value = {1, 1};
            long n = 4;
            long m = 2;
            long q = 1;
            double[] upValue = {600d, 1d};

            /* Local variables */
            long ierr=0, min=0;
            long a1Length = a1Value.Length;
            long c1Length = c1Value.Length;
            long[] aValue = new long[a1Length/2];
            long[] cValue = new long[c1Length/2];
            long[] pValue = new long[X.Length];
            double time = 0d;
            fixed (long* a1 = &(a1Value[0]), a = &(aValue[0]), c1 = &(c1Value[0]), c = &(cValue[0]), b = &(B[0]),
                p = &(pValue[0]), x = &(X[0]))
            {
                fixed (double* up = &(upValue[0]))
                {
                    //utmlci_c(a1, &a1Length, a);
                    //utmlci_c(c1, &c1Length, c);
                    //mlc6r_c(a, b, c, &ierr, &m, &min, &n, p, &q, up, x);
                }
            }

            var result = new OptimizationResult
            {
                X = X,
                Min = min,
                ResultCode = (CalculationResult) ierr
            };
            var t = upValue[0];
            return result;
        }


        private unsafe int mnr3c_c(long* js, long* s, long* s1, double* y, long* m, double* a, int* na, double* c__,
            int* nc, long* n)
        {
            long cofz = 32000;

            /* System generated locals */
            long i__1, i__2;

            /* Local variables */
            long i__, j, k, l, i1, j1, ds, st;

            /*  KOPPEKTИPOBKA HEBЯЗOK Y(M) */
            /* Parameter adjustments */
            --js;
            --y;
            --a;
            --na;
            --nc;
            --c__;

            /* Function Body */
            ds = 1;
            if (*s1 <= *s)
            {
                ds = -1;
            }
            st = *s;
            if (ds == 1)
            {
                ++st;
            }
            L1:
            j1 = js[st];
            if (j1 < 0 && ds == 1)
            {
                goto L5;
            }
            if (j1 < 0 && st != *s1)
            {
                goto L6;
            }
            if (j1 > 0 && st == *s1)
            {
                ds = 1;
            }
            j1 = Math.Abs(j1);
            l = 1;
            i__1 = *n;
            for (j = 1; j <= i__1; ++j)
            {
                k = nc[j];
                if (j1 > cofz)
                {
                    j1 -= cofz;
                }
                if (j1 != j)
                {
                    goto L3;
                }
                i__2 = k;
                for (i__ = 1; i__ <= i__2; ++i__)
                {
                    i1 = na[l];
                    y[i1] -= ds*a[l];
                    /* L2: */
                    ++l;
                }
                goto L4;
                L3:
                l += k;
                L4:
                ;
            }
            L5:
            if (st == *s1)
            {
                goto L7;
            }
            L6:
            st += ds;
            goto L1;
            L7:
            return 0;
        }

        private unsafe int mnr3d_c(double* y, long* m, long* ny, long* iy,
            double* a, int* na, double* c__, int* nc, long* n, double* dif,
            long* ns, long* in0)
        {
            /* System generated locals */
            long i__1, i__2;

            /* Local variables */
            long i__, j, k, l, i1, j1, l1, la;

            /*  BЫЧИCЛEHИE ЭЛEMEHTOB DIF */
            /* Parameter adjustments */
            --dif;
            --y;
            --ny;
            --a;
            --na;
            --nc;
            --c__;
            --ns;

            /* Function Body */
            i__1 = *iy;
            for (i__ = 1; i__ <= i__1; ++i__)
            {
                i1 = ny[i__];
                /* L1: */
                dif[i__] = y[i1];
            }
            j1 = 1;
            l = 1;
            i__1 = *n;
            for (j = 1; j <= i__1; ++j)
            {
                i1 = 1;
                k = nc[j];
                if (ns[j1] > j)
                {
                    goto L6;
                }
                la = l;
                i__2 = k;
                for (i__ = 1; i__ <= i__2; ++i__)
                {
                    l1 = na[la];
                    L2:
                    if (ny[i1] > l1)
                    {
                        goto L4;
                    }
                    if (ny[i1] < l1)
                    {
                        goto L3;
                    }
                    if (a[la] > 0d)
                    {
                        goto L4;
                    }
                    dif[i1] -= a[la];
                    goto L3;
                    L3:
                    ++i1;
                    if (i1 > *iy)
                    {
                        goto L5;
                    }
                    goto L2;
                    L4:
                    ++la;
                }
                L5:
                ++j1;
                if (j1 > *in0)
                {
                    goto L8;
                }
                L6:
                l += k;
                /* L7: */
            }
            L8:
            return 0;
        }

        private unsafe int mnr3l_c(long* js, long* s, double* xs)
        {
            /* Initialized data */

            long cofz = 32000;

            /* System generated locals */
            long i__1;

            /* Local variables */
            long k;
            long j1, k1;

/*  YMEHЬШEHИE ЧACTИЧHOГO PEШEH */
            /* Parameter adjustments */
            --js;
            --xs;

            /* Function Body */
            i__1 = *s;
            for (k = 1; k <= i__1; ++k)
            {
                k1 = *s - k + 1;
                j1 = js[k1];
                if (Math.Abs(j1) < cofz)
                {
                    goto L2;
                }
                if (j1 < 0)
                {
                    goto L1;
                }
                j1 -= cofz;
//                utmn12_c(&j1, &xs[1]);
                L1:
                ;
            }
            *s = 0;
            goto L4;
            L2:
            *s = k1;
            if (js[*s] < 0)
            {
                goto L3;
            }
//            utmn12_c(&j1, &xs[1]);
            js[*s] = -(js[*s] + cofz);
            goto L4;
            L3:
            js[*s] = -(js[*s] - cofz);
//            utmn11_c(&j1, &xs[1]);
            L4:
            return 0;
        }

        private unsafe int mnr3m_c(double* y, long* m, long* ny, long* iy, double* eps)
        {
            /* System generated locals */
            long i__1;

            /* Local variables */
            long i__;

            /*  ФOPMИPOBAHИE HOMEPOB OTPИЦATEЛЬHЫX */
            /*  HEBЯЗOK */
            /* Parameter adjustments */
            --ny;
            --y;

            /* Function Body */
            *iy = 0;
            i__1 = *m;
            for (i__ = 1; i__ <= i__1; ++i__)
            {
                if (y[i__] >= -(*eps))
                {
                    goto L1;
                }
                ++(*iy);
                ny[*iy] = i__;
                L1:
                ;
            }
            return 0;
        }

        private unsafe int mnr3n_c(long* js, long* s, double* zs, double* z__,
            double* c__, long* n, long* ns, long* in0)
        {
            /* Initialized data */

            long cofz = 32000;

            /* System generated locals */
            long i__1, i__2;

            /* Local variables */
            long j, k, j1;

            /*  ФOPMИPOBAHИE MHOЖECTBA YЛYЧШAЮЩИX */
            /*     KOMПOHEHT */
            /* Parameter adjustments */
            --c__;
            --js;
            --ns;

            /* Function Body */
            *in0 = 0;
            i__1 = *n;
            for (j = 1; j <= i__1; ++j)
            {
                if (*s == 0)
                {
                    goto L2;
                }
                i__2 = *s;
                for (j1 = 1; j1 <= i__2; ++j1)
                {
                    k = js[j1];
                    if (k < 0)
                    {
                        k = -k;
                    }
                    if (k > cofz)
                    {
                        k -= cofz;
                    }
                    if (k == j)
                    {
                        goto L3;
                    }
                    /* L1: */
                }
                L2:
                if (*zs + c__[j] >= *z__)
                {
                    goto L3;
                }
                ++(*in0);
                ns[*in0] = j;
                L3:
                ;
            }
            return 0;
        }
    }
}
