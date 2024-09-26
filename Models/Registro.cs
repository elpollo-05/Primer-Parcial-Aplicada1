using System.ComponentModel.DataAnnotations;

namespace JoseBrito_AP1_P1.Models
{
    public class Registro
    {
        [Key]
        public int RegistroId { get; set; }
        [Required]
        public string Descripcion { get; set; }
    }
}
