
IPoint a = new Point();
IPoint b = new Point();
IPoint c = new Point();
IPoint d = new Point();
IPoint z = new Point();

a.SetX(3);
a.SetY(50);
b.SetX(50);
b.SetY(3);
c.SetX(60);
c.SetY(70);
d.SetX(120);
d.SetY(180);

Line line = new Line(a, d);
Bezier bezier = new Bezier(a, b, c, d);

IPoint n = new Point();

line.SetDrawer(new CGDrawer());
bezier.SetDrawer(new CBDrawer());

line.Draw();
bezier.Draw();
