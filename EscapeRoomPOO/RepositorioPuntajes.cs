using System;
using System.IO;

namespace EscapeRoomPOO
{
    public static class RepositorioPuntajes
    {
        private static readonly string RutaArchivo = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "puntajes.txt");

        public static void GuardarResultado(int puntaje, bool jugadorGano, int nivelAlcanzado)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(RutaArchivo));
                string registro = $"{DateTime.Now:dd/MM/yyyy HH:mm} | Puntaje: {puntaje} | Nivel: {nivelAlcanzado} | {(jugadorGano ? "GANÓ" : "PERDIÓ")}";
                File.AppendAllText(RutaArchivo, registro + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"No se pudo guardar el resultado: {ex.Message}");
            }
        }

        public static string LeerMejorPuntaje()
        {
            try
            {
                if (!File.Exists(RutaArchivo)) return "0";

                int mejorPuntaje = 0;
                foreach (string registro in File.ReadAllLines(RutaArchivo))
                {
                    int puntajeEncontrado = ExtraerPuntajeDeRegistro(registro);
                    if (puntajeEncontrado > mejorPuntaje)
                        mejorPuntaje = puntajeEncontrado;
                }
                return mejorPuntaje.ToString();
            }
            catch (Exception) { return "0"; }
        }

        public static string LeerHistorial()
        {
            try
            {
                return File.Exists(RutaArchivo)
                    ? File.ReadAllText(RutaArchivo)
                    : "Aún no hay partidas registradas.";
            }
            catch (Exception) { return "No se pudo leer el historial."; }
        }

        private static int ExtraerPuntajeDeRegistro(string registro)
        {
          
            int posicion = registro.IndexOf("Puntaje: ");
            if (posicion < 0) return 0;

            string[] partes = registro.Substring(posicion + 9).Split(' ');
            return int.TryParse(partes[0], out int puntajeEncontrado) ? puntajeEncontrado : 0;
        }
    }
}
