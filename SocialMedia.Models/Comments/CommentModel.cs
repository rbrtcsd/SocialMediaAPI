using System.ComponentModel.DataAnnotations;

namespace SocialMedia.Models.Comments;

public class CommentModel
{

    [Required]   
    [MaxLength(100)]
    public string? Text { get; set; }

}