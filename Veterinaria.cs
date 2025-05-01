using System.ComponentModel.DataAnnotations;

namespace ExamenProgreso1_EgasW.Models
{
    public class Veterinaria
    {
        [Key]
        public int Id { get; set; }
        public string fechadevisita { get; set; }
        public string motivovisita { get; set; }

        [Required]

        public string nombreVeterinario { get; set; }
        public bool vacunas { get; set; }

        public decimal costo { get; set; }

        

    }
}
