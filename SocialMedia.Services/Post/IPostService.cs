using SocialMedia.Models.Post;

namespace SocialMedia.Services.Post;

public interface IPostService
{
    Task<PostList?> CreatePostAsync(PostCreate request);
    Task<IEnumerable<PostList>> GetAllPostsAsync();
}