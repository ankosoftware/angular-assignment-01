using System.ComponentModel.DataAnnotations;

namespace ANKO.AgEmailSender.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}