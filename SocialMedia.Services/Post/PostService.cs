using SocialMedia.Data;
using SocialMedia.Data.Entities;
using SocialMedia.Models.Post;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace SocialMedia.Services.Post;
public class PostService : IPostService
{
    private readonly ApplicationDbContext _dbContext;
    private readonly int _userId;
    public PostService(UserManager<UserEntity> userManager,
                        SignInManager<UserEntity> signInManager,
                        ApplicationDbContext dbContext)
    {
        var currentUser = signInManager.Context.User;
        var userIdClaim = userManager.GetUserId(currentUser);
        var hasValidId = int.TryParse(userIdClaim, out _userId);

        if (hasValidId == false)
            throw new Exception("Unknown user.");

        _dbContext = dbContext;
    }

    public async Task<PostList?> CreatePostAsync(PostCreate request)
    {
        PostEntity entity = new()
        {
            Title = request.Title,
            Text = request.Text,
            AuthorId = _userId
        };

        _dbContext.Posts.Add(entity);
        var numberOfChanges = await _dbContext.SaveChangesAsync();

        if (numberOfChanges != 1)
            return null;

        PostList response = new()
        {
            Id = entity.Id,
            Title = entity.Title
        };
        return response;
    }

    public async Task<IEnumerable<PostList>> GetAllPostsAsync()
    {
        List<PostList> posts = await _dbContext.Posts
            .Where(entity => entity.AuthorId == _userId)
            .Select(entity => new PostList
            {
                Id = entity.Id,
                Title = entity.Title
            })
            .ToListAsync();

        return posts;
    }
}