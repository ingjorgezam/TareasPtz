using Microsoft.EntityFrameworkCore;
using proyectoef.Models;

namespace proyectoef
{
    public class TareasContext: DbContext
    {
        //Son las colecciones que representan las tablas en la base de datos
        //Tablas
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
        
        //Método base del contructor de EF
        //Base() =  es un método  de la calse DbContext

        public TareasContext(DbContextOptions<TareasContext> options) : base(options) { }
        
        // método que se invoca al momento de hacer la creación la DB por Ef
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configuración del modelo de categorías
            modelBuilder.Entity<Categoria>(categoria =>
            {
                //llamamos a cada método que necesitemos para hacer la configuración
                categoria.ToTable("Categoria");
                categoria.HasKey(p => p.CategoriaId);
                categoria.Property(p => p.Nombre).IsRequired().HasMaxLength(150);
                categoria.Property(p => p.Descripcion);
            });

            modelBuilder.Entity<Tarea>(tarea =>
            {
                tarea.ToTable("Tarea");
                tarea.HasKey(p => p.TareaId);

                //Propiedad dentro de tarea que se llama Categoria, tiene relación con múltiples  tareas
                //relación propiedad virtual de categoria (en tareas) con la colección de tareas en Categorias
                
                tarea.HasOne(p => p.Categoria).WithMany(p => p.Tareas).HasForeignKey(p => p.CategoriaId);

                tarea.Property(p => p.Titulo).IsRequired().HasMaxLength(200);
                tarea.Property(p => p.Descripcion);
                tarea.Property(p => p.PrioridadTarea);
                tarea.Property(p => p.FechaCreacion);
                tarea.Ignore(p => p.Resumen);

            });
        }
    }
}
