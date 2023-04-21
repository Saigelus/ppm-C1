namespace Programa08_05
{
    public partial class Form1 : Form
    {
        private Form2 forma;
        public Form1()
        {
            InitializeComponent();
        }

        private void adicionarVentana1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (forma == null)
            {
                forma = new Form2();
                forma.MdiParent = this;
                forma.FormClosed += new FormClosedEventHandler(CerrarForma);
                forma.Show();
            }
            else
            {
                forma.Activate();
            }
        }
        void CerrarForma(object sender, EventArgs e)
        {
            forma = null;
        }

        private void adicionarVentana2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form3 otraForma = new Form3();
            otraForma.MdiParent = this; 
            otraForma.Show();
        }
    }
}