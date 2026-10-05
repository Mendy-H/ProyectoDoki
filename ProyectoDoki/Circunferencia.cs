using System;

namespace ProyectoDoki
{
    public class Circunferencia
    {
        public double H { get; set; }
        public double K { get; set; }
        public double R { get; set; }

        private Circunferencia(double h, double k, double r)
        {
            H = h;
            K = k;
            R = r;
        }

        public static Circunferencia CentroYRadio(double h, double k, double r)
        {
            return new Circunferencia(h, k, r);
        }

        public static Circunferencia CentroYPunto(double h, double k, double x, double y)
        {
            double distanciaX = Math.Pow(x - h, 2);
            double distanciaY = Math.Pow(y - k, 2);
            double radioCalculado = Math.Sqrt(distanciaX + distanciaY);

            return new Circunferencia(h, k, radioCalculado);
        }

        public string EcuacionOrdinaria()
        {
            string signoH = H > 0 ? "-" : "+";
            string signoK = K > 0 ? "-" : "+";

            double absH = Math.Abs(H);
            double absK = Math.Abs(K);
            double rCuadrada = Math.Pow(R, 2);

            if (H == 0 && K == 0)
                return $"x² + y² = {rCuadrada}";

            return $"(x {signoH} {absH})² + (y {signoK} {absK})² = {rCuadrada}";
        }

        public string EcuacionGeneral()
        {
            double D = -2 * H;
            double E = -2 * K;
            double F = Math.Pow(H, 2) + Math.Pow(K, 2) - Math.Pow(R, 2);

            string signoD = D >= 0 ? "+" : "-";
            string signoE = E >= 0 ? "+" : "-";
            string signoF = F >= 0 ? "+" : "-";

            return $"x² + y² {signoD} {Math.Abs(D)}x {signoE} {Math.Abs(E)}y {signoF} {Math.Abs(F)} = 0";
        }
    }
}