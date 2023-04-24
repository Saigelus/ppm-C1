namespace Programa10_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
                txtDos.Text = Clipboard.GetText();
            if (Clipboard.Clipboard.ContainsImage())
                pictureBox1.Image = Clipboard.GetImage();
            if (Clipboard.ContainsData(DataFormats.Rtf))
                rtbuno.Rtf = (string)Clipboard.GetData(DataFormats.Rtf);
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtUno.Text);
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear(); 
        }
    }
}
}