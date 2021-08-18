using System.ComponentModel.DataAnnotations;

namespace RevisionControl.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}