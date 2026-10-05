using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoDoki
{
    public class Hiperbola
    {
        public double H { get; set; }
        public double K { get; set; }
        public double A { get; set; }
        public double B { get; set; }
        public bool EsHorizontal { get; set; }

        private Hiperbola(double h, double k, double a, double b, bool esHorizontal)
        {
            H = h;
            K = k;
            A = a;
            B = b;
            EsHorizontal = esHorizontal;
        }

        public static Hiperbola Horizontal(double h, double k, double a, double b)
        {
            return new Hiperbola(h, k, a, b, true);
        }

        public static Hiperbola Vertical(double h, double k, double a, double b)
        {
            return new Hiperbola(h, k, a, b, false);
        }

        public string EcuacionOrdinaria()
        {
            string signoH = H > 0 ? "-" : "+";
            string signoK = K > 0 ? "-" : "+";

            double absH = Math.Abs(H);
            double absK = Math.Abs(K);

            double aCuadrada = Math.Pow(A, 2);
            double bCuadrada = Math.Pow(B, 2);

            string binomioX = (H == 0) ? "x²" : $"(x {signoH} {absH})²";
            string binomioY = (K == 0) ? "y²" : $"(y {signoK} {absK})²";

            if (EsHorizontal)
                return $"{binomioX} / {aCuadrada} - {binomioY} / {bCuadrada} = 1";
            else
                return $"{binomioY} / {aCuadrada} - {binomioX} / {bCuadrada} = 1";
        }

        public string EcuacionGeneral()
        {
            double aCuadrada = Math.Pow(A, 2);
            double bCuadrada = Math.Pow(B, 2);

            double coefX2, coefY2, D, E, F;

            if (EsHorizontal)
            {
                coefX2 = bCuadrada;
                coefY2 = -aCuadrada;

                D = -2 * H * bCuadrada;
                E = 2 * K * aCuadrada;
                F = (bCuadrada * Math.Pow(H, 2)) - (aCuadrada * Math.Pow(K, 2)) - (aCuadrada * bCuadrada);
            }
            else
            {
                coefX2 = -aCuadrada;
                coefY2 = bCuadrada;

                D = 2 * H * aCuadrada;
                E = -2 * K * bCuadrada;
                F = (bCuadrada * Math.Pow(K, 2)) - (aCuadrada * Math.Pow(H, 2)) - (aCuadrada * bCuadrada);
            }

            string signoCoefY2 = coefY2 > 0 ? "+" : "-";
            string signoD = D >= 0 ? "+" : "-";
            string signoE = E >= 0 ? "+" : "-";
            string signoF = F >= 0 ? "+" : "-";

            string inicioEcuacion = coefX2 < 0 ? $"- {Math.Abs(coefX2)}x²" : $"{coefX2}x²";

            return $"{inicioEcuacion} {signoCoefY2} {Math.Abs(coefY2)}y² {signoD} {Math.Abs(D)}x {signoE} {Math.Abs(E)}y {signoF} {Math.Abs(F)} = 0";
        }
    }
}