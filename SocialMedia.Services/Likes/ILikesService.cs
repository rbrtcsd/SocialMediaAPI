using SocialMedia.Models.Likes;

namespace SocialMedia.Services.Likes;

public interface ILikesService
{
    Task<LikesListItem> CreateLikeOnPost(LikeCreate model);
}