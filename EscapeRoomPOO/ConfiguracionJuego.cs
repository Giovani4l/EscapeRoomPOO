using System.Drawing;

namespace EscapeRoomPOO
{
    public static class ConfiguracionJuego
    {
        public const int TotalNiveles             = 5;
        public const int AcertijosPorNivel        = 3;
        public const int SegundosPorNivel         = 60;
        public const int MsEsperaRespuestaCorrecta = 800;
        public const int MsEsperaDerrota          = 1200;
        public const int SegundosAlertaTimer      = 10;

        public static readonly Color ColorCorrecto      = Color.FromArgb(46,  204, 113);
        public static readonly Color ColorIncorrecto    = Color.FromArgb(192, 57,  43);
        public static readonly Color ColorPanelCorrecto = Color.FromArgb(220, 245, 220);
        public static readonly Color ColorPanelError    = Color.FromArgb(245, 220, 220);
        public static readonly Color ColorTimerNormal   = Color.FromArgb(46,  204, 113);
        public static readonly Color ColorTimerAlerta   = Color.OrangeRed;
        public static readonly Color ColorVictoria      = Color.FromArgb(39,  174, 96);
        public static readonly Color ColorDerrota       = Color.FromArgb(192, 57,  43);
        public static readonly Color ColorRecord        = Color.FromArgb(255, 235, 59);

        public const int NivelParaOperacionesAvanzadas = 3;
    }
}
