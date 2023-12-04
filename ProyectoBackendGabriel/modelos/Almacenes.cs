using System.ComponentModel.DataAnnotations;

namespace ProyectoBackendGabriel.modelos
{
    public class Almacenes
    {
        [Key]
        public int id_almacen { get; set; }
        public int numero_almacen { get; set; }
        public int capacidad_almacen { get; set; }
        public string ubicacion_almacen { get; set; }

    }
}
