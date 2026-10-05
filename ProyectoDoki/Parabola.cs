using System;

namespace ProyectoDoki
{
    public enum OrientacionParabola
    {
        VerticalArriba,
        VerticalAbajo,
        HorizontalDerecha,
        HorizontalIzquierda
    }

    public class Parabola
    {
        public double H { get; set; }
        public double K { get; set; }
        public double P { get; set; }
        public OrientacionParabola Orientacion { get; set; }

        private Parabola(double h, double k, double p, OrientacionParabola orientacion)
        {
            H = h;
            K = k;
            P = Math.Abs(p);
            Orientacion = orientacion;
        }

        public static Parabola Arriba(double h, double k, double p) => new Parabola(h, k, p, OrientacionParabola.VerticalArriba);
        public static Parabola Abajo(double h, double k, double p) => new Parabola(h, k, p, OrientacionParabola.VerticalAbajo);
        public static Parabola Derecha(double h, double k, double p) => new Parabola(h, k, p, OrientacionParabola.HorizontalDerecha);
        public static Parabola Izquierda(double h, double k, double p) => new Parabola(h, k, p, OrientacionParabola.HorizontalIzquierda);

        public string EcuacionOrdinaria()
        {
            string signoH = H > 0 ? "-" : "+";
            string signoK = K > 0 ? "-" : "+";
            double absH = Math.Abs(H);
            double absK = Math.Abs(K);

            string binomioX = (H == 0) ? "x²" : $"(x {signoH} {absH})²";
            string binomioY = (K == 0) ? "y²" : $"(y {signoK} {absK})²";

            string ladoX = (H == 0) ? "x" : $"(x {signoH} {absH})";
            string ladoY = (K == 0) ? "y" : $"(y {signoK} {absK})";

            switch (Orientacion)
            {
                case OrientacionParabola.VerticalArriba:
                    return $"{binomioX} = {4 * P}{ladoY}";
                case OrientacionParabola.VerticalAbajo:
                    return $"{binomioX} = -{4 * P}{ladoY}";
                case OrientacionParabola.HorizontalDerecha:
                    return $"{binomioY} = {4 * P}{ladoX}";
                case OrientacionParabola.HorizontalIzquierda:
                    return $"{binomioY} = -{4 * P}{ladoX}";
                default:
                    return "";
            }
        }

        public string EcuacionGeneral()
        {
            double D = 0, E = 0, F = 0;

            if (Orientacion == OrientacionParabola.VerticalArriba || Orientacion == OrientacionParabola.VerticalAbajo)
            {
                D = -2 * H;
                E = (Orientacion == OrientacionParabola.VerticalArriba) ? -4 * P : 4 * P;
                F = (Orientacion == OrientacionParabola.VerticalArriba) ? Math.Pow(H, 2) + (4 * P * K) : Math.Pow(H, 2) - (4 * P * K);

                string signoD = D >= 0 ? "+" : "-";
                string signoE = E >= 0 ? "+" : "-";
                string signoF = F >= 0 ? "+" : "-";

                return $"x² {signoD} {Math.Abs(D)}x {signoE} {Math.Abs(E)}y {signoF} {Math.Abs(F)} = 0";
            }
            else
            {
                D = (Orientacion == OrientacionParabola.HorizontalDerecha) ? -4 * P : 4 * P;
                E = -2 * K;
                F = (Orientacion == OrientacionParabola.HorizontalDerecha) ? Math.Pow(K, 2) + (4 * P * H) : Math.Pow(K, 2) - (4 * P * H);

                string signoD = D >= 0 ? "+" : "-";
                string signoE = E >= 0 ? "+" : "-";
                string signoF = F >= 0 ? "+" : "-";

                return $"y² {signoD} {Math.Abs(D)}x {signoE} {Math.Abs(E)}y {signoF} {Math.Abs(F)} = 0";
            }
        }
    }
}