public class Bezier : ACurve
{
    private IPoint c, d;

    public Bezier(IPoint a, IPoint b, IPoint c, IPoint d) : base(a, b)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.d = d;
    }

    public override IPoint GetPoint(double t, IPoint p)
    {
        double aP = Math.Pow((1 - t), 3) * a.GetX() + 3 * t * Math.Pow((1 - t), 2) *
         c.GetX() + 3 * Math.Pow(t, 2) * (1 - t) * d.GetX() + Math.Pow(t, 3) * b.GetX();
        double bP = Math.Pow((1 - t), 3) * a.GetY() + 3 * t * Math.Pow((1 - t), 2) *
         c.GetY() + 3 * Math.Pow(t, 2) * (1 - t) * d.GetY() + Math.Pow(t, 3) * b.GetY();
        p.SetX(aP);
        p.SetY(bP);
        return p;
    }
}