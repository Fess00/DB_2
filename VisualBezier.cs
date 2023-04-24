using System;
public class VisualBezier : VisualCurve
{
    public VisualBezier(ACurve aCurve) : base(aCurve)
    {
    }

    public override void Draw()
    {
        IPoint head = new Point();
        IPoint mid1 = new Point();
        IPoint mid2 = new Point();
        IPoint last = new Point();
        aCurve.GetPoint(0, head);
        aCurve.GetPoint(0.25, mid1);
        aCurve.GetPoint(0.75, mid2);
        aCurve.GetPoint(1, last);
        Console.WriteLine($"Вывожу точки x1: {head.GetX()}, y1: {head.GetY()}, x2: {mid1.GetX()}, y2: {mid1.GetY()}," +
        $"x3: {mid2.GetX()}, y3: {mid2.GetY()}, x4: {last.GetX()}, y4: {last.GetY()}");
    }
}