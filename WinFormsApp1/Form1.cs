namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Point point1 = new Point(100, 10);
        public Point point3 = new Point(425 + 200, 10);
        public Point point5 = new Point(50, 250);
        public Point point7 = new Point(50 + 700, 250);
        public Point point9 = new Point(350, 475);
        public Point point11 = new Point(550, 475);
        public Random r = new Random();
        public int count = 0;
        public  double q = 2.5;
        public Point tmp;
        public int RandomInt()
        {  
            return r.Next(0, 7);        
        }
        public void Drawing(PaintEventArgs e ,Point point)
        {
            do
            {
                if (RandomInt() == 1)
                {
                    tmp = new Point((int)((point.X + point3.X) / q), (int)((point.Y + point3.Y) / (q)));
                }
                else if (RandomInt() == 2)
                {
                    tmp = new Point((int)((point.X + point1.X) / q), (int)((point.Y + point1.Y) / (q)));
                }
                else if (RandomInt() == 3)
                {
                    tmp = new Point((int)((point.X + point5.X) / q), (int)((point.Y + point5.Y) / (q)));
                }
                //else if (RandomInt() == 4)
                //{
                //    tmp = new Point((int)((point.X + point11.X) / q), (int)((point.Y + point11.Y) / (q)));
                //}
                e.Graphics.DrawLine(Pens.Black, tmp, new Point(tmp.X + 1, tmp.Y));
                count++;
                point = tmp;
            }while (true);
        }
        public void Drawing1(PaintEventArgs e, Point point)
        {
            do
            {
                if (RandomInt() == 1)
                {
                    tmp = new Point((int)((point.X + point3.X) / q), (int)((point.Y + point3.Y) / (q)));
                }
                else if (RandomInt() == 2)
                {
                    tmp = new Point((int)((point.X + point1.X) / q), (int)((point.Y + point1.Y) / (q)));
                }
                else if (RandomInt() == 3)
                {
                    tmp = new Point((int)((point.X + point5.X) / q), (int)((point.Y + point5.Y) / (q)));
                }
                else if (RandomInt() == 4)
                {
                    tmp = new Point((int)((point.X + point7.X) / q), (int)((point.Y + point7.Y) / (q)));
                }
                else if (RandomInt() == 5)
                {
                    tmp = new Point((int)((point.X + point9.X) / q), (int)((point.Y + point9.Y) / (q)));
                }
                else if (RandomInt() == 6)
                {
                    tmp = new Point((int)((point.X + point11.X) / q), (int)((point.Y + point11.Y) / (q)));
                }
                e.Graphics.DrawLine(Pens.Black, tmp, new Point(tmp.X + 1, tmp.Y));
                count++;
                point = tmp;
            } while (true);
        }
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {        
            Point point2 = Point.Add(point1, new Size(1, 0));
            e.Graphics.DrawLine(Pens.Red, point1, point2);
            Point point4 = Point.Add(point3, new Size(1, 0));
            e.Graphics.DrawLine(Pens.Red, point3, point4);
            Point point6 = Point.Add(point5, new Size(1, 0));
            e.Graphics.DrawLine(Pens.Red, point5, point6);
            Point point8 = Point.Add(point7, new Size(1, 0));
            e.Graphics.DrawLine(Pens.Red, point7, point8);
            Point point10 = Point.Add(point9, new Size(1, 0));
            e.Graphics.DrawLine(Pens.Red, point9, point10);
            Point point12 = Point.Add(point11, new Size(1, 0));
            e.Graphics.DrawLine(Pens.Red, point11, point12);

            Drawing(e, point1);
           
                }
        
        
    }
}