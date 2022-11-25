namespace proyectoef.Models
{
    public class Categoria
    {
        public Guid CategoriaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        //Propiedad para relacionarla con Tarea, de tipo icolelction
        //Con esta propiedad se puede traer todas las tareas asociadas a esa categoría
        public virtual ICollection<Tarea> Tareas { get; set; }

    }
}
