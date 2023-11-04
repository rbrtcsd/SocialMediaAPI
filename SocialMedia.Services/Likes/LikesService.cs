using SocialMedia.Data;
using SocialMedia.Data.Entities;
using SocialMedia.Models.Likes;

namespace SocialMedia.Services.Likes;
public class LikesService : ILikesService
{
    private readonly ApplicationDbContext _dbContext;

    public LikesService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<LikesListItem> CreateLikeOnPost(LikeCreate model)
    {
        LikesEntity entity = new()
        {
            UserId = model.UserId,
            PostId = model.PostId,
            Liked = model.Liked
        };

        _dbContext.Likes.Add(entity);
        var numberOfChanges = await _dbContext.SaveChangesAsync();

        if (numberOfChanges != 1)
            return null;

            LikesListItem response = new()
        {
            PostId = entity.PostId,
            Liked = entity.Liked,
        };
        return response;
    }
}