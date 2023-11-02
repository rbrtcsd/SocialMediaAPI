using SocialMedia.Models.Post;
namespace SocialMedia.Services.Post;

public interface IPostService
{
    Task<bool> CreatePostAsync(PostCreate model)
}