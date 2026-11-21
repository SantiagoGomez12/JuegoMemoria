namespace JuegoMemoria.Models
{
    public class Juego
    {
        public string Level { get; set; }

        public List<string> Cartas { get; set; }

        public int Parejas { get; set; }
    }
}
