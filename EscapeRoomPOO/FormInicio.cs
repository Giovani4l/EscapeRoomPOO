using System;
using System.Windows.Forms;

namespace EscapeRoomPOO
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
            InicializarSelectorIdioma();
            ActualizarTextos();
        }

        private void InicializarSelectorIdioma()
        {
            cmbIdioma.Items.AddRange(new object[]
            {
                "Español",
                "English",
                "Français",
                "Deutsch",
                "Italiano",
                "日本語",
                "한국어",
                "中文"
            });
            cmbIdioma.SelectedIndex = 0;
        }

        private void cmbIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdiomaJuego.CambiarIdioma((IdiomaJuego.Idioma)cmbIdioma.SelectedIndex);
            ActualizarTextos();
        }

        private void ActualizarTextos()
        {
            lblSub.Text           = IdiomaJuego.SubtituloJuego;
            lblMejor.Text         = IdiomaJuego.MejorPuntaje(RepositorioPuntajes.LeerMejorPuntaje());
            btnJugar.Text         = IdiomaJuego.BotonJugar;
            btnHistorial.Text     = IdiomaJuego.BotonHistorial;
            btnCargarPartida.Text = IdiomaJuego.BotonCargarPartida;
            lblInfo.Text          = IdiomaJuego.InfoJuego;
            ActualizarVisibilidadBotonCargar();
        }

        private void ActualizarVisibilidadBotonCargar()
        {
            btnCargarPartida.Enabled = RepositorioPartidas.HayPartidasGuardadas();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            AbrirJuego(partidaCargada: null);
        }

        private void btnCargarPartida_Click(object sender, EventArgs e)
        {
            var formPartidas = new FormPartidas();
            if (formPartidas.ShowDialog(this) == DialogResult.OK)
                AbrirJuego(formPartidas.PartidaSeleccionada);
        }

        private void AbrirJuego(PartidaGuardada partidaCargada)
        {
            Hide();
            new FormJuego(partidaCargada).ShowDialog(this);
            lblMejor.Text = IdiomaJuego.MejorPuntaje(RepositorioPuntajes.LeerMejorPuntaje());
            ActualizarVisibilidadBotonCargar();
            Show();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                RepositorioPuntajes.LeerHistorial(),
                IdiomaJuego.TituloHistorial,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
