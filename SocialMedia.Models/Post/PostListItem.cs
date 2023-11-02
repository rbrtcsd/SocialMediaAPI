using System.Runtime;

namespace SocialMedia.Models.Post;

public class PostListItem
{
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
}