using System.ComponentModel.DataAnnotations;

namespace SocialMedia.Models.Post;

public class PostCreate
{
[Required, MaxLength(50)]
public string Title { get; set; } = string.Empty;
[Required, MaxLength(100)]
public string Text { get; set; } = string.Empty;
[Required]
public int AuthorId { get; set; }
}