namespace Programa10_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtContenido_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void txtContenido_DragDrop(object sender, DragEventArgs e)
        {
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            string linea = "";

            lblArchivo.Text = archivos[0];

            StreamReader lector = File.OpenText(archivos[0]); 

            while((linea= lector.ReadLine())!=null)
            {
                txtContenido.Text += linea + "\r\n";
            }

            lector.Close(); 
        }
    }
}