using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SocialMedia.Data.Entities
{
    public class PostsEntity
    {
        [MaxLength(50), Required]
        public string Title { get; set; } = null!;

        [MaxLength(100), Required]
        public string Text { get; set; } = null!;
        [ForeignKey("Id")]
        public int AuthorId { get; set; }  
       public virtual ICollection<Comment> Comments { get; set; } = null!;
    }
}