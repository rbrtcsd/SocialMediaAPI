using SocialMedia.Models.Replies;

namespace SocialMedia.Services.Replies;

public interface IRepliesService
{
      Task<bool>CreateReplyAsync(CreateReplies Model);
      Task<bool> GetRepliesbyCommentId(GetReplies model);
}
