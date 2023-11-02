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

<<<<<<< HEAD
        public async Task<bool> CreateCommentAsync(CommentModel model)
=======
        public async Task<bool> CreateCommentAsync(CommentCreate model)
        /*It defines a method named CreateCommentAsync that takes a CommentCreate model as a parameter and returns a Task<bool>. This method is used to create a new comment in the database.*/
>>>>>>> 0c7709a (second try)
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
