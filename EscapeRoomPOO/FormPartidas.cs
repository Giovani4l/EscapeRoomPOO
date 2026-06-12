using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EscapeRoomPOO
{
    public partial class FormPartidas : Form
    {
        public PartidaGuardada PartidaSeleccionada { get; private set; }

        private List<PartidaGuardada> _partidas;

        private bool HayPartidaSeleccionada => lstPartidas.SelectedIndex >= 0;
        private PartidaGuardada PartidaEnFoco => _partidas[lstPartidas.SelectedIndex];

        public FormPartidas()
        {
            InitializeComponent();
            ActualizarTextos();
            CargarLista();
        }

        private void ActualizarTextos()
        {
            Text              = IdiomaJuego.BotonCargarPartida;
            lblTitulo.Text    = IdiomaJuego.BotonCargarPartida;
            btnCargar.Text    = IdiomaJuego.BotonCargarPartida;
            btnCancelar.Text  = IdiomaJuego.BotonSalir;
        }

        private void CargarLista()
        {
            _partidas = RepositorioPartidas.CargarTodas();
            lstPartidas.Items.Clear();

            foreach (PartidaGuardada partida in _partidas)
                lstPartidas.Items.Add(partida.ResumenParaMostrar);

            lblRanuras.Text = $"{_partidas.Count} / {RepositorioPartidas.MaximoRanuras}";
            ActualizarEstadoBotones();
        }

        private void ActualizarEstadoBotones()
        {
            btnCargar.Enabled   = HayPartidaSeleccionada;
            btnEliminar.Enabled = HayPartidaSeleccionada;
        }

        private void lstPartidas_SelectedIndexChanged(object sender, EventArgs e)
            => ActualizarEstadoBotones();

        private void lstPartidas_DoubleClick(object sender, EventArgs e)
            => ConfirmarCarga();

        private void btnCargar_Click(object sender, EventArgs e)
            => ConfirmarCarga();

        private void btnEliminar_Click(object sender, EventArgs e)
            => EliminarPartidaSeleccionada();

        private void btnCancelar_Click(object sender, EventArgs e)
            => Close();

        private void ConfirmarCarga()
        {
            if (!HayPartidaSeleccionada) return;
            PartidaSeleccionada = PartidaEnFoco;
            DialogResult        = DialogResult.OK;
            Close();
        }

        private void EliminarPartidaSeleccionada()
        {
            if (!HayPartidaSeleccionada) return;

            PartidaGuardada partida      = PartidaEnFoco;
            bool            confirmoEliminar = MessageBox.Show(
                $"\"{partida.Nombre}\"",
                IdiomaJuego.TituloAbandonar,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes;

            if (confirmoEliminar)
            {
                RepositorioPartidas.EliminarPartida(partida.Id);
                CargarLista();
            }
        }
    }
}
