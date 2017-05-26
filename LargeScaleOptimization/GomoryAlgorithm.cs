using System;

namespace LargeScaleOptimization
{
    public class GomoryAlgorithm
    {
        //public int[] X = { 0, 2 };
        //public int[] C = { -1, -2 };
        //public int[] B = { 2, 7 };
        //public int[,] A = { { -1, 1 }, { 3, -1 } };
        public int[] X = {0, 0,0};
        public int[] C = {-4, -5,-1};
        public int[] B = {10, 11, 13};
        public int[,] A = {{3, 2,0}, {1, 4,0}, {3, 3,1}};

        public void GenerateDataSet2()
        {
            var rnd = new Random();
            var n = 10;
            var m = 10;
            X = new int[n];
            A = new int[m, n];
            C = new int[n];
            B = new int[m];
            for (var i = 0; i < n; ++i)
            {
                X[i] = rnd.Next(0, 10);
                C[i] = rnd.Next(0, 2);
            }
            for (int j = 0; j < m; j++)
            {
                var sum = 0;
                for (int k = 0; k < n; k++)
                {
                    A[j, k] = rnd.Next(0, 10);
                    sum += A[j, k] * X[k];
                }
                B[j] = sum + rnd.Next(0, 15);
            }
            var sum1 = 0;
            for (var i = 0; i < n; ++i)
            {
                sum1 += X[i];
                X[i] = 0;
            }
            var f = sum1;
        }

        public long[] GenerateMatrixBarA()
        {
            GenerateDataSet2();
            var n0 = X.Length;
            var m0 = B.Length;
            var m = 2 + m0 + n0;
            var n = n0 + 1;
            var aValue = new long[m*n];
            var s = 1 + n0;
            for (int j = 0; j < m0; ++j)
            {
                aValue[s + j] = B[j];
            }
            s += m0 + 1;
            for (int i = 0; i < n0; ++i)
            {
                aValue[s + i*m] = C[i];
                aValue[s + i*m + 1 + i] = -1;
            }
            s+= 1 + n0;
            for (var j = 0; j < m0; ++j)
            {
                for (var i = 0; i < n0; ++i)
                {
                    aValue[s + i*m + j] = A[j, i];
                }
            }
            return aValue;
        }
        public unsafe long Test()
        {
            /* Initialized data */
            long[] aValue /* was [8][4] */ = new long[]
            {
                0, 0, 0, 0, 10, 11, 13, 0, -4, -1, 0, 0, 3, 1, 3, 0, -5, 0, -1, 0, 2, 4, 3, 0,
                -1, 0, 0, -1, 0, 0, 1, 0
            };
            aValue = GenerateMatrixBarA();
            //long aRef = aValue[0];
            //long* a = &aRef;
            long m = B.Length + X.Length + 2;
            long n = X.Length + 1;
            long max__ = -100;
            double eps = .001f;

            /* Local variables */
            long ierr;
            long[] mrValue = new long[2*B.Length+2*X.Length];
            //var mrRef = mrValue[0];
            //long* mr=&mrRef;
            var min = 0l;
            fixed (long* a = &(aValue[0]), mr = &(mrValue[0]))
            {
                mlc2r_c(a, &m, &n, mr, &max__, &eps, &ierr);
                for (var i = 0; i < X.Length; ++i)
                {
                    X[i] = (int) a[1 + i];
                }
                min = a[0];
                var x0 = a[(1)*8 + 1 - 9];
                var x1= a[(1) * 8 + 2 - 9];
                var x2 = a[(1) * 8 + 3 - 9];
                var x3 = a[(1) * 8 + 4 - 9];
            }
            
            return min;
        }

