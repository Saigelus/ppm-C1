namespace Programa10_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Cargamos el documento rtf
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Salvamos el documento rtf
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);

            }
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void códigoRTFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string codigo = richTextBox1.SelectedRtf;
            MessageBox.Show(codigo);
        }
    }
}