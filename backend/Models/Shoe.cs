using System.ComponentModel.DataAnnotations;

namespace buyC.Models
{
    public class Shoe
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Category { get; set; }

        public bool IsFeatured { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;


        //public Review? Review { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        //public Category? Category { get; set; }
    }
}
