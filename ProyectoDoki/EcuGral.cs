public class EcuGral
{
    private int a, b, c, d, e, f;

    public EcuGral() { }
    public EcuGral(int a, int b, int c, int d, int e, int f)
    {
        this.a = a; this.b = b; this.c = c;
        this.d = d; this.e = e; this.f = f;
    }

    public int A { get => a; set => a = value; }
    public int B { get => b; set => b = value; }
    public int C { get => c; set => c = value; }
    public int D { get => d; set => d = value; }
    public int E { get => e; set => e = value; }
    public int F { get => f; set => f = value; }

    public string Identifica()
    {
        int disc = b * b - 4 * a * c;
        if (disc < 0)
            return (b == 0 && a == c) ? "Circunferencia" : "Elipse";
        if (disc == 0) return "Parábola";
        return "Hipérbola";
    }
}