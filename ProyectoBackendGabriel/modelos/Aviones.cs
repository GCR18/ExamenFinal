using System.ComponentModel.DataAnnotations;

namespace ProyectoBackendGabriel.modelos
{
    public class Aviones
    {
        [Key]
        public int id_avion { get; set; }
        public string numero_serie_avion { get; set; }
        public string modelo_avion { get; set; }
        public int capacidad_pasajeros { get; set; }
        public int autonomia_vuelo { get; set; }
    }
}
