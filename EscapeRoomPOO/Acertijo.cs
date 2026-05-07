using System;

namespace EscapeRoomPOO
{
    public abstract class Acertijo : IResoluble
    {
        public string Pregunta   { get; set; }
        public string Pista      { get; set; }
        public int    Intentos   { get; set; } = 3;
        public int    PuntosBase { get; set; }

        public bool TieneIntentos => Intentos > 0;

        public abstract bool ValidarRespuesta(string respuesta);
        public abstract string ObtenerTipo();

        public bool Resolver(string respuesta)
        {
            if (!TieneIntentos) return false;
            Intentos--;
            return ValidarRespuesta(respuesta);
        }

        public virtual int CalcularPuntos(int segundosRestantes, bool usoPista)
        {
            int bonusPorVelocidad  = segundosRestantes * 2;
            int penalizacionPista  = usoPista ? PuntosBase / 3 : 0;
            int puntosFinales      = PuntosBase + bonusPorVelocidad - penalizacionPista;
            return Math.Max(puntosFinales, 0);
        }
    }
}
