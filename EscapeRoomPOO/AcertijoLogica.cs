using System;

namespace EscapeRoomPOO
{
    public class AcertijoLogica : Acertijo
    {
        private const double MultiplicadorBonusLogica = 1.2;

        private readonly string _respuestaCorrecta;

        private static readonly string[,] BancoDeAcertijos =
        {
            { "¿Qué tiene manos pero no puede aplaudir?",          "reloj",     "Te dice la hora"              },
            { "Mientras más secas, más moja. ¿Qué es?",            "toalla",    "La usas al salir del baño"    },
            { "¿Qué se rompe cuando lo nombras?",                  "silencio",  "Está en una biblioteca"       },
            { "¿Qué avanza pero nunca retrocede?",                 "tiempo",    "No puedes recuperarlo"        },
            { "Cuanto más quitas, más grande se hace. ¿Qué es?",   "pozo",      "Cávalo en la tierra"          },
            { "Si tomas 2 manzanas de 3, ¿cuántas tienes?",        "2",         "Tú tomaste..."                },
            { "¿Qué le pertenece pero otros lo usan más que tú?",  "nombre",    "Te lo pusieron al nacer"      },
            { "En C#, ¿qué palabra redefine un método del padre?", "override",  "Va antes del tipo de retorno" },
            { "¿Qué clase de POO no puede instanciarse directo?",  "abstracta", "Se declara con 'abstract'"    },
            { "¿Cuántos lados suman un triángulo y un cuadrado?",  "7",         "3 + 4"                        }
        };

        public AcertijoLogica(int nivel, Random generadorAleatorio)
        {
            PuntosBase = 90 + nivel * 20;

            int indiceAleatorio = generadorAleatorio.Next(0, BancoDeAcertijos.GetLength(0));
            Pregunta            = BancoDeAcertijos[indiceAleatorio, 0];
            _respuestaCorrecta  = BancoDeAcertijos[indiceAleatorio, 1].ToLower().Trim();
            Pista               = BancoDeAcertijos[indiceAleatorio, 2];
        }

        public override bool ValidarRespuesta(string respuesta)
            => respuesta.Trim().ToLower() == _respuestaCorrecta;

        public override string ObtenerTipo() => "Lógica";

        public override int CalcularPuntos(int segundosRestantes, bool usoPista)
            => (int)(base.CalcularPuntos(segundosRestantes, usoPista) * MultiplicadorBonusLogica);
    }
}
