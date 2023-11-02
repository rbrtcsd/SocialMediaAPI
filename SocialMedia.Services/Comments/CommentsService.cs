using System;
using System.Net;
using System.Threading.Tasks; 
using Microsoft.EntityFrameworkCore;
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


        public async Task<bool> CreateCommentAsync(CommentModel model);
        {
            var newComment = new Comment
            {
                Post = model.Post,
                Text = model.Text,
                Author = model.Author
            };

//             _context.Comments.Add(newComment);
//             await _context.SaveChangesAsync();


//             return true;
//         }
//     }
// }
