using System.ComponentModel.DataAnnotations;

namespace Etrans.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}