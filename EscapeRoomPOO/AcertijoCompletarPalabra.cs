using System;

namespace EscapeRoomPOO
{
    public class AcertijoCompletarPalabra : Acertijo
    {
        private readonly string _palabraCorrecta;

        public AcertijoCompletarPalabra(int nivel, Random generadorAleatorio)
        {
            PuntosBase = 80 + nivel * 15;

            string[,] banco        = IdiomaJuego.BancoCompletarPalabra;
            int       indiceAleatorio = generadorAleatorio.Next(0, banco.GetLength(0));

            _palabraCorrecta = banco[indiceAleatorio, 1].ToLower().Trim();

            Pregunta = $"{IdiomaJuego.IntroCompletarPalabra}\n\"{banco[indiceAleatorio, 0]}\"";
            Pista    = IdiomaJuego.PistaCompletarPalabra(_palabraCorrecta.Length, _palabraCorrecta[0]);
        }

        public override bool ValidarRespuesta(string respuesta)
            => respuesta.Trim().ToLower() == _palabraCorrecta;

        public override string ObtenerTipo() => IdiomaJuego.TipoCompletarPalabra;
    }
}
