using System;
using System.Collections.Generic;

namespace SocialMedia.Services.Comments
{
    public interface ICommentsService
    {
     Task<bool> CreateCommentAsync(CommentModel model);
    }
}
