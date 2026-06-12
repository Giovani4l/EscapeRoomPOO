using System;

namespace EscapeRoomPOO
{
    public class AcertijoMatematico : Acertijo
    {
        private readonly int _respuestaCorrecta;

        private static readonly string[] OperacionesBasicas   = { "+", "-" };
        private static readonly string[] OperacionesAvanzadas = { "+", "-", "x" };

        public AcertijoMatematico(int nivel, Random generadorAleatorio)
        {
            PuntosBase = 100 + nivel * 20;

            string[] operacionesDisponibles = nivel < ConfiguracionJuego.NivelParaOperacionesAvanzadas
                ? OperacionesBasicas
                : OperacionesAvanzadas;

            string operacion = operacionesDisponibles[generadorAleatorio.Next(operacionesDisponibles.Length)];

            int operandoA = generadorAleatorio.Next(1, 10 + nivel * 5);
            int operandoB = generadorAleatorio.Next(1, 10 + nivel * 5);

            _respuestaCorrecta = AplicarOperacion(operacion, ref operandoA, ref operandoB, generadorAleatorio);

            Pregunta = IdiomaJuego.PreguntaMatematica(operandoA, operacion, operandoB);
            Pista    = IdiomaJuego.PistaMatematica(_respuestaCorrecta - 3, _respuestaCorrecta + 3);
        }

        private int AplicarOperacion(string operacion, ref int operandoA, ref int operandoB, Random generadorAleatorio)
        {
            switch (operacion)
            {
                case "+": return operandoA + operandoB;
                case "-":
                    if (operandoA < operandoB) { int temporal = operandoA; operandoA = operandoB; operandoB = temporal; }
                    return operandoA - operandoB;
                default:
                    operandoA = generadorAleatorio.Next(2, 10);
                    operandoB = generadorAleatorio.Next(2, 10);
                    return operandoA * operandoB;
            }
        }

        public override bool ValidarRespuesta(string respuesta)
            => int.TryParse(respuesta.Trim(), out int resultado) && resultado == _respuestaCorrecta;

        public override string ObtenerTipo() => IdiomaJuego.TipoMatematicas;
    }
}
