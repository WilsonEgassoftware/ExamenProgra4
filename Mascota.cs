using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenProgreso1_EgasW.Models
{
    public class Mascota
    {
        [Key]
        public int Id { get; set; }
        public string nombre { get; set; }
        public string raza { get; set; }
        public DateOnly fechaNacimiento { get; set; }
        public string Genero  { get; set; }

        [ForeignKey("idpropietario")]
        public int idPropietario { get; set; }
        // Propiedad de navegación
        [Required]
        public PropietarioMascota PropietarioMascota { get; set; }
    }
}
