using BuscadorMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace BuscadorMvc.Data
{
    public class JugadoresContext: DbContext
    {
        public JugadoresContext(DbContextOptions<JugadoresContext> options) : base(options) { }
        public DbSet<Jugador> Jugadores { get; set; }
    }
}