        private unsafe int mlc2r_c(long* a, long* m, long* n, long* mr, long* max__, double* eps, long* ierr)
        {
            /* System generated locals */
            long a_dim1, a_offset, i__1;
            /* Local variables */
            long iter, i__, j, k;
            double r__;
            long s, v, i1, k0, m1, n1, is0, is1, iai, ias;
            double rld;
            /* Parameter adjustments */
            a_dim1 = *m;
            a_offset = 1 + a_dim1*1;
            a -= a_offset;
            --mr;

            /* Function Body */
            is0 = 1;
            *ierr = 0;
            is1 = *n + 1;
            ias = is1 + *n;
            iai = ias + *m;
            iter = 0;
            m1 = *m - 1;
            n1 = *n - 1;
            i__1 = n1;
            for (i__ = 1; i__ <= i__1; ++i__)
            {
                mr[i__] = i__ + 1;
                /* L10: */
            }
            mlc25_c(&a[a_offset], &mr[is0], m, n, &n1, max__);
            L20:
            ++iter;
            i__1 = m1;
            for (i__ = 2; i__ <= i__1; ++i__)
            {
                if (a[(1)*a_dim1 + i__] < 0)
                {
                    goto L40;
                }
                /* L30: */
            }
            goto L100;
            /*     B CЛYЧAE YXOДA ПO METKE  - ИMEEM OПTИMAЛЬHOE */
            /*     ЦEЛOЧИCЛEHHOE PEШEHИE */
            L40:
            v = i__;
            /*     V-AЯ CTPOKA-ПPOИЗBOДЯЩA */
            mlc21_c(&a[a_offset], m, n, &mr[is0], &k, &v);
            if (k == 0)
            {
                goto L90;
            }
            if (k == 1)
            {
                goto L60;
            }
            k0 = k;
            i__1 = k;
            for (i__ = 1; i__ <= i__1; ++i__)
            {
                i1 = is1 + i__ - 1;
                mr[i1] = mr[i__];
                /* L50: */
            }
            mlc23_c(&a[a_offset], m, n, &mr[is0], &k, &s);
            mlc27_c(&a[a_offset], &mr[ias], &mr[iai], &mr[is1], m, n, &m1, &k0, &rld, &v, &s);
            goto L70;
            L60:
            s = mr[k];
            rld = (double) (-a[(s)*a_dim1 + v]);
            L70:
            i__1 = *n;
            for (j = 1; j <= i__1; ++j)
            {
                r__ = a[(j)*a_dim1 + v]/rld;
                mlc22_c(&r__, &a[(j)*a_dim1 + *m], eps);
                /* L80: */
            }
            /*     M1-AЯ CTPOKA-OTCEЧEHИE ГOMOPИ */
            mlc24_c(&a[a_offset], m, n, m, &s);
            goto L20;
            L90:
            *ierr = 65;
            L100:
            return 0;
        } /* mlc2r_c */

        private unsafe int mlc21_c(long* a, long* m, long* n, long* sel, long* k, long* iv)
        {
            /* System generated locals */
            long a_dim1, a_offset, i__1;

            /* Local variables */
            long j;

            /*     BЫБOP OTPИЦATEЛЬHЫX ЭЛEMEHTOB IV-OЙ CTPOKИ MATPИЦЫ A */
            /* Parameter adjustments */
            --sel;
            a_dim1 = *m;
            a_offset = 1 + a_dim1*1;
            a -= a_offset;

            /* Function Body */
            *k = 0;
            i__1 = *n;
            for (j = 2; j <= i__1; ++j)
            {
                if (a[(j)*a_dim1 + *iv] >= 0)
                {
                    goto L10;
                }
                ++(*k);
                sel[*k] = j;
                L10:
                ;
            }
            return 0;
        }

        private unsafe int mlc22_c(double* r__, long* jr, double* eps)
        {
            double delta;

            /*  BЫДEЛEHИE ЦEЛOЙ ЧACT */
            *jr = (long) *r__;
            delta = *jr - *r__;
            if (delta < 0d)
            {
                goto L20;
            }
            else if (delta == 0)
            {
                goto L30;
            }
            else
            {
                goto L10;
            }
            L10:
            if (delta < *eps)
            {
                goto L30;
            }
            --(*jr);
            goto L30;
            L20:
            if (delta + 1d > *eps)
            {
                goto L30;
            }
            ++(*jr);
            L30:
            return 0;
        } /* mlc22_c */

