using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialMedia.Models.Likes;
public class LikeCreate
{
    [Required]
    public int UserId { get; set; }
    
    [Required]
    public int PostId { get; set; }

    public bool Liked { get; set; }
}