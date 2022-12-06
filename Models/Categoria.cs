using System.ComponentModel.DataAnnotations;

namespace proyectoef.Models
{
    public class Categoria
    {
        //[Key] //Cñave principal
        public Guid CategoriaId { get; set; }


        //[Required] //Requerido
        //[MaxLength(150)] //Espacio máximo de este campo.
        
        public string Nombre { get; set; }
        
        public string Descripcion { get; set; }
        //Propiedad para relacionarla con Tarea, de tipo icolelction
        //Con esta propiedad se puede traer todas las tareas asociadas a esa categoría
        public virtual ICollection<Tarea> Tareas { get; set; }

    }
}
