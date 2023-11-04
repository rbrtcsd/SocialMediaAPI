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
        RepliesEntity entity = new()
        {
            Text = Model.Text,
            CommentsId = Model.CommentsId,
        };

        _context.Replies.Add(entity);
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