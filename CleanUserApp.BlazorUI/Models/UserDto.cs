using System.ComponentModel.DataAnnotations;

namespace CleanUserApp.BlazorUI.Models
{
    public class UserDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; } = string.Empty;

        [Range(1, 120)]
        public int Age { get; set; }
    }
}