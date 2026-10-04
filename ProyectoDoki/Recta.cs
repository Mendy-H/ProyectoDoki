namespace ProyectoDoki
{
    public class Recta
    {
        public double A, B, C;

        public static Recta DosPuntos(double x1, double y1, double x2, double y2)
            => new Recta { A = y2 - y1, B = x1 - x2, C = x2 * y1 - x1 * y2 };

        public static Recta PuntoPendiente(double x1, double y1, double m)
            => new Recta { A = m, B = -1, C = y1 - m * x1 };

        public static Recta PendienteOrdenada(double m, double b)
            => new Recta { A = m, B = -1, C = b };

        public static Recta General(double a, double b, double c)
            => new Recta { A = a, B = b, C = c };

        public static Recta Simetrica(double a, double b)
            => new Recta { A = b, B = a, C = -a * b };

        public bool EsValida() => A != 0 || B != 0;
        public bool EsVertical() => B == 0;
        public double Pendiente() => -A / B;
        public double Ordenada() => -C / B;
    }
}