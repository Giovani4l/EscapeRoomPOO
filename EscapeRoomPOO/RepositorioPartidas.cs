using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EscapeRoomPOO
{
    public static class RepositorioPartidas
    {
        public const int MaximoRanuras = 5;

        private static readonly string RutaArchivo = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "partidas.json");

       
        public static bool GuardarPartida(PartidaGuardada partida)
        {
            try
            {
                List<PartidaGuardada> partidas = CargarTodas();

                if (partidas.Count >= MaximoRanuras)
                    return false;

                partida.Id           = GenerarNuevoId(partidas);
                partida.FechaGuardado = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

                partidas.Add(partida);
                EscribirJson(partidas);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"No se pudo guardar la partida: {ex.Message}");
                return false;
            }
        }

        
        public static void EliminarPartida(int id)
        {
            try
            {
                List<PartidaGuardada> partidas = CargarTodas();
                partidas.RemoveAll(p => p.Id == id);
                EscribirJson(partidas);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"No se pudo eliminar la partida: {ex.Message}");
            }
        }

     
        public static List<PartidaGuardada> CargarTodas()
        {
            try
            {
                if (!File.Exists(RutaArchivo))
                    return new List<PartidaGuardada>();

                string json = File.ReadAllText(RutaArchivo, Encoding.UTF8);
                return DeserializarLista(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"No se pudo leer las partidas: {ex.Message}");
                return new List<PartidaGuardada>();
            }
        }

        public static bool HayRanurasDisponibles() => CargarTodas().Count < MaximoRanuras;
        public static bool HayPartidasGuardadas()  => CargarTodas().Count > 0;

    
        private static void EscribirJson(List<PartidaGuardada> partidas)
        {
            string json = SerializarLista(partidas);
            File.WriteAllText(RutaArchivo, json, Encoding.UTF8);
        }

        private static string SerializarLista(List<PartidaGuardada> partidas)
        {
            var sb = new StringBuilder();
            sb.AppendLine("[");

            for (int i = 0; i < partidas.Count; i++)
            {
                PartidaGuardada p = partidas[i];
                sb.AppendLine("  {");
                sb.AppendLine($"    \"Id\": {p.Id},");
                sb.AppendLine($"    \"Nombre\": \"{EscaparJson(p.Nombre)}\",");
                sb.AppendLine($"    \"NivelActual\": {p.NivelActual},");
                sb.AppendLine($"    \"PuntajeTotal\": {p.PuntajeTotal},");
                sb.AppendLine($"    \"IndiceAcertijo\": {p.IndiceAcertijo},");
                sb.AppendLine($"    \"SegundosRestantes\": {p.SegundosRestantes},");
                sb.AppendLine($"    \"Idioma\": \"{EscaparJson(p.Idioma)}\",");
                sb.AppendLine($"    \"FechaGuardado\": \"{EscaparJson(p.FechaGuardado)}\"");
                sb.Append("  }");
                sb.AppendLine(i < partidas.Count - 1 ? "," : "");
            }

            sb.Append("]");
            return sb.ToString();
        }

        private static List<PartidaGuardada> DeserializarLista(string json)
        {
            var partidas = new List<PartidaGuardada>();
            json = json.Trim().TrimStart('[').TrimEnd(']');

            string[] bloques = SepararBloques(json);
            foreach (string bloque in bloques)
            {
                PartidaGuardada partida = DeserializarPartida(bloque.Trim());
                if (partida != null)
                    partidas.Add(partida);
            }

            return partidas;
        }

        private static string[] SepararBloques(string json)
        {
            var bloques = new List<string>();
            int profundidad = 0;
            int inicio      = -1;

            for (int i = 0; i < json.Length; i++)
            {
                if (json[i] == '{') { if (profundidad++ == 0) inicio = i; }
                else if (json[i] == '}') { if (--profundidad == 0 && inicio >= 0) bloques.Add(json.Substring(inicio, i - inicio + 1)); }
            }

            return bloques.ToArray();
        }

        private static PartidaGuardada DeserializarPartida(string bloque)
        {
            try
            {
                return new PartidaGuardada
                {
                    Id                = int.Parse(ExtraerValor(bloque, "Id")),
                    Nombre            = ExtraerValor(bloque, "Nombre"),
                    NivelActual       = int.Parse(ExtraerValor(bloque, "NivelActual")),
                    PuntajeTotal      = int.Parse(ExtraerValor(bloque, "PuntajeTotal")),
                    IndiceAcertijo    = int.Parse(ExtraerValor(bloque, "IndiceAcertijo")),
                    SegundosRestantes = int.Parse(ExtraerValor(bloque, "SegundosRestantes")),
                    Idioma            = ExtraerValor(bloque, "Idioma"),
                    FechaGuardado     = ExtraerValor(bloque, "FechaGuardado"),
                };
            }
            catch { return null; }
        }

        private static string ExtraerValor(string json, string clave)
        {
            string buscador = $"\"{clave}\":";
            int posicion    = json.IndexOf(buscador);
            if (posicion < 0) return "";

            int inicio = posicion + buscador.Length;
            while (inicio < json.Length && json[inicio] == ' ') inicio++;

            if (json[inicio] == '"')
            {
                int fin = json.IndexOf('"', inicio + 1);
                return json.Substring(inicio + 1, fin - inicio - 1);
            }
            else
            {
                int fin = inicio;
                while (fin < json.Length && json[fin] != ',' && json[fin] != '}' && json[fin] != '\n') fin++;
                return json.Substring(inicio, fin - inicio).Trim();
            }
        }

        private static string EscaparJson(string texto)
            => texto?.Replace("\\", "\\\\").Replace("\"", "\\\"") ?? "";

        private static int GenerarNuevoId(List<PartidaGuardada> partidas)
        {
            int idMaximo = 0;
            foreach (PartidaGuardada p in partidas)
                if (p.Id > idMaximo) idMaximo = p.Id;
            return idMaximo + 1;
        }
    }
}
