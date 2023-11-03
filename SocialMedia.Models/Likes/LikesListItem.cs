using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Models.Likes
{
    public class LikesListItem
    {
        public int PostId { get; set; }

        public bool Liked { get; set; }
    }
}