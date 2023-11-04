using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialMedia.Data.Entities;

public class LikesEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    [ForeignKey(nameof(Likes))]
    public int UserId { get; set; }
    public LikesEntity Likes {get; set;} = null!;

    [Required]
    public int PostId { get; set; }

    [Required]
    public bool Liked { get; set; }

}