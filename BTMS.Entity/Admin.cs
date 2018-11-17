using System.ComponentModel.DataAnnotations;

namespace BTMS.Entity
{
    public class Admin
    {
        [Key]
        [Required]
        [StringLength(64)]
        public string Username { get; set; }

        [Required]
        [StringLength(64)]
        public string Password { get; set; }
    }
}
