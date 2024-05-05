using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class ApplicationModel
    {
        [Key]
        public string ApplicationId { get; set; }

        [Required]
        public string JobListingId { get; set; }

        [Required]
        public string? Message { get; set; }

        // Navigation property if needed
        public string? Description { get; set; }

        public bool? status { get; set; }

    }
}
