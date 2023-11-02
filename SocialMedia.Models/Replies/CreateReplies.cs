using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace SocialMedia.Models.Replies
{
    public class CreateReplies
    {
        [Required]
        [MaxLength (100)]
        public string? Text { get; set; } 

        public int CommentsId{get; set;}
    }
}