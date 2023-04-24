using System.Threading;

namespace Programa10_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Creamos un hilo
            Thread t = new Thread(new ThreadStart(SplashStart));

            //Arrancamos el hilo
            t.Start();

            //Ponemos a dormir la forma principal
            Thread.Sleep(5000);

            InitializeComponent();

            //Finalizamos el hilo 
            t.Abort();
        }
        public void SplashStart()
        {
            Application.Run(new Form2());
        }
    }
}