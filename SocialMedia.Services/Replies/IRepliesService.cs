using SocialMedia.Models.Replies;
namespace SocialMedia.Service.Replies;

public interface IRepliesService
{
      public async Task<bool>CreateReplyAsync(CreateReplies Model)
}
