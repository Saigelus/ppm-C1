namespace Programa07_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Aqu� va el c�digo para abirr y leer el archivo. 

                lblAbrir.Text = openFileDialog1.FileName;

            }
        }
    }
}