using System;
using System.Collections.Generic;
using SocialMedia.Models.Comments;

namespace SocialMedia.Services.Comments
{
    public interface ICommentsService
    {
        Task<bool> CreateCommentAsync(CommentCreate model);

    }
}
