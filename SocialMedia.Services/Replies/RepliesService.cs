using Microsoft.EntityFrameworkCore;
using SocialMedia.Data;
using SocialMedia.Data.Entities;
using SocialMedia.Models.Replies;
namespace SocialMedia.Services.Replies;

public class RepliesService : IRepliesServices
{
    private readonly ApplicationDbContext _context;
    private RepliesEntity newReply;

    public RepliesService(ApplicationDbContext context)
                
    {
      _context = context;
       
    }
        public async Task<bool>CreateReplyAsync(CreateReplies Model)
        {
              CreateReplies newReplies =new()
             {
                Text = Model.Text,
                CommentsId = Model.CommentsId, 
             };

             _context.Replies.Add(newReply); 
             await _context.SaveChangesAsync();

             return true;
        }
}

    public async Task<bool>GetRepliesbyCommentsId(int CommentsId)
    {
      RepliesEntity? entity = await DbContext.Replies.Find(CommentsId);
      if (entity is null)
      return true;
    }
     


   




