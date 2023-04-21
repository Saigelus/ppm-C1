namespace Programa09_02
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

            //Ejemplo 1
            //Dibujamos uan elipse
            //Los primeros parametros son las coordenadas de al esq. sup izq
            //Los dos siguientes son el ancho y el alot del col

            g.DrawEllipse(Pens.Indigo, new Rectangle(50, 50, 100, 50));

            g.DrawEllipse(Pens.Red, new Rectangle(0, 0, 10, 10));

            //Hacemos un offset al origen
            g.TranslateTransform(100, 100);

            g.DrawEllipse(Pens.Blue, new Rectangle(0, 0, 20, 20));
            g.DrawEllipse(Pens.CadetBlue, new Rectangle(0, 0, 20, 20));

        }
    }
}