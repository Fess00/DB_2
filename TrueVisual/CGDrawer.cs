using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

public class CGDrawer : Drawer
{
    public override void Draw(ICurve iCurve)
    {
        IPoint point = new Point();
        Pen greenPen = new Pen(Color.Green, 3);
        greenPen.CustomEndCap = new AdjustableArrowCap(5, 5);
        Bitmap bmp = new Bitmap(1000, 700);
        Graphics g = Graphics.FromImage(bmp);
        g.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, 1000, 700));

        List<PointF> lp = new List<PointF>();

        float segment = 0;

        for (int i = 0; i <= 3; i++)
        {
            iCurve.GetPoint(segment, out point);
            lp.Add(new PointF(point.GetX(), point.GetY()));
            segment += (1f / 3f);
            if (i == 0)
            {
                g.FillEllipse(new SolidBrush(Color.Green), (int)point.GetX(), (int)point.GetY(), 7, 7);
            }
        }
        g.DrawBezier(greenPen, lp[0], lp[1], lp[2], lp[3]);
        g.Dispose();
        bmp.Save($"C:/Users/User/Documents/Code/C#/DB_2/CGD.png", System.Drawing.Imaging.ImageFormat.Png);
        g.Dispose();
    }

    public override void SaveSVG()
    {
        throw new NotImplementedException();
    }
}