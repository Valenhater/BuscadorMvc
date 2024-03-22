using BuscadorMvc.Models;
using BuscadorMvc.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BuscadorMvc.Controllers
{
    public class JugadoresController : Controller
    {
        private RepositoryJugadores repo;
        public JugadoresController(RepositoryJugadores repo)
        {
            this.repo = repo;
        }
        public async Task<IActionResult> Jugadores(string nombre = null, string posicion = null)
        {
            List<Jugador> jugadores = new List<Jugador>(); 

            if (!string.IsNullOrEmpty(nombre))
            {
                jugadores = await this.repo.GetJugadoresByNombreAsync(nombre);
            }
            else if (!string.IsNullOrEmpty(posicion))
            {
                jugadores = await this.repo.GetJugadoresByPosicionAsync(posicion);
            }
            else
            {
                jugadores = await this.repo.GetAllJugadoresAsync(); 
            }

            return View(jugadores);
        }

    }
}
