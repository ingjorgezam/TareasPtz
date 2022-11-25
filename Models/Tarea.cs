namespace proyectoef.Models
{
    //Cada Tarea va a tener asignada una categoria
    public class Tarea
    {
        public Guid TareaId { get; set; }
        //Relación de la tarea con la categoria
        public Guid CategoriaId { set; get; }
        public string Titulo { set; get; }
        public string Descripcion { set; get; }
        public Prioridad PrioridadTarea { set; get; }   
        public DateTime FechaCreacion { set; get; } 

        //Propiedad para relacionarla con Categoria
        public virtual Categoria Categoria { set; get; }


    }

    public enum Prioridad
    {
        Baja,
        Media,
        Alta
    }


}
