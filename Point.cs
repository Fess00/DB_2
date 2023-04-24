public class Point : IPoint
{
    private double x, y;

    public Point()
    {
        this.x = 0;
        this.y = 0;
    }

    public double GetX()
    {
        return this.x;
    }

    public double GetY()
    {
        return this.y;
    }

    public void SetX(double x)
    {
        this.x = x;
    }
    public void SetY(double y)
    {
        this.y = y;
    }
}