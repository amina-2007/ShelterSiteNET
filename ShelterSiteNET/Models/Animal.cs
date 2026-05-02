using System.ComponentModel.DataAnnotations;

namespace ShelterSiteNET.Models
{
    public class Animal
    {
        public int Id { get; set; }

        [Required] 
        [StringLength(30, ErrorMessage ="Наверное, стоит задуматься о сокращенном варианте?")]
        public string Name { get; set; } = "Неназванный";
        public string Description { get; set; } = "История умалчивает. Главное, что питомец сейчас в надежном месте и ищет друга!";

        [Range(0,50, ErrorMessage ="Минус шестьдесят семь лет?")]
        [Required]
        public Double Age { get; set; }

        [StringLength(30, ErrorMessage = "Пока что поддерживаются только земные породы.")]
        public string Breed { get; set; } = "Дворняжка";
        public string ImagePath { get; set; } = "images/unneccesary_ability.png";
    }
}
