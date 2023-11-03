using SocialMedia.Data;
using SocialMedia.Data.Entities;
using SocialMedia.Models.Replies;

namespace SocialMedia.Services.Replies;

public class RepliesService : IRepliesService
{
    private readonly ApplicationDbContext _context;

    public RepliesService(ApplicationDbContext context)

    {
        _context = context;

    }
    public async Task<bool> CreateReplyAsync(CreateReplies Model)
    {
        var newReply = new CreateReplies()
        {
            Text = Model.Text,
            CommentsId = Model.CommentsId,
        };

        _context.Replies.Add(newReply);
        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<bool> GetRepliesbyCommentId(GetReplies model)
    {
        RepliesEntity? entity = await _context.Replies.Find(model);
        if (entity is null)
            return true;
    }
}