using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarsApi.Data.Models
{
    public class CarModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Make{ get; set; } = string.Empty;
        [Required]
        public string Model { get; set; } = string.Empty;
    }
}
