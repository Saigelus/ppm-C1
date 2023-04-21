using System.ComponentModel;
using System.Media;

namespace Programa08_03
{
    public partial class Form1 : Form
    {
        private string ruta = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBeep_Click(object sender, EventArgs e)
        {
            Console.Beep();
        }

        private void btnSistema_Click(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;
                lblRuta.Text = ruta;
            }
        }

        private void btnTocar_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = ruta;
                player.Load();
                player.Play();
            }

            catch (Win32Exception ex)
            {
                MessageBox.Show("No se pudo tocar el audio");
            }
        }
    }
}