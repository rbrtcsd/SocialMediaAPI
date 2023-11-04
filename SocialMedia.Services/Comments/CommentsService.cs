using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SocialMedia.Models.Comments;

using SocialMedia.Data;
using SocialMedia.Data.Entities;


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
            CommentsEntity entity = new()
            {

                Text = model.Text,
                PostId = model.PostId,

            };

            _context.Comments.Add(entity);
            await _context.SaveChangesAsync();


            return true;
        }
    }
}
