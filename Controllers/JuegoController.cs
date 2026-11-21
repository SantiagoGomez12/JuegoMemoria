
using Microsoft.AspNetCore.Mvc;
using JuegoMemoria.Models;

namespace JuegoMemoria.Controllers
{
    public class JuegoController : Controller
    {
        public IActionResult Index(string nivel = "Facil")
        {
            List<string> emojis = new List<string>
            {
                "🍎", "🐶", "⚽", "🚗", "🌟", "🎮",
                "🍕", "🐱", "🎈", "🌈", "🍔", "🐸"
            };

            int cantidadParejas = 4;

                    if (nivel == "Medio")
                    {
                        cantidadParejas = 8;
                    }
                    else if (nivel == "Dificil")
                    {
                        cantidadParejas = 12;
                    }
                    else
                    {
                        nivel = "Facil";
                    }

                        List<string> cartas = emojis
                            .Take(cantidadParejas)
                            .ToList();

            List<string> todasLasCartas = new List<string>();

            foreach (string emoji in cartas)
            {
                        todasLasCartas.Add(emoji);
                        todasLasCartas.Add(emoji);
            }

            Random random = new Random();

            todasLasCartas = todasLasCartas
                .OrderBy(x => random.Next())
                .ToList();

            Juego juego = new Juego();

                    juego.Level = nivel;
                    juego.Cartas = todasLasCartas;
                    juego.Parejas = cantidadParejas;

            return View("~/Views/Home/Index.cshtml", juego);
        }
    }
}
