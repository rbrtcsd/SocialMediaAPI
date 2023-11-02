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
        /*It defines a constructor for the CommentsService class that takes an ApplicationDbContext parameter. This constructor is used to inject the database context into the service when an instance of the service is created.*/
        {
            _context = context;
        }

        public async Task<bool> CommentCreateAsync(CommentCreate model)
        /*It defines a method named CreateCommentAsync that takes a CommentCreate model as a parameter and returns a Task<bool>. This method is used to create a new comment in the database.*/
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
