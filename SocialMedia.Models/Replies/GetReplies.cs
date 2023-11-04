using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Models.Replies
{
    public class GetReplies
    {
        [ForeignKey("CommentsEntity")]
        public int CommentsId{get; set;}
    }
}