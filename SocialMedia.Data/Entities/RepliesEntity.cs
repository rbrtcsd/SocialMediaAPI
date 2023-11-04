using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.AspNetCore.Identity;

namespace SocialMedia.Data.Entities
{
    public class RepliesEntity
    {
        [Key]
        public int Id { get; set; }

        [Required] 
        public string Text { get; set; } = null!;

        [ForeignKey("CommentsEntity")]
        public int CommentsId{get; set;}
        public virtual CommentsEntity Comments { get; set; } = null!;

        [ForeignKey("UserEntity")]
        public int UserId{get; set;}
        public virtual UserEntity User { get; set; } = null!;
    }
}