using SocialMedia.Models.Post;

namespace SocialMedia.Services.Post;

public interface IPostService
{
    Task<PostListItem?> CreateNoteAsync(PostCreate request);
    Task<IEnumerable<PostListItem>> GetAllPostsAsync();
}