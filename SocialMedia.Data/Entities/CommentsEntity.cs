using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SocialMedia.Data.Entities;

public class CommentsEntity 
{
    [Key]
    public int Id { get; set; }

    [ForeignKey(nameof(UserEntity))]
    public int UserId { get; set; }

    [ForeignKey(nameof(PostsEntity))]
    public int PostId { get; set; }

    [MaxLength(300)]
    public string? Text { get; set; }

    public virtual List<PostsEntity> Posts { get; set; } = null!;
}