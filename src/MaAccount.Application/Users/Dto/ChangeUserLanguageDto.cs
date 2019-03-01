using System.ComponentModel.DataAnnotations;

namespace MaAccount.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}