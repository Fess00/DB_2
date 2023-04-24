using System;
public class VisualLine : VisualCurve
{
    public VisualLine(ACurve aCurve) : base(aCurve)
    {
    }

    public override void Draw()
    {
        IPoint p = new Point();
        aCurve.GetPoint(0, p);
        Console.WriteLine($"Вывожу точки x: {p.GetX()}, y: {p.GetY()}");
    }
}