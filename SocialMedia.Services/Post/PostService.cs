using SocialMedia.Models.Post;
using SocialMedia.Data.Entities;

namespace SocialMedia.Services.Post;

public class PostService : IPostService
{
    public async Task<bool> CreatePostAsync(PostCreate model)
    {
        Title = model.Title,
        Text = model.Text,
        AuthorId = model.AuthorId,
    };
}