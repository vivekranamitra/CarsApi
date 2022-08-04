using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarsApi.Data.Models
{
    public class UserModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; } = string.Empty;

        [Required]
        public string UserName { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
