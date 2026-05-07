using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EscapeRoomPOO
{
    public partial class FormJuego : Form
    {
        private int            nivelActual;
        private int            puntajeTotal;
        private int            indiceAcertijoActual;
        private int            segundosRestantes;
        private bool           jugadorUsoPista;
        private List<Acertijo> acertijosDelNivel;
        private readonly Random generadorAleatorio = new Random();

        private Acertijo AcertijoActual => acertijosDelNivel[indiceAcertijoActual];
        private bool     NivelCompleto  => indiceAcertijoActual >= ConfiguracionJuego.AcertijosPorNivel;
        private bool     EsUltimoNivel  => nivelActual >= ConfiguracionJuego.TotalNiveles;
        private bool     SinIntentos    => AcertijoActual.Intentos <= 0;

        public FormJuego()
        {
            InitializeComponent();
            IniciarPartida();
        }

        private void IniciarPartida()
        {
            nivelActual  = 1;
            puntajeTotal = 0;
            CargarNivel();
            timerJuego.Start();
        }

        private void CargarNivel()
        {
            acertijosDelNivel    = GenerarAcertijosAleatorios();
            indiceAcertijoActual = 0;
            segundosRestantes    = ConfiguracionJuego.SegundosPorNivel;
            jugadorUsoPista      = false;
            RefrescarPantalla();
        }

        private List<Acertijo> GenerarAcertijosAleatorios()
        {
            var lista = new List<Acertijo>
            {
                new AcertijoMatematico(nivelActual, generadorAleatorio),
                new AcertijoCompletarPalabra(nivelActual, generadorAleatorio),
                new AcertijoLogica(nivelActual, generadorAleatorio)
            };
            MezclarLista(lista);
            return lista;
        }

        private void MezclarLista(List<Acertijo> lista)
        {
            for (int i = lista.Count - 1; i > 0; i--)
            {
                int      j                = generadorAleatorio.Next(i + 1);
                Acertijo acertijoTemporal = lista[i];
                lista[i]                  = lista[j];
                lista[j]                  = acertijoTemporal;
            }
        }

        private void RefrescarPantalla()
        {
            lblNivel.Text             = $"NIVEL {nivelActual} / {ConfiguracionJuego.TotalNiveles}";
            lblTipo.Text              = $"[{AcertijoActual.ObtenerTipo()}]";
            lblPuntaje.Text           = $"Puntaje: {puntajeTotal}";
            lblIntentos.Text          = $"Intentos: {AcertijoActual.Intentos}";
            lblProgreso.Text          = $"Acertijo {indiceAcertijoActual + 1} de {ConfiguracionJuego.AcertijosPorNivel}";
            lblPregunta.Text          = AcertijoActual.Pregunta;
            lblMejorPuntaje.Text      = $"Mejor: {RepositorioPuntajes.LeerMejorPuntaje()} pts";
            progressBarAcertijo.Value = (indiceAcertijoActual * 100) / ConfiguracionJuego.AcertijosPorNivel;

            OcultarFeedback();
            LimpiarYEnfocarInput();
        }

        private void OcultarFeedback()
        {
            lblFeedback.Text        = "";
            lblPista.Visible        = false;
            panelPregunta.BackColor = SystemColors.ControlLight;
            lblTimer.ForeColor      = ConfiguracionJuego.ColorTimerNormal;
        }

        private void LimpiarYEnfocarInput()
        {
            txtRespuesta.Clear();
            txtRespuesta.Focus();
        }

        private void timerJuego_Tick(object sender, EventArgs e)
        {
            segundosRestantes--;
            ActualizarDisplayTimer();

            if (segundosRestantes <= 0)
                AgorarTiempo();
        }

        private void ActualizarDisplayTimer()
        {
            lblTimer.Text          = $"{segundosRestantes}s";
            progressBarTimer.Value = (segundosRestantes * 100) / ConfiguracionJuego.SegundosPorNivel;

            if (segundosRestantes <= ConfiguracionJuego.SegundosAlertaTimer)
                lblTimer.ForeColor = ConfiguracionJuego.ColorTimerAlerta;
        }

        private void AgorarTiempo()
        {
            timerJuego.Stop();
            TerminarJuego(jugadorGano: false);
        }

        private void btnValidar_Click(object sender, EventArgs e) => ProcesarRespuesta();

        private void txtRespuesta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) ProcesarRespuesta();
        }

        private void ProcesarRespuesta()
        {
            string respuestaDelUsuario = txtRespuesta.Text.Trim();

            if (string.IsNullOrEmpty(respuestaDelUsuario))
            {
                MostrarFeedback("Escribe una respuesta primero.", ConfiguracionJuego.ColorTimerAlerta);
                return;
            }

            bool esCorrecta = AcertijoActual.Resolver(respuestaDelUsuario);

            if (esCorrecta)
                ManejarRespuestaCorrecta();
            else
                ManejarRespuestaIncorrecta();
        }

        private void ManejarRespuestaCorrecta()
        {
            int puntosGanados = AcertijoActual.CalcularPuntos(segundosRestantes, jugadorUsoPista);
            puntajeTotal     += puntosGanados;

            MostrarFeedback($"¡Correcto! +{puntosGanados} puntos", ConfiguracionJuego.ColorCorrecto);
            panelPregunta.BackColor = ConfiguracionJuego.ColorPanelCorrecto;
            lblPuntaje.Text         = $"Puntaje: {puntajeTotal}";

            BloquearInput();
            EjecutarDespuesDe(ConfiguracionJuego.MsEsperaRespuestaCorrecta, () =>
            {
                DesbloquearInput();
                AvanzarAcertijo();
            });
        }

        private void ManejarRespuestaIncorrecta()
        {
            panelPregunta.BackColor = ConfiguracionJuego.ColorPanelError;
            lblIntentos.Text        = $"Intentos: {AcertijoActual.Intentos}";

            if (SinIntentos)
            {
                MostrarFeedback("Sin intentos. ¡Juego terminado!", ConfiguracionJuego.ColorIncorrecto);
                timerJuego.Stop();
                EjecutarDespuesDe(ConfiguracionJuego.MsEsperaDerrota, () => TerminarJuego(jugadorGano: false));
            }
            else
            {
                MostrarFeedback($"Incorrecto. Te quedan {AcertijoActual.Intentos} intento(s).", ConfiguracionJuego.ColorIncorrecto);
                LimpiarYEnfocarInput();
            }
        }

        private void MostrarFeedback(string mensaje, Color color)
        {
            lblFeedback.Text      = mensaje;
            lblFeedback.ForeColor = color;
        }

        private void BloquearInput()
        {
            btnValidar.Enabled   = false;
            txtRespuesta.Enabled = false;
        }

        private void DesbloquearInput()
        {
            btnValidar.Enabled   = true;
            txtRespuesta.Enabled = true;
        }

        private void EjecutarDespuesDe(int milisegundos, Action accion)
        {
            var temporizadorDeEspera  = new System.Windows.Forms.Timer { Interval = milisegundos };
            temporizadorDeEspera.Tick += (s, args) =>
            {
                temporizadorDeEspera.Stop();
                temporizadorDeEspera.Dispose();
                accion();
            };
            temporizadorDeEspera.Start();
        }

        private void AvanzarAcertijo()
        {
            indiceAcertijoActual++;

            if (NivelCompleto)
                ManejarNivelCompleto();
            else
                PrepararSiguienteAcertijo();
        }

        private void ManejarNivelCompleto()
        {
            timerJuego.Stop();
            MessageBox.Show(
                $"¡Nivel {nivelActual} superado!\nPuntaje: {puntajeTotal}",
                "Nivel completado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            if (EsUltimoNivel)
                TerminarJuego(jugadorGano: true);
            else
                AvanzarAlSiguienteNivel();
        }

        private void AvanzarAlSiguienteNivel()
        {
            nivelActual++;
            CargarNivel();
            timerJuego.Start();
        }

        private void PrepararSiguienteAcertijo()
        {
            jugadorUsoPista = false;
            RefrescarPantalla();
        }

        private void btnPista_Click(object sender, EventArgs e)
        {
            bool jugadorConfirmo = MessageBox.Show(
                "Pedir pista resta puntos. ¿Continuar?",
                "Pista",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes;

            if (jugadorConfirmo)
                MostrarPista();
        }

        private void MostrarPista()
        {
            jugadorUsoPista  = true;
            lblPista.Text    = "Pista: " + AcertijoActual.Pista;
            lblPista.Visible = true;
        }

        private void btnRendirse_Click(object sender, EventArgs e)
        {
            bool jugadorConfirmo = MessageBox.Show(
                "¿Seguro que quieres abandonar?",
                "Abandonar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes;

            if (jugadorConfirmo)
            {
                timerJuego.Stop();
                TerminarJuego(jugadorGano: false);
            }
        }

        private void TerminarJuego(bool jugadorGano)
        {
            timerJuego.Stop();
            RepositorioPuntajes.GuardarResultado(puntajeTotal, jugadorGano, nivelActual);
            MostrarPantallaFinal(jugadorGano);
        }

        private void MostrarPantallaFinal(bool jugadorGano)
        {
            var pantallaFinal = new FormFinal(puntajeTotal, jugadorGano, nivelActual, RepositorioPuntajes.LeerMejorPuntaje());
            pantallaFinal.ShowDialog(this);

            if (pantallaFinal.QuiereReiniciar)
                IniciarPartida();
            else
                Close();
        }
    }
}
