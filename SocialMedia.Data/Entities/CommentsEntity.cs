using System;
using System.ComponentModel.DataAnnotations;


namespace SocialMedia.Data.Entities;

public class CommentsEntity 
{
    public int CommentId { get; set; }
    public int UserId { get; set; }
    public int PostId { get; set; }

    [MaxLength(300)]
    public string? Text { get; set; }
    public DateTime CreatedAt { get; set; }

}