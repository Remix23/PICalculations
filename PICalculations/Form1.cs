using System.Drawing;

namespace PICalculations
{
    public partial class Form1 : Form
    {

        private List<Point> points;
        private int rectSize;
        private Point rectPos;
        private Random rnd;

        private int pointsTotal;
        private int pointsInCircle;
        private double PICarlo;

        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;
            timer1.Interval = 50;

            points = new List<Point>();
            rnd = new Random();

            pointsTotal = 0;
            pointsInCircle = 0;

            rectSize = 300;
            rectPos = new Point((pictureBox1.Width - rectSize) / 2, (pictureBox1.Height - rectSize) / 2);

            AddPoints(100);
        }

        private void AddPoints (int n)
        {
            for (int i = 0; i < n; i++)
            {
                int x = rnd.Next(rectSize) - rectSize / 2;
                int y = rnd.Next(rectSize) - rectSize / 2;
                points.Add(new Point(x, y));
                if (IsInCircle(x, y, rectSize / 2)) pointsInCircle++;
                pointsTotal++;
            }
            PICarlo = 4.0 * pointsInCircle / pointsTotal;
        }

        private double CalcPISum (int n)
        {
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                int sign = i % 2 == 0 ? 1 : -1;
                sum += 1.0 / (2.0 * i + 1.0) * sign;
                
            }
            return sum * 4;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AddPoints(1);
            pictureBox1.Invalidate();
        }

        private (int, int) wrapCords (int x, int y)
        {
            x = x + pictureBox1.Width / 2;
            y = y + pictureBox1.Height / 2;
            return (x, y);
        }

        private bool IsInCircle (int x, int y, int circle_r)
        {
            return x * x + y * y <= circle_r * circle_r;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Rectangle rect = new Rectangle(rectPos.X, rectPos.Y, rectSize, rectSize);

            g.DrawRectangle(Pens.Black, rect);

            g.DrawEllipse(Pens.Green, rect);

            foreach (Point p in points)
            {
                (int x, int y) = wrapCords(p.X, p.Y);
                g.DrawEllipse(Pens.Red, x, y, 5, 5);
            }

            piLibrary.Text = Convert.ToString(Math.PI);
            piSequence.Text = Convert.ToString(CalcPISum(points.Count));

            piMonteCarlo.Text = Convert.ToString(PICarlo);

        }
    }
}