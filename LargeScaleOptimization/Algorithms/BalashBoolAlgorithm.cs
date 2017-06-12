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
            double[] bValue = {2d, 2d, 2d, 2d, -1d, -1d, -1d, -1d};
            double[] cValue = {1d, 1d, 1d, 1d, 1d, 1d};
            int[] ncValue = {4, 4, 4, 4, 4, 4};
            double[] aValue =
            {
                1d, 1d, -1d, -1d, 1d, 1d, -1d, -1d, 1d, 1d, -1d,
                -1d, 1d, 1d, -1d, -1d, 1d, 1d, -1d, -1d, 1d, 1d, -1d, -1d
            };
            int[] naValue = {1, 2, 5, 6, 1, 3, 5, 7, 2, 3, 6, 7, 1, 4, 5, 8, 2, 4, 6, 8, 3, 4, 7, 8};
            A = new long[,]
            {
                {1, 1, 0, 1, 0, 0}, 
                {1, 0, 1, 0, 1, 0}, 
                {0, 1, 1, 0, 0, 1}, 
                {0, 0, 0, 1, 1, 1}, 
                {-1, -1, 0, -1, 0, 0}, 
                {-1, 0, -1, 0, -1, 0},
                {0, -1, -1, 0, 0, -1}, 
                {0, 0, 0, -1, -1, -1}
            };
            var na2 = CreateNA(A);
            var nc2 = CreateNC(A);
            var a2 = CreateA(A);
            long[] xsValue = {0};

            /* System generated locals */
            long i__1;
            /* Local variables */
            long i__, k, m, n, s, ip;
            long[] xValue = new long[1];
            double z__,zs,eps;
            double[] yValue = new double[8];
            long[] nxValue = new long[6];
            long[] nyValue = new long[8];
            double[] difValue = new double[8];

            long ierr = 0, min = 0;
            m = 8;
            n = 6;
            s = 0;
            eps = 1e-5d;
            fixed (long* x = &(xValue[0]), xs = &(xsValue[0]), ny = &(nyValue[0]), nx = &(nxValue[0]))
            {
                fixed (double* a = &(aValue[0]), b = &(bValue[0]), c = &(cValue[0]), y = &(yValue[0]),
                    dif = &(difValue[0]))
                {
                    fixed (int* na = &(naValue[0]), nc = &(ncValue[0]))
                    {
                        mnr3r_c(x, xs, a, na, b, c, nc, &m, &n, y, &z__, &zs, &s, ny, nx, dif, &eps);

                        X = new long[nxValue.Length];
                        k = 0;
                        i__1 = n;
                        for (i__ = 1; i__ <= i__1; ++i__)
                        {
                            utmn13_c(&i__, x, &ip);
                            X[i__-1] = ip;
                            if (ip == 0)
                            {
                                goto L2;
                            }
                            ++k;
                            nx[k - 1] = i__;
                            L2:
                            ;
                        }

                        min = (long) z__;
                    }
                }
            }

            var result = new OptimizationResult
            {
                X = X,
                Min = min,
                ResultCode = (CalculationResult) ierr
            };
            return result;
        }

        private long[] CreateA(long[,] matrixA)
        {
            var a = new List<long>();
            var n = matrixA.GetLength(1);
            var m = matrixA.GetLength(0);
            for (var i = 0; i < n; ++i)
            {
                for (var j = 0; j < m; ++j)
                {
                    if (matrixA[j, i] != 0)
                        a.Add(matrixA[j, i]);
                }
            }
            return a.ToArray();
        }

        private int[] CreateNA(long [,] matrixA)
        {
            var na = new List<int>();
            var n = matrixA.GetLength(1);
            var m = matrixA.GetLength(0);
            for (var i = 0; i < n; ++i)
            {
                for (var j = 0; j < m; ++j)
                {
                    if (matrixA[j, i] != 0)
                        na.Add(j + 1);
                }
            }
            return na.ToArray();
        }

        private int[] CreateNC(long[,] matrixA)
        {
            var nc = new List<int>();
            var n = matrixA.GetLength(1);
            var m = matrixA.GetLength(0);
            for (var i = 0; i < n; ++i)
            {
                var count = 0;
                for (var j = 0; j < m; ++j)
                {
                    if (matrixA[j, i] != 0)
                        ++count;
                }
                nc.Add(count);
            }
            return nc.ToArray();
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

        private unsafe int mnr3l_c(long* js, long* s, long* xs)
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
                utmn12_c(&j1, &xs[1]);
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
            utmn12_c(&j1, &xs[1]);
            js[*s] = -(js[*s] + cofz);
            goto L4;
            L3:
            js[*s] = -(js[*s] - cofz);
            utmn11_c(&j1, &xs[1]);
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

        private unsafe int mnr3o_c(long* js, long* s, double* dif, long* iy,
            long* ns, long* ny, long* in0, double* a, int* na,
            double* c__, int* nc, long* n, long* xs, long* pr, double* eps)
        {
            /* System generated locals */
            long i__1, i__2;
            double r__1;

            /* Local variables */
            double d__;
            long i__, j, k, l;
            long i1, j1, l1, la, pr1, pr2;

            /*  ПEPBAЯ ПOПЫTKA PACШИPEHИЯ ЧACTИЧHOГO */
            /*  PEШEH */
            /* Parameter adjustments */
            --js;
            --dif;
            --ns;
            --a;
            --na;
            --nc;
            --c__;
            --ny;
            --xs;

            /* Function Body */
            l = 1;
            j1 = 1;
            *pr = 0;
            i__1 = *n;
            for (j = 1; j <= i__1; ++j)
            {
                k = nc[j];
                if (ns[j1] > j)
                {
                    goto L10;
                }
                i1 = 1;
                la = l;
                pr1 = 0;
                pr2 = 0;
                i__2 = k;
                for (i__ = 1; i__ <= i__2; ++i__)
                {
                    l1 = na[la];
                    L1:
                    if (ny[i1] > l1)
                    {
                        goto L4;
                    }
                    if (ny[i1] < l1)
                    {
                        goto L3;
                    }
                    r__1 = a[la];
                    d__ = dif[i1] - (Math.Abs(r__1));
                    if (d__ >= *eps)
                    {
                        goto L3;
                    }
                    if (a[la] < 0d)
                    {
                        goto L2;
                    }
                    pr2 = 1;
                    goto L3;
                    L2:
                    pr1 = 1;
                    L3:
                    ++i1;
                    if (i1 > *iy)
                    {
                        goto L5;
                    }
                    goto L1;
                    L4:
                    ++la;
                }
                L5:
                if (pr1 == 1 && pr2 == 0)
                {
                    goto L6;
                }
                if (pr1 == 0 && pr2 == 1)
                {
                    goto L7;
                }
                goto L9;
                L6:
                utmn11_c(&j, &xs[1]);
                ++(*s);
                js[*s] = j;
                *pr = 1;
                goto L12;
                L7:
                utmn12_c(&j, &xs[1]);
                ++(*s);
                js[*s] = -j;
/* L8: */
                *pr = 1;
                L9:
                ++j1;
                if (j1 > *in0)
                {
                    goto L12;
                }
                L10:
                l += k;
/* L11: */
            }
            L12:
            return 0;
        }

        private unsafe int mnr3r_c(long* x, long* xs, double* a, int* na, double* b,
            double* c__, int* nc, long* m, long* n, double* y, double* z__,
            double* zs, long* s, long* ny, long* nx, double* dif, double* eps)
        {
            /* Initialized data */

            double z1 = 1e5d;

            /* System generated locals */
            long i__1;

            /* Local variables */

            long i__;

            long k, s1, in0, ns, iy, pr, lx;

/*  BAPИAHT METOДA БAЛAШA C KOMПAKTHЫM */
/*  XPAHEHИEM ИCXOДHOЙ ИHФOPMA */
            /* Parameter adjustments */
            --x;
            --xs;
            --a;
            --na;
            --dif;
            --ny;
            --y;
            --b;
            --nx;
            --nc;
            --c__;

            /* Function Body */
            lx = (*n + 31)/32;
            *z__ = z1;
            if (*s != 0)
            {
                goto L2;
            }
            i__1 = *m;
            for (i__ = 1; i__ <= i__1; ++i__)
            {
/* L1: */
                y[i__] = b[i__];
            }
            goto L3;
            L2:
            mnr3y_c(&y[1], m, &a[1], &na[1], &b[1], &c__[1], &nc[1], n, &xs[1]);
            L3:
            mnr3m_c(&y[1], m, &ny[1], &iy, eps);
            s1 = *s;
            if (*s != 0)
            {
                goto L4;
            }
            *zs = 0d;
            goto L5;
            L4:
            mnr3z_c(zs, &c__[1], n, &xs[1]);
            L5:
            if (iy == 0)
            {
                goto L8;
            }
            ns = *s + 1;
            mnr3n_c(&nx[1], s, zs, z__, &c__[1], n, &nx[ns], &in0);
            if (in0 == 0)
            {
                goto L10;
            }
            mnr3d_c(&y[1], m, &ny[1], &iy, &a[1], &na[1], &c__[1], &nc[1], n, &dif[1],
                &nx[ns], &in0);
            i__1 = iy;
            for (i__ = 1; i__ <= i__1; ++i__)
            {
                if (dif[i__] < -(*eps))
                {
                    goto L10;
                }
/* L6: */
            }
            mnr3o_c(&nx[1], s, &dif[1], &iy, &nx[ns], &ny[1], &in0, &a[1], &na[1],
                &c__[1], &nc[1], n, &xs[1], &pr, eps);
            if (pr == 1)
            {
                goto L7;
            }
            mnr3t_c(&nx[1], s, &y[1], m, &nx[ns], &in0, &a[1], &na[1], &c__[1], &nc[1],
                n, &xs[1], &pr, eps);
            L7:
            mnr3c_c(&nx[1], &s1, s, &y[1], m, &a[1], &na[1], &c__[1], &nc[1], n);
            goto L3;
            L8:
            if (*zs >= *z__)
            {
                goto L10;
            }
            *z__ = *zs;
            k = 0;
            i__1 = lx;
            for (i__ = 1; i__ <= i__1; ++i__)
            {
                x[i__] = xs[i__];
                k += 32;
                if (k >= *n)
                {
                    goto L10;
                }
/* L9: */
            }
            L10:
            s1 = *s;
            mnr3l_c(&nx[1], s, &xs[1]);
            if (*s == 0)
            {
                goto L11;
            }
            goto L7;
            L11:
            return 0;
        }

        private unsafe int mnr3t_c(long* js, long* s, double* y, long* m,
            long* ns, long* in0, double* a, int* na, double* c__,
            int* nc, long* n, long* x, long* pr, double* eps)
        {
            /* System generated locals */
            long i__1, i__2;

            /* Local variables */
            long jmax, i__, j, k, l;
            double r__;
            long j1, l1;
            double r1;
            long la;
            double ze, max__;

/*  BTOPAЯ ПOПЫTKA PACШИPEHИЯ ЧACTИЧHOГO */
/*  PEШEH */
            /* Parameter adjustments */
            --js;
            --y;
            --ns;
            --a;
            --na;
            --nc;
            --c__;
            --x;

            /* Function Body */
            ze = -(*eps);
            l = 1;
            j1 = 1;
            max__ = -1e4f;
            i__1 = *n;
            for (j = 1; j <= i__1; ++j)
            {
                k = nc[j];
                if (ns[j1] > j)
                {
                    goto L5;
                }
                r__ = 0d;
                la = l;
                i__2 = k;
                for (i__ = 1; i__ <= i__2; ++i__)
                {
                    l1 = na[la];
                    r1 = y[l1] - a[la];
                    if (r1 < ze && y[l1] < ze)
                    {
                        r__ -= a[la];
                    }
                    if (r1 < ze && y[l1] > ze)
                    {
                        r__ += r1;
                    }
                    if (r1 >= ze && y[l1] < ze)
                    {
                        r__ -= y[l1];
                    }
/* L1: */
                    ++la;
                }
                if (r__ < max__)
                {
                    goto L2;
                }
                max__ = r__;
                jmax = j;
                L2:
                ++j1;
                if (j1 > *in0)
                {
                    goto L4;
                }
                L5:
                l += k;
/* L3: */
            }
            L4:
            utmn11_c(&jmax, &x[1]);
            ++(*s);
            js[*s] = jmax;
            return 0;
        }

        private unsafe int mnr3y_c(double* y, long* m, double* a, int* na,
            double* b, double* c__, int* nc, long* n, long* xs)
        {
            /* System generated locals */
            long i__1, i__2;

            /* Local variables */
            long i__, j, k, l;
            long l1, la;

/*  BЫЧИCЛEHИE HEBЯЗOK B MACCИBE Y */
            /* Parameter adjustments */
            --b;
            --y;
            --a;
            --na;
            --nc;
            --c__;
            --xs;

            /* Function Body */
            i__1 = *m;
            for (i__ = 1; i__ <= i__1; ++i__)
            {
/* L1: */
                y[i__] = b[i__];
            }
            la = 0;
            i__1 = *n;
            for (j = 1; j <= i__1; ++j)
            {
                l = nc[j];
                utmn13_c(&j, &xs[1], &k);
                if (k == 0)
                {
                    goto L3;
                }
                i__2 = l;
                for (i__ = 1; i__ <= i__2; ++i__)
                {
                    ++la;
                    l1 = na[la];
/* L2: */
                    y[l1] -= a[la];
                }
                goto L4;
                L3:
                la += l;
                L4:
                ;
            }
            return 0;
        }

        private unsafe int mnr3z_c(double* zs, double* c__, long* n, long* xs)
        {
            /* System generated locals */
            long i__1;

            /* Local variables */
            long j, k;

/*  BЫЧИCЛEHИE ZS */
            /* Parameter adjustments */
            --c__;
            --xs;

            /* Function Body */
            *zs = 0d;
            i__1 = *n;
            for (j = 1; j <= i__1; ++j)
            {
                utmn13_c(&j, &xs[1], &k);
                if (k == 0)
                {
                    goto L1;
                }
                *zs += c__[j];
                L1:
                ;
            }
            return 0;
        }

        private unsafe int utmn11_c(long* j, long* sh) //possible bug
            // Записываем 1 в позицию J битовой шкалы SH
        {
            long n, shs;
            shs = 8*sizeof (long);
            n = (*j - 1);
            int m = (int) (n%shs);
            sh[n/shs] |= (1L << m);
            return 0;
        }

        private unsafe int utmn12_c(long* j, long* sh) //possible bug
            // Записываем 0 в позицию J битовой шкалы SH
        {
            long n, shs;
            shs = 8*sizeof (long);
            n = (*j - 1);
            int m = (int) (n%shs);
            sh[n/shs] &= ~(1L << m);
            return 0;
        }

        private unsafe int utmn13_c(long* j, long* sh, long* pr)
            // Переменной PR присваиваем значение бита в позиции J шкалы SH
        {
            long n, shs;
            shs = 8*sizeof (long);
            n = (*j - 1);
            int m = (int) (n%shs);
            if ((sh[n/shs] & (1L << m))!=0)//todo test
            {
                *pr = 1;
            }
            else
            {
                *pr = 0;
            }
            return 0;
        }
    }
}
