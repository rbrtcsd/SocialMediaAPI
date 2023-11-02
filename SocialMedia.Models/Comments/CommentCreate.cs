using System.ComponentModel.DataAnnotations;

namespace SocialMedia.Models.Comments;

public class CommentCreate
{

    [Required]   
    [MaxLength(100)]
    public string? Text { get; set; }

    public int PostId {get; set;}

}