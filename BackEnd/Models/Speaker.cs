using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models
{
    public class Speaker
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string  Bio { get; set; }

        [StringLength(100)]
        public virtual string  WebSite { get; set; }
    }
}
