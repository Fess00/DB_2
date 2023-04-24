public abstract class VisualCurve : IDrawable, ICurve
{
    protected ACurve aCurve;

    public VisualCurve(ACurve aCurve)
    {
        this.aCurve = aCurve;
    }

    public abstract void Draw();

    public IPoint GetPoint(double t, IPoint p)
    {
        return aCurve.GetPoint(t, p);
    }
}