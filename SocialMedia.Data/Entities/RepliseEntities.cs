
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.AspNetCore.Identity;

namespace SocialMedia.Data.Entities
{
    public class RepliesEntity : IdentityUser<int>
    {
       
        [Required] 
        public string Text { get; set; } = null!;
        [ForeignKey("Id")]
        public int ParentId{get; set;}
        [ForeignKey("Id")]
        public int AuthorId{get; set;}

    }
}