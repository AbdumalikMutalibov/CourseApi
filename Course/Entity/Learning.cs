using System.ComponentModel.DataAnnotations;

namespace Course.Entity
{
    public class Learning
    {  
        [Key]
        public Guid Id { get; set; }
        [Required, MinLength(2), MaxLength(15)]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        public DateTime StartTime { get; set; }
        [Required, MaxLength(50)]
        public string teacher { get; set; }
    }
}