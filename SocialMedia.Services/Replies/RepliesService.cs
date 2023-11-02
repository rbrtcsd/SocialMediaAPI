using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SocialMedia.Data;
using SocialMedia.Data.Entities;
using SocialMedia.Models.Replies;
using SocialMedia.Services.Replies;
using static System.Net.Mime.MediaTypeNames;

namespace SocialMedia.Services.Replies;

public class RepliesService : IRepliesService
{
    private readonly ApplicationDbContext _context;

    public RepliesService(ApplicationDbContext context)
                
    {
      _context = context;
       
    }
        public async Task<bool>CreateReplyAsync(CreateReplies Model)
        {
              var  newReply = new CreateReplies()
             {
                Text = Model.Text,
                CommentsId = Model.CommentsId, 
             };

             _context.Replies.Add(newReply); 
             await _context.SaveChangesAsync();

             return true;
        }  
}
    public async Task<bool>GetRepliesbyCommentId(int CommentsId)
    {
      RepliesEntity? entity = await DbContext.Replies.Find(CommentsId);
      if (entity is null)
      return true;
    }
     
    

   




