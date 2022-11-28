using Microsoft.EntityFrameworkCore;
using proyectoef.Models;

namespace proyectoef
{
    public class TareasContext: DbContext
    {
        //Tablas
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
        
        //Método base del contructor de EF
        //Base() =  es un método  de la calse DbContext

        public TareasContext(DbContextOptions<TareasContext> options) : base(options) { }
    }
}
