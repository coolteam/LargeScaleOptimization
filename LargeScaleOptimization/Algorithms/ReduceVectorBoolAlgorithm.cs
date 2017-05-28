using System;
using System.Collections.Generic;
using LargeScaleOptimization.Enum;

namespace LargeScaleOptimization.Algorithms
{
    public class ReduceVectorBoolAlgorithm : BaseAlgorithm
    {
        private long timeStamp;

        public override unsafe OptimizationResult CalcResult()
        {
            /* Initialized data */
            long[] a1Value = ConvertA();
            long[] c1Value = ConvertC();
            long n = 4;
            long m = 2;
            long q = 1;
            double[] upValue = {600d, 1d};

            /* Local variables */
            long ierr,min;
            long a1Length = a1Value.Length;
            long c1Length = c1Value.Length;
            long[] aValue = new long[a1Length / 2];
            long[] cValue = new long[c1Length / 2];
            long[] pValue = new long[X.Length];
            double time = 0d;
            fixed (long* a1 = &(a1Value[0]), a = &(aValue[0]), c1 = &(c1Value[0]), c = &(cValue[0]), b = &(B[0]),
                p = &(pValue[0]), x = &(X[0]))
            {
                fixed (double* up = &(upValue[0]))
                {
                    utmlci_c(a1, &a1Length, a);
                    utmlci_c(c1, &c1Length, c);
                    mlc6r_c(a, b, c, &ierr, &m, &min, &n, p, &q, up, x);
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

        private long[] ConvertA()
        {
            var n = X.Length;
            var m = B.Length;
            var aList = new List<long>();
            for (var i = 0; i < n; ++i)
            {
                for (var j = 0; j < m; ++j)
                {
                    if (A[j, i] != 0)
                    {
                        aList.Add(j+1);
                        aList.Add(A[j,i]);
                    }
                }
            }
            return aList.ToArray();
        }

        private long[] ConvertC()
        {
            var n = X.Length;
            var m = B.Length;
            var cArray = new long[n*2];
            var cIndex = 0;
            for (var i = 0; i < n; ++i)
            {
                var sum = 0L;
                for (var j = 0; j < m; ++j)
                {
                    sum += A[j, i] != 0 ? 1 : 0;
                }
                cArray[cIndex] = sum;
                cArray[cIndex+1] = C[i];
                cIndex += 2;
            }
            return cArray;
        }

        private unsafe int mlc6r_c(long* a, long* b, long* c__, long* ierr, long* m, long* min__, long* n, long* p,
            long* q, double* up, long* x)
        {
            /* System generated locals */
            long i__1, i__2, i__3;

            /* Local variables */
            double tmax;
            long i__, l, s;
            long t;
            long i1, i2, i3, n1, n2;
            long i21, i31;
            long del, del1, del2;

            /* Parameter adjustments */
            --a;
            --p;
            --b;
            --x;
            --c__;
            --up;

            /* Function Body */
            tmax = up[1];
            /* -------ЗAПOMHИM HAЧAЛЬHOE BPEMЯ:                                 */
            timeStamp = DateTime.Now.Second;
            /* ---------ПOИCK ДOПYCTИMOЙ TOЧKИ:                                 */
            mlc6r0_c(&a[1], &b[1], &c__[1], ierr, m, n, &p[1], q, &x[1]);
            /*         PRINT 179,IERR,X                                         */
            /* 179      FORMAT(2X,'IERR=',I4,'X=',4I4)                          */
            if (*ierr == 0)
            {
                goto L10;
            }
            if (up[2] == 1d)
            {
                //utmlcp_c(ierr, &c__1);
            }
            goto L160;
            /* ---------------ИЩEM ЛYЧШYЮ TOЧKY B OKPECTHOCTИ PAДИYCA 1         */
            L10:
            /*          PRINT 178,X                                             */
            /* 178       FORMAT(2X,'ЛYЧШAЯ TOЧKA  ',20I4)                       */
            /*                PRINT 199                                         */
            /* 199          FORMAT(2X,'ИЩEM ЛYЧШYЮ TOЧKY B OKPECTHOCTИ R=1')    */
            /* ---------ПPOBEPKA,HE ИCTEKЛO ЛИ BPEMЯ ----                       */
            t = DateTime.Now.Second;
            t -= timeStamp;
            if (t < tmax)
            {
                goto L20;
            }
            *ierr = 5;
            goto L140;
            L20:
            i__1 = *n;
            for (i1 = 1; i1 <= i__1; ++i1)
            {
                mlc6r5_c(&del, &x[1], &c__[1], &i1);
                if (del >= 0)
                {
                    goto L40;
                }
                /* -------------YБЫBAHИE ECTЬ, ПPOBEPИM OГPAHИЧEHИЯ:                */
                x[i1] = 1 - x[i1];
                mlc6r1_c(&a[1], &b[1], &c__[1], m, n, &p[1], &x[1]);
                mlc6r2_c(m, &p[1], q, &s);
                if (s > 0)
                {
                    goto L30;
                }
                /* -----------------ПOЛYЧEHA ЛYЧШAЯ TOЧKA                           */
                goto L10;
                L30:
                x[i1] = 1 - x[i1];
                goto L40;
                L40:
                ;
            }
            /* ---------ПPOBEPKA,HE ИCTEKЛO ЛИ BPEMЯ ----                       */
            t = DateTime.Now.Second;
            t -= timeStamp;
            if (t < tmax)
            {
                goto L50;
            }
            *ierr = 5;
            goto L140;
            L50:
            /* ПPOДOЛЖИM ПOИCK ЛYЧШEЙ TOЧKИ B OKPECTHOCTИ PAДИYCA 2             */
            /*         PRINT 197                                                */
            /* 197    FORMAT(2X,'ИЩEM ЛYЧШYЮ TOЧKY B OKPECTHOCTИ PAДИYCA 2')    */
            n1 = *n - 1;
            i__1 = n1;
            for (i1 = 1; i1 <= i__1; ++i1)
            {
                i21 = i1 + 1;
                mlc6r5_c(&del1, &x[1], &c__[1], &i1);
                x[i1] = 1 - x[i1];
                i__2 = *n;
                for (i2 = i21; i2 <= i__2; ++i2)
                {
                    /*        PRINT 333,I1,I2,X                                         */
                    /* 333     FORMAT(2X,'I1=',I3,'I2=',I3,'X=',10I3)                   */
                    mlc6r5_c(&del, &x[1], &c__[1], &i2);
                    /*           PRINT 334,DEL1,DEL                                     */
                    /* 334       FORMAT(2X,'DEL1=',I3,'DEL=',I3)                        */
                    del += del1;
                    if (del >= 0)
                    {
                        goto L70;
                    }
                    /*  ----------- YБЫBAHИE ECTЬ,ПPOBEPИM OГPAHИЧEHИЯ:                 */
                    x[i2] = 1 - x[i2];
                    /*            PRINT 335,X                                           */
                    /* 335         FORMAT(2X,'X=',10I4)                                 */
                    mlc6r1_c(&a[1], &b[1], &c__[1], m, n, &p[1], &x[1]);
                    /*         PRINT 218,P                                              */
                    mlc6r2_c(m, &p[1], q, &s);
                    /*         PRINT 216,S                                              */
                    if (s > 0)
                    {
                        goto L60;
                    }
                    /*  -----------------ПOЛYЧEHA ЛYЧШAЯ TOЧKA                          */
                    goto L10;
                    L60:
                    x[i2] = 1 - x[i2];
                    L70:
                    ;
                }
                x[i1] = 1 - x[i1];
                /* L80: */
            }
            /* ----ПPOДOЛЖAEM ПOИCK ЛYЧШEЙ TOЧKИ B OKPECTHOCTИ PAДИYCA 3        */
            /*       PRINT 196                                                  */
            /* 196  FORMAT(2X,'ИЩEM ЛYЧШYЮ TOЧKY B OKPECTHOCTИ PAДИYCA 3')      */
            n2 = *n - 2;
            i__1 = n2;
            for (i1 = 1; i1 <= i__1; ++i1)
            {
                i21 = i1 + 1;
                /* ---------ПPOBEPKA,HE ИCTEKЛO ЛИ BPEMЯ ----                       */
                t = DateTime.Now.Second;
                t -= timeStamp;
                if (t < tmax)
                {
                    goto L90;
                }
                *ierr = 5;
                goto L140;
                L90:
                mlc6r5_c(&del1, &x[1], &c__[1], &i1);
                /* ------- ЗAФИKCИPYEM KOMПOHEHTY X(I1):                            */
                x[i1] = 1 - x[i1];
                i__2 = n1;
                for (i2 = i21; i2 <= i__2; ++i2)
                {
                    mlc6r5_c(&del2, &x[1], &c__[1], &i2);
                    del2 = del1 + del2;
                    /* -------ЗAФИKCИPYEM KOMПOHEHTY X(I2):                             */
                    x[i2] = 1 - x[i2];
                    i31 = i2 + 1;
                    i__3 = *n;
                    for (i3 = i31; i3 <= i__3; ++i3)
                    {
                        /*              PRINT 213,I3,X,DEL2                                 */
                        /* 213       FORMAT(2X,'I3=',I4,'X=',4I4,'DEL2=',I4)                */
                        mlc6r5_c(&del, &x[1], &c__[1], &i3);
                        del += del2;
                        if (del >= 0)
                        {
                            goto L110;
                        }
                        /* ------------------YБЫBAHИE ECTЬ,ПPOBEPKA OГPAHИЧEHИЙ             */
                        x[i3] = 1 - x[i3];
                        mlc6r1_c(&a[1], &b[1], &c__[1], m, n, &p[1], &x[1]);
                        /*            PRINT 218,P                                           */
                        /* 218        FORMAT(2X,'P=',3I4)                                   */
                        mlc6r2_c(m, &p[1], q, &s);
                        /*      PRINT 216,S                                                 */
                        /* 216   FORMAT(2X,'S=',I4)                                         */
                        if (s > 0)
                        {
                            goto L100;
                        }
                        /* ------------------ПOЛYЧEHA ЛYЧШAЯ TOЧKA:                         */
                        goto L10;
                        L100:
                        x[i3] = 1 - x[i3];
                        L110:
                        ;
                    }
                    /* -------------BOCCTAHOBИM KOMПOHEHTY I2:                          */
                    x[i2] = 1 - x[i2];
                    /* L120: */
                }
                x[i1] = 1 - x[i1];
                /* L130: */
            }
            L140:
            *min__ = 0;
            i__1 = *n;
            for (i__ = 1; i__ <= i__1; ++i__)
            {
                l = c__[i__];
                utmlcj_c(&l, &i1);
                *min__ += x[i__]*l;
                /* L150: */
            }
            if (up[2] != 1d)
            {
                goto L160;
            }
            //utmlcp_c(ierr, &c__1);
            L160:
            /*    BPEMЯ,ЗATPAЧEHHOE HA PEШEHИE ЗAДAЧИ:                          */
            t = DateTime.Now.Second;
            t -= timeStamp;
            up[1] = (double) t;
            return 0;
        }

        private unsafe int mlc6r0_c(long* a, long* b, long* c__, long* ierr, long* m, long* n, long* p, long* q, long* x)
        {
            /* System generated locals */
            long i__1;

            /* Local variables */
            long j, s;
            long sv, sum;
            /* ПOИCK ДOПYCTИMOЙ TOЧKИ                                     */
            /* PACCMATPИBAETCЯ OKPECTHOCTЬ HAЧAЛЬHOЙ TOЧKИ PAДИYCA 1      */
            /*  IERR - ПPИЗHAK BЫXOДA ИЗ ПOДПPOГPAMMЫ:                    */
            /*          IERR=0 - HAЙДEHA ДOПYCTИMAЯ TOЧKA;                */
            /*          IERR= 65 -ДOПYCTИMAЯ TOЧKA HE HAЙДEHA             */
            /* Parameter adjustments */
            --a;
            --p;
            --b;
            --x;
            --c__;

            /* Function Body */
            mlc6r1_c(&a[1], &b[1], &c__[1], m, n, &p[1], &x[1]);
            /* BЫЧИCЛEHИE HEBЯЗKИ P                                       */
            mlc6r2_c(m, &p[1], q, &s);
            if (s <= 0)
            {
                goto L30;
            }
            L10:
            sv = s;
            i__1 = *n;
            for (j = 1; j <= i__1; ++j)
            {
                mlc6r3_c(&a[1], &c__[1], &p[1], &x[1], &j);
                /* ИЗMEHEHИE KOMПOHEHTЫ X(J) HA 1-X(J)                        */
                /* И KOPPEKTИPOBKA BEKTOPA P                                  */
                mlc6r2_c(m, &p[1], q, &sum);
                mlc6r4_c(&sum, &s, &a[1], &c__[1], &p[1], &x[1], &j);
                /* ECЛИ SUM<STO S=SUM                                         */
                /* ИHAЧE BOЗBPAЩAEMCЯ B ИCXOД.TOЧKY                           */
                if (s <= 0)
                {
                    goto L30;
                }
                /* L20: */
            }
            if (sv != s)
            {
                goto L10;
            }
            *ierr = 65;
            goto L40;
            L30:
            *ierr = 0;
            L40:
            return 0;
        }

        private unsafe int mlc6r1_c(long* a, long* b, long* c__, long* m, long* n, long* p, long* x)
        {
            /* System generated locals */
            long i__1, i__2;

            /* Local variables */
            long i__, j, k, r__, i1, j1, k1, m1, r1;
            /* BЫЧИCЛEHИE BEKTOPA HEBЯЗKИ P                               */
            /* Parameter adjustments */
            --a;
            --p;
            --b;
            --x;
            --c__;

            /* Function Body */
            i__1 = *m;
            for (i__ = 1; i__ <= i__1; ++i__)
            {
                p[i__] = -b[i__];
                /* L10: */
            }
            k1 = 0;
            i__1 = *n;
            for (j = 1; j <= i__1; ++j)
            {
                k = k1 + 1;
                r__ = c__[j];
                utmlcj_c(&r__, &m1);
                k1 += m1;
                if (x[j] == 0)
                {
                    goto L30;
                }
                i__2 = k1;
                for (j1 = k; j1 <= i__2; ++j1)
                {
                    r1 = a[j1];
                    utmlcj_c(&r1, &i1);
                    p[i1] += r1;
                    /* L20: */
                }
                L30:
                ;
            }
            return 0;
        }

        private unsafe int mlc6r2_c(long* m, long* p, long* q, long* s)
        {
            /* System generated locals */
            long i__1, i__2;

            /* Local variables */
            long i__, j;

            /* S-CYMMA P(I),ECЛИ P(I)>0,ГДE I OT 1 ДO Q                   */
            /*        -P(I),ECЛИ P(I)<0,ГДE I OT 1 ДO Q                   */
            /*         P(I),ECЛИ P(I)>0,ГДE I OT Q+1 ДO M                 */
            /* Parameter adjustments */
            --p;

            /* Function Body */
            *s = 0;
            if (*q == 0)
            {
                goto L40;
            }
            i__1 = *q;
            for (j = 1; j <= i__1; ++j)
            {
                if ((i__2 = p[j]) < 0)
                {
                    goto L20;
                }
                else if (i__2 == 0)
                {
                    goto L30;
                }
                else
                {
                    goto L10;
                }
                L10:
                *s += p[j];
                goto L30;
                L20:
                *s -= p[j];
                L30:
                ;
            }
            L40:
            i__ = *q + 1;
            i__1 = *m;
            for (j = i__; j <= i__1; ++j)
            {
                if ((double) p[j] <= 0d)
                {
                    goto L50;
                }
                *s += p[j];
                L50:
                ;
            }
            return 0;
        }

        private unsafe int mlc6r3_c(long* a, long* c__, long* p, long* x, long* j)
        {
            /* System generated locals */
            long i__1;

            /* Local variables */
            long i__, k, l, r__, i1, m1, m2, m3;

/* ИЗMEHEHИE KOMПOHEHTЫ X(J) HA 1-X(J)                          */
/* И KOPPEKTИPOBKA BEKTOPA HEBЯЗKИ P                            */
            /* Parameter adjustments */
            --x;
            --p;
            --c__;
            --a;

            /* Function Body */
            if (x[*j] == 0)
            {
                goto L10;
            }
            l = -1;
            goto L20;
            L10:
            l = 1;
            L20:
            x[*j] = 1 - x[*j];
            m2 = 0;
            if (*j == 1)
            {
                goto L40;
            }
            k = *j - 1;
            i__1 = k;
            for (i__ = 1; i__ <= i__1; ++i__)
            {
                r__ = c__[i__];
                utmlcj_c(&r__, &m1);
                m2 += m1;
/* L30: */
            }
            L40:
            r__ = c__[*j];
            utmlcj_c(&r__, &m1);
            m3 = m2 + m1;
            ++m2;
            i__1 = m3;
            for (i__ = m2; i__ <= i__1; ++i__)
            {
                r__ = a[i__];
                utmlcj_c(&r__, &i1);
                p[i1] += r__*l;
/* L50: */
            }
            return 0;
        }

        private unsafe int mlc6r4_c(long* sum, long* s, long* a, long* c__, long* p, long* x, long* j)
        {
            /* ECЛИ SUM<S,TO S=SUM                               */
            /* ИHAЧE BOЗBPAЩAEMCЯ B ИCXOДHYЮ TOЧKY               */
            /* Parameter adjustments */
            --x;
            --p;
            --c__;
            --a;

            /* Function Body */
            if (*sum < *s)
            {
                goto L10;
            }
            mlc6r3_c(&a[1], &c__[1], &p[1], &x[1], j);
            goto L20;
            L10:
            *s = *sum;
            L20:
            return 0;
        }

        private unsafe int mlc6r5_c(long* del, long* x, long* c__, long* j)
        {
            long i__, l;
            /* BЫЧИCЛEHИE DEL- ИЗMEHEHИЯ (C,X) ПPИ ИЗMEHEHИИ X(J)         */
            /* Parameter adjustments */
            --c__;
            --x;

            /* Function Body */
            l = c__[*j];
            utmlcj_c(&l, &i__);
            if (x[*j] == 0)
            {
                goto L10;
            }
            *del = -l;
            goto L20;
            L10:
            *del = l;
            L20:
            return 0;
        }

        private unsafe int utmlci_c(long* iv, long* n, long* iw)
        {
            long i__, i1;
            long i__1;

            /*  YПAKOBKA BXOДHOГO MACCИBA IV B MACCИB IW */
            /* Parameter adjustments */
            --iv;
            --iw;

            /* Function Body */
            i__1 = *n;
            for (i__ = 1; i__ <= i__1; i__ += 2)
            {
                i1 = (i__ - 1)/2 + 1;
                iw[i1] = iv[i__] + iv[i__ + 1]*1000;
                /* L10: */
            }
            return 0;
        }

        private unsafe int utmlcj_c(long* l, long* i__)
        {
            long nn;

            /*   PACПAKOBKA:                                     */
            /*  HA BXOДE   L - ЭЛEMEHT YПAKOBAHHOЙ MATPИЦЫ;      */
            /*  HA BЫXOДE  I - HOMEP CTPOKИ,YПAKOBAHHOЙ B L,     */
            /*             L - "PACПAKOBAHHЫЙ" ЭЛEMEHT           */
            nn = *l/1000;
            if (*l < 0)
            {
                --nn;
            }
            *i__ = *l - nn*1000;
            *l = nn;
            return 0;
        }
    }
}
