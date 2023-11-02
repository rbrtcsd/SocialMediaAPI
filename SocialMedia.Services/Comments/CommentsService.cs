using System;
using System.Net;
using System.Threading.Tasks; 
using Microsoft.EntityFrameworkCore; 

namespace SocialMedia.Services.Comments
{
    public class CommentsService : ICommentsService
    {
        private readonly ApplicationDbContext _context;

        public CommentsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateCommentAsync(CommentCreate model)
        {
            var newComment = new Comment
            {
                Post = model.Post,
                Text = model.Text,
                Author = model.Author
            };

            _context.Comments.Add(newComment);
            await _context.SaveChangesAsync();


            return true;
        }
    }
}
