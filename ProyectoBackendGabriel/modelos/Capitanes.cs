using System.ComponentModel.DataAnnotations;

namespace ProyectoBackendGabriel.modelos
{
    public class Capitanes
    {
        [Key]
        public int id_capitan { get; set; }
        public string numero_licencia_capitan { get; set; }
        public string nombre_capitan { get; set; }
        public int salario_capitan { get; set; }
        public string turno_capitan { get; set; }

    }
}
