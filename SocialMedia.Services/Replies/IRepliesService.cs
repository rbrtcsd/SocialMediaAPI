using SocialMedia.Models.Replies;
using SocialMedia.Services.User;

namespace SocialMedia.Service.Replise;

public interface IRepliesService
{
    Task<bool>CreateReplyAsync(CreateReplies Model);
}
