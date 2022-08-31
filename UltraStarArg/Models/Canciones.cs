namespace UltraStarArg.Models
{
    public class Canciones
    {
        public int IdCanciones { get; set; }
        public int Fk_ideoma { get; set; }
        public int Fk_artista { get; set; }
        public int Fk_ritmo { get; set; }
        public int Año { get; set; }
        public string Nombre { get; set; }
        public int Duo { get; set; }
        public string Imagen { get; set; }
        public string RutaCancion { get; set; }
    }
}

