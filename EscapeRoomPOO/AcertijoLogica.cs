using System;

namespace EscapeRoomPOO
{
    public class AcertijoLogica : Acertijo
    {
        private const double MultiplicadorBonusLogica = 1.2;

        private readonly string _respuestaCorrecta;

        public AcertijoLogica(int nivel, Random generadorAleatorio)
        {
            PuntosBase = 90 + nivel * 20;

            string[,] banco        = IdiomaJuego.BancoLogica;
            int       indiceAleatorio = generadorAleatorio.Next(0, banco.GetLength(0));

            Pregunta           = banco[indiceAleatorio, 0];
            _respuestaCorrecta = banco[indiceAleatorio, 1].ToLower().Trim();
            Pista              = banco[indiceAleatorio, 2   ];
        }

        public override bool ValidarRespuesta(string respuesta)
            => respuesta.Trim().ToLower() == _respuestaCorrecta;

        public override string ObtenerTipo() => IdiomaJuego.TipoLogica;

        public override int CalcularPuntos(int segundosRestantes, bool usoPista)
            => (int)(base.CalcularPuntos(segundosRestantes, usoPista) * MultiplicadorBonusLogica);
    }
}
