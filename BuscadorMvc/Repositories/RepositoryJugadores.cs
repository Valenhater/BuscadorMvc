using BuscadorMvc.Data;
using BuscadorMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace BuscadorMvc.Repositories
{
    public class RepositoryJugadores
    {
        private JugadoresContext context;
        public RepositoryJugadores(JugadoresContext context)
        {
            this.context = context;
        }
        public async Task<List<Jugador>> GetAllJugadoresAsync()
        {
            return await this.context.Jugadores.ToListAsync();
        }
        public async Task<List<Jugador>> GetJugadoresByNombreAsync(string nombre)
        {
            var consulta = await this.context.Jugadores.Where(j => j.Nombre.Contains(nombre)).ToListAsync();
            return consulta;
        }
        public async Task<List<Jugador>> GetJugadoresByPosicionAsync(string posicion)
        {
            var consulta = await this.context.Jugadores.Where(j => j.Posicion == posicion).ToListAsync();
            return consulta;
        }
    }
}
