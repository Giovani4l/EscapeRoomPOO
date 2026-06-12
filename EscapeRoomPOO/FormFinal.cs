using System.Drawing;
using System.Windows.Forms;

namespace EscapeRoomPOO
{
    public partial class FormFinal : Form
    {
        public bool QuiereReiniciar { get; private set; }

        public FormFinal(int puntaje, bool jugadorGano, int nivelAlcanzado, string mejorPuntaje)
        {
            InitializeComponent();
            ConfigurarApariencia(jugadorGano);
            MostrarResultados(puntaje, jugadorGano, nivelAlcanzado, mejorPuntaje);
        }

        private void ConfigurarApariencia(bool jugadorGano)
        {
            Color colorSegunResultado = jugadorGano ? ConfiguracionJuego.ColorVictoria : ConfiguracionJuego.ColorRojo;
            BackColor              = colorSegunResultado;
            btnReiniciar.ForeColor = colorSegunResultado;
        }

        private void MostrarResultados(int puntaje, bool jugadorGano, int nivelAlcanzado, string mejorPuntaje)
        {
            lblResultado.Text  = IdiomaJuego.MensajeResultado(jugadorGano);
            lblPuntaje.Text    = IdiomaJuego.EtiquetaPuntajeFinal(puntaje);
            lblNivelInfo.Text  = IdiomaJuego.EtiquetaNivelAlcanzado(nivelAlcanzado, ConfiguracionJuego.TotalNiveles);
            btnReiniciar.Text  = IdiomaJuego.BotonReiniciar;
            btnSalir.Text      = IdiomaJuego.BotonSalir;
            ConfigurarIndicadorRecord(puntaje, mejorPuntaje);
        }

        private void ConfigurarIndicadorRecord(int puntaje, string mejorPuntaje)
        {
            bool esNuevoRecord  = EsNuevoRecord(puntaje, mejorPuntaje);
            lblRecord.Text      = esNuevoRecord ? IdiomaJuego.MensajeNuevoRecord : IdiomaJuego.MensajeMejorPuntaje(mejorPuntaje);
            lblRecord.ForeColor = esNuevoRecord ? ConfiguracionJuego.ColorRecord : Color.White;
            lblRecord.Font      = new Font("Segoe UI", 11F, esNuevoRecord ? FontStyle.Bold : FontStyle.Regular);
        }

        private bool EsNuevoRecord(int puntaje, string mejorPuntaje)
            => int.TryParse(mejorPuntaje, out int mejorPuntajeActual) && puntaje >= mejorPuntajeActual;

        private void btnReiniciar_Click(object sender, System.EventArgs e)
        {
            QuiereReiniciar = true;
            Close();
        }

        private void btnSalir_Click(object sender, System.EventArgs e)
        {
            QuiereReiniciar = false;
            Close();
        }
    }
}
