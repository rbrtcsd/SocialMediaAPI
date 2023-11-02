using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SocialMedia.Data.Entities;

public class CommentsEntity 
{
    [Key]
    public int Id { get; set; }

    public string? Text { get; set; }

    [ForeignKey("UserEntity")]
    public int UserId { get; set; }
    public virtual UserEntity User { get; set; } = null!;

    [ForeignKey("PostsEntity")]
    public int PostId { get; set; }
    public virtual PostsEntity Post { get; set; } = null!;

    // [MaxLength(300)]

    // public virtual List<PostsEntity> Posts { get; set; } = null!;
}