using System.ComponentModel.DataAnnotations;

namespace vega.Controllers.Resources
{
    public class ContactResorce
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [Required]
        [StringLength(255)]
        public string Phone { get; set; }
    }
}