using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialMedia.Models.Post;

public class PostCreate
{

        [Required]
        [MaxLength(50, ErrorMessage = "{0} must be at least {1} characters long.")]
        public string Title {get; set;} = string.Empty;

        [Required]
        [MaxLength(100, ErrorMessage = "{0} must be no more than {1} characters long.")]
        public string Text {get; set;} = string.Empty;
}