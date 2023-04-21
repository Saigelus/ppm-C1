namespace Programa03_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ejemplo para menu");
        }
        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);

            double r = a + b;
            lblResultado.Text = r.ToString();

            slblValores.Text = "A=" + a.ToString() + " B=" + b.ToString();
            slblOperaciones.Text = "Suma";
            slblResultado.Text = "R= " + r.ToString();
        }



        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);

            double r = a - b;
            lblResultado.Text = r.ToString();

            slblValores.Text = "A=" + a.ToString() + " B=" + b.ToString();
            slblOperaciones.Text = "resta";
            slblResultado.Text = "R= " + r.ToString();
        }

        private void multiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);

            double r = a * b;
            lblResultado.Text = r.ToString();

            slblValores.Text = "A=" + a.ToString() + " B=" + b.ToString();
            slblOperaciones.Text = "multiplicaci�n";
            slblResultado.Text = "R= " + r.ToString();

        }

        private void divToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);

            double r = a / b;
            lblResultado.Text = r.ToString();

            slblValores.Text = "A=" + a.ToString() + " B=" + b.ToString();
            slblOperaciones.Text = "Divisi�n";
            slblResultado.Text = "R= " + r.ToString();
        }

        private void habilitarToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            txtA.Enabled = habilitarToolStripMenuItem.Checked;
            txtB.Enabled = habilitarToolStripMenuItem.Checked;
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtA.Text = "0";
        }

        private void aleatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int Valor = rnd.Next(0, 100);
            txtA.Text = Valor.ToString();
        }
    }
}