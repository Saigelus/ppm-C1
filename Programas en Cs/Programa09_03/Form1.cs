namespace Programa09_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; 

            g.DrawArc(Pens.Coral, new Rectangle(50, 50, 100, 100), 45, 100);

            g.DrawLine(Pens.Blue, 125, 25, 150, 200);

            g.DrawRectangle(Pens.Orange, new Rectangle(75, 75, 200, 25));

            Point[] puntos = { new Point(30, 45), new Point(110, 75), new Point(175, 200) };
            g.DrawLines(Pens.Green, puntos);

            g.DrawBezier(Pens.Blue, 100, 100, 130, 175, 147, 20, 200, 200);

            Point[] puntos2 = { new Point(10, 25), new Point(50, 205), new Point(150, 230) };
            g.DrawLines(Pens.Purple, puntos);

            g.DrawPie(Pens.Green, new Rectangle(100, 100, 100, 100), 30, 90);

            Point[] puntos3 = { new Point(10, 175), new Point(70, 50), new Point(150, 30) };
            g.DrawPolygon(Pens.Orange, puntos3); 
        }
    }
}