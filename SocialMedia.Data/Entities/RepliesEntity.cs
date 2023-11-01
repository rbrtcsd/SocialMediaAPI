
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

        [ForeignKey(nameof(CommentsEntity))]
        public int CommentsId{get; set;}

        [ForeignKey(nameof(UserEntity))]
        public int UserId{get; set;}
    }
}