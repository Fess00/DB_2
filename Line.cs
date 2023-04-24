using System;
public class Line : ACurve
{
    //IPoint a, b;

    public Line(IPoint a, IPoint b) : base(a, b)
    {
        this.a = a;
        this.b = b;
    }

    public override IPoint GetPoint(double t, IPoint p)
    {
        double aP = (1 - t) * a.GetX() + t * b.GetX();
        double bP = (1 - t) * a.GetY() + t * b.GetY();
        p.SetX(aP);
        p.SetY(bP);
        return p;
    }
}