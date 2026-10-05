using System;

namespace ProyectoDoki
{
    public class Elipse
    {
        public double H { get; set; }
        public double K { get; set; }
        public double A { get; set; }
        public double B { get; set; }
        public bool EsHorizontal { get; set; }

        private Elipse(double h, double k, double a, double b, bool esHorizontal)
        {
            H = h;
            K = k;
            A = a;
            B = b;
            EsHorizontal = esHorizontal;
        }

        public static Elipse Horizontal(double h, double k, double a, double b)
        {
            return new Elipse(h, k, a, b, true);
        }

        public static Elipse Vertical(double h, double k, double a, double b)
        {
            return new Elipse(h, k, a, b, false);
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
                return $"{binomioX} / {aCuadrada} + {binomioY} / {bCuadrada} = 1";
            else
                return $"{binomioX} / {bCuadrada} + {binomioY} / {aCuadrada} = 1";
        }

        public string EcuacionGeneral()
        {
            double aCuadrada = Math.Pow(A, 2);
            double bCuadrada = Math.Pow(B, 2);

            double coefX2 = EsHorizontal ? bCuadrada : aCuadrada;
            double coefY2 = EsHorizontal ? aCuadrada : bCuadrada;

            double D = -2 * H * coefX2;
            double E = -2 * K * coefY2;
            double F = (coefX2 * Math.Pow(H, 2)) + (coefY2 * Math.Pow(K, 2)) - (aCuadrada * bCuadrada);

            string signoD = D >= 0 ? "+" : "-";
            string signoE = E >= 0 ? "+" : "-";
            string signoF = F >= 0 ? "+" : "-";

            return $"{coefX2}x² + {coefY2}y² {signoD} {Math.Abs(D)}x {signoE} {Math.Abs(E)}y {signoF} {Math.Abs(F)} = 0";
        }
    }
}