IPoint a = new Point();
IPoint b = new Point();
IPoint c = new Point();
IPoint d = new Point();

a.SetX(3);
a.SetY(50);
b.SetX(50);
b.SetY(3);
c.SetX(60);
c.SetY(70);
d.SetX(120);
d.SetY(180);

ACurve line = new Line(a, b);
ACurve bezier = new Bezier(a, b, c, d);

VisualCurve vc = new VisualLine(line);
VisualCurve vb = new VisualBezier(bezier);

vc.Draw();
vb.Draw();
