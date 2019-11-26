using System.ComponentModel.DataAnnotations;

namespace TEST.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}