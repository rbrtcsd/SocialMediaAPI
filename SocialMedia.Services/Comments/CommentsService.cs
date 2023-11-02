using System;
using System.Net;
using System.Threading.Tasks; 
using Microsoft.EntityFrameworkCore;
using SocialMedia.Models.Comments;

using SocialMedia.Data;


namespace SocialMedia.Services.Comments
{
    public class CommentsService : ICommentsService
    {
        private readonly ApplicationDbContext _context;

        public CommentsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CommentCreateAsync(CommentCreate model)

        {
            var newComment = new Comment
            {
        
                Text = model.Text,
                Post = model.PostId,
    
            };

            _context.Comments.Add(newComment);
           await _context.SaveChangesAsync();


            return true;
        }
     }
}
