using System.ComponentModel.DataAnnotations;

namespace ExamenProgreso1_EgasW.Models
{
    public class PropietarioMascota
    {
        [Key]
        public int Id { get; set; }
        public string nombre { get; set; }
        
        public DateOnly fechaNacimiento { get; set; }
        [Required]
        public decimal cedula { get; set; }
        public string telefono { get; set; }


    }
}