        private unsafe int mlc23_c(long* a, long* m, long* n, long* sel, long* k, long* s)
        {
            /* System generated locals */
            long a_dim1, a_offset, i__1, i__2;

            /* Local variables */
            long i__, j, l, k1, l1, min__;

            /*  OПPEДEЛEHИE HOMEPA BEДYЩEГO CTOЛБЦA */
            /* Parameter adjustments */
            a_dim1 = *m;
            a_offset = 1 + a_dim1*1;
            a -= a_offset;
            --sel;

            /* Function Body */
            i__1 = *m;
            for (i__ = 1; i__ <= i__1; ++i__)
            {
                l = sel[1];
                min__ = a[(l)*a_dim1 + i__];
                i__2 = *k;
                for (j = 2; j <= i__2; ++j)
                {
                    l1 = sel[j];
                    if (a[(l1)*a_dim1 + i__] - min__ >= 0)
                    {
                        goto L20;
                    }
                    else
                    {
                        goto L10;
                    }
                    L10:
                    min__ = a[(l1)*a_dim1 + i__];
                    L20:
                    ;
                }
                k1 = 0;
                i__2 = *k;
                for (j = 1; j <= i__2; ++j)
                {
                    l1 = sel[j];
                    if (a[(l1)*a_dim1 + i__] != min__)
                    {
                        goto L30;
                    }
                    ++k1;
                    sel[k1] = l1;
                    L30:
                    ;
                }
                if (k1 == 1)
                {
                    goto L50;
                }
                *k = k1;
                /* L40: */
            }
            L50:
            *s = sel[1];
            return 0;
        } /* mlc23_c */

        private unsafe int mlc24_c(long* a, long* m, long* n, long* v, long* s)
        {
            /* System generated locals */
            long a_dim1, a_offset, i__1, i__2;

            /* Local variables */
            long i__, j;

            /*  ИTEPAЦИЯ ДBOЙCTBEHHOГO CИMПЛEKCMETOДA */
            /* Parameter adjustments */
            a_dim1 = *m;
            a_offset = 1 + a_dim1*1;
            a -= a_offset;

            /* Function Body */
            i__1 = *n;
            for (j = 1; j <= i__1; ++j)
            {
                if (j == *s)
                {
                    goto L20;
                }
                i__2 = *m;
                for (i__ = 1; i__ <= i__2; ++i__)
                {
                    a[(j)*a_dim1 + i__] = a[(j)*a_dim1 + i__] -
                                          a[(j)*a_dim1 + *v]*a[(*s)*a_dim1 + i__]/a[(*s)*a_dim1 + *v];
                    /* L10: */
                }
                L20:
                ;
            }
            i__1 = *m;
            for (i__ = 1; i__ <= i__1; ++i__)
            {
                a[(*s)*a_dim1 + i__] = -a[(*s)*a_dim1 + i__]/a[(*s)*a_dim1 + *v];
                /* L30: */
            }
            return 0;
        } /* mlc24_c */

        private unsafe int mlc25_c(long* a, long* sel, long* m, long* n, long* n1, long* max__)
        {
            /* System generated locals */
            long a_dim1, a_offset, i__1;

            /* Local variables */
            long j, js;

            /*  ПEPEXOД K ДBOЙCTBEHHO-ДOПYCTИMOЙ TAБЛИЦE */
            /* Parameter adjustments */
            a_dim1 = *m;
            a_offset = 1 + a_dim1*1;
            a -= a_offset;
            --sel;

            /* Function Body */
            i__1 = *n;
            for (j = 2; j <= i__1; ++j)
            {
                if (a[(j)*a_dim1 + 1] < 0)
                {
                    goto L20;
                }
                /* L10: */
            }
            goto L40;
            L20:
            mlc23_c(&a[a_offset], m, n, &sel[1], n1, &js);
            i__1 = *n;
            for (j = 2; j <= i__1; ++j)
            {
                a[(j)*a_dim1 + *m] = 1;
                /* L30: */
            }
            a[(1)*a_dim1 + *m] = *max__;
            mlc24_c(&a[a_offset], m, n, m, &js);
            L40:
            return 0;
        } /* mlc25_c */

