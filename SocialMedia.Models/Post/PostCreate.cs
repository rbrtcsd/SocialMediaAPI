using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialMedia.Models.Post;

public class PostCreate
{

        [Required]
        [MaxLength(50, ErrorMessage = "Title cannot be more than 50 characters.")]
        public string Title {get; set;} = string.Empty;

        [Required]
        [MaxLength(100, ErrorMessage = "Text cannot be more than 100 characters.")]
        public string Text {get; set;} = string.Empty;
}