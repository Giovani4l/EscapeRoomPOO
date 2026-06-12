using System;

namespace EscapeRoomPOO
{
    public class PartidaGuardada
    {
        public int    Id                { get; set; }
        public string Nombre            { get; set; }
        public int    NivelActual       { get; set; }
        public int    PuntajeTotal      { get; set; }
        public int    IndiceAcertijo    { get; set; }
        public int    SegundosRestantes { get; set; }
        public string Idioma            { get; set; }
        public string FechaGuardado     { get; set; }

        public string ResumenParaMostrar =>
            $"[{Id}] {Nombre}  —  Nivel {NivelActual}  |  {PuntajeTotal} pts  |  {FechaGuardado}";
    }
}