        private unsafe int mlc26_c(long* a, long* b, long* m, long* mu)
        {
            /* System generated locals */
            long i__1;

            /* Local variables */
            long i__;
            double eps, rmu;

/*  BЫЧИCЛEHИE MU */
            /* Parameter adjustments */
            --b;
            --a;

            /* Function Body */
            eps = 1e-10f;
            i__1 = *m;
            for (i__ = 1; i__ <= i__1; ++i__)
            {
                if (a[i__] != 0)
                {
                    goto L20;
                }
                if (b[i__] != 0)
                {
                    goto L90;
                }
/* L10: */
            }
            goto L90;
            L20:
            rmu = (double) (b[i__]/a[i__]);
            mlc22_c(&rmu, mu, &eps);
            if (*mu == 1)
            {
                goto L100;
            }
            if (*mu*a[i__] != b[i__])
            {
                goto L100;
            }
            L30:
            ++i__;
            if (i__ > *m)
            {
                goto L100;
            }
            if ((i__1 = a[i__]) < 0)
            {
                goto L40;
            }
            else if (i__1 == 0)
            {
                goto L70;
            }
            else
            {
                goto L80;
            }
            L40:
            if (b[i__] >= 0)
            {
                goto L100;
            }
            L50:
            if ((i__1 = a[i__]**mu - b[i__]) < 0)
            {
                goto L100;
            }
            else if (i__1 == 0)
            {
                goto L30;
            }
            else
            {
                goto L60;
            }
            L60:
            --(*mu);
            goto L100;
            L70:
            if ((i__1 = b[i__]) < 0)
            {
                goto L60;
            }
            else if (i__1 == 0)
            {
                goto L30;
            }
            else
            {
                goto L100;
            }
            L80:
            if (b[i__] <= 0)
            {
                goto L60;
            }
            goto L50;
            L90:
            *mu = 0;
            L100:
            return 0;
        } /* mlc26_c */

        private unsafe int mlc27_c(long* a, long* as0, long* ai,
            long* sel, long* m, long* n, long* m1, long* k,
            double* rld, long* v, long* s)
        {
            /* System generated locals */
            long a_dim1, a_offset, i__1;

            /* Local variables */
            long i__, l, il, mu;
            double rmu, rld1;

            /*  BЫЧИCЛEHИE ЛAMБДA */
            /* Parameter adjustments */
            a_dim1 = *m;
            a_offset = 1 + a_dim1*1;
            a -= a_offset;
            --ai;
            --as0;
            --sel;

            /* Function Body */
            i__1 = *m1;
            for (i__ = 1; i__ <= i__1; ++i__)
            {
                as0[i__] = a[(*s) * a_dim1 + i__];
                /* L10: */
            }
            *rld = 0d;
            i__ = 0;
            L20:
            ++i__;
            if (i__ > *k)
            {
                goto L60;
            }
            l = sel[i__];
            if (l == *s)
            {
                goto L40;
            }
            i__1 = *m1;
            for (il = 1; il <= i__1; ++il)
            {
                ai[il] = a[(l) * a_dim1 + il];
/* L30: */
            }
            mlc26_c(&as0[1], &ai[1], m1, &mu);
            if (mu == 0)
            {
                goto L20;
            }
            rmu = (double) mu;
            rld1 = -a[(l) * a_dim1 + *v]/rmu;
            goto L50;
            L40:
            rld1 = (double) (-a[(l) * a_dim1 + *v]);
            L50:
            if (rld1 < *rld)
            {
                goto L20;
            }
            *rld = rld1;
            goto L20;
            L60:
            return 0;
        } /* mlc27_c */
    }
}