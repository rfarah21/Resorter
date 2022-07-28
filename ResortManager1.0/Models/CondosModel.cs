using System.ComponentModel.DataAnnotations;

namespace Resort_Management.Models
{
    public class CondosModel
    {
        [Key]
        public int condosId { get; set; }
        [Required]
        public string condosLocation { get; set; }
        public int condosCapacity { get; set; }
    }
}
