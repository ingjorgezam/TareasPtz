using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyectoef.Models
{
    //Cada Tarea va a tener asignada una categoria
    public class Tarea
    {
        //[Key]
        public Guid TareaId { get; set; }

        //Relación de la tarea con la categoria
        //[ForeignKey("CategoriaId")] // DataAnnotations.Schema, dentro de los ("nombreDeLaRelación")
        public Guid CategoriaId { set; get; }
        //[Required]
        //[MaxLength(200)]


        public string Titulo { set; get; }
        public string Descripcion { set; get; }
        public Prioridad PrioridadTarea { set; get; }   
        public DateTime FechaCreacion { set; get; } 

        //Propiedad para relacionarla con Categoria
        public virtual Categoria Categoria { set; get; }

       // [NotMapped] //Omite esta propiedad al momento de hacer el mapeo del conexto a la base de datos.
                    //No se crea este campo en la base de datos.
        public string Resumen { set; get; }


    }

    public enum Prioridad
    {
        Baja,
        Media,
        Alta
    }


}
