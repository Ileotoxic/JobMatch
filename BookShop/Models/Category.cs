using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class Category
    {
        [Key]
        public string CategoryId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public required string Name { get; set; }

        public string? Description { get; set; }
        public bool? Status{ get; set; }
    }
}
