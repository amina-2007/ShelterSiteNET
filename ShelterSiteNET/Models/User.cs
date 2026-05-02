using System.ComponentModel.DataAnnotations;

namespace ShelterSiteNET.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required] 
        [StringLength(50, ErrorMessage = "Наверное, стоит задуматься о сокращенном варианте?")]
        public string Name { get; set; } = "Волонтер";

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(8, ErrorMessage = "Мы не любим читать скучные и короткие пароли}")] 
        public string Password { get; set; }
        public string Description { get; set; } = "Добро любит тишину!";
    }
}
