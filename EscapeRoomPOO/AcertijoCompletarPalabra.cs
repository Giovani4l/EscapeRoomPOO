using System;

namespace EscapeRoomPOO
{
    public class AcertijoCompletarPalabra : Acertijo
    {
        private readonly string _palabraCorrecta;

        private static readonly string[,] BancoDeOraciones =
        {
            { "El cielo es de color ___.",           "azul"         },
            { "El perro mueve la ___.",               "cola"         },
            { "La Tierra gira alrededor del ___.",    "sol"          },
            { "El agua moja, el fuego ___.",          "quema"        },
            { "En código, un ___ es un error.",       "bug"          },
            { "El opuesto de verdadero es ___.",      "falso"        },
            { "Una ___ define un contrato en POO.",   "interfaz"     },
            { "Una clase sin cuerpo es ___.",         "abstracta"    },
            { "Redefinir un método es ___.",          "sobreescribir"},
            { "SOLID son ___ de diseño.",             "principios"   }
        };

        public AcertijoCompletarPalabra(int nivel, Random generadorAleatorio)
        {
            PuntosBase = 80 + nivel * 15;

            int indiceAleatorio = generadorAleatorio.Next(0, BancoDeOraciones.GetLength(0));
            _palabraCorrecta    = BancoDeOraciones[indiceAleatorio, 1].ToLower().Trim();

            Pregunta = $"Completa la oración:\n\"{BancoDeOraciones[indiceAleatorio, 0]}\"";
            Pista    = $"La palabra tiene {_palabraCorrecta.Length} letras y empieza con '{_palabraCorrecta[0]}'";
        }

        public override bool ValidarRespuesta(string respuesta)
            => respuesta.Trim().ToLower() == _palabraCorrecta;

        public override string ObtenerTipo() => "Completar palabra";
    }
}
