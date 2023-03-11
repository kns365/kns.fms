using System.ComponentModel.DataAnnotations;

namespace kns.fms.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}