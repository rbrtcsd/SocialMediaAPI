using Microsoft.AspNetCore.Mvc; 

namespace SocialMedia.Controllers;
{
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentsService _commentsService;

        public CommentsController(ICommentsService commentsService)
        {
            _commentsService = commentsService;
        }

        [HttpPost("posts/{postId}/comments")]
        public async Task<IActionResult> CreateComment(int postId, [FromBody] CommentCreateModel commentModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var comment = new Comment
            {
                PostId = postId,
                Text = commentModel.Text,
            };

            await _commentsService.CreateCommentAsync(comment);

            return CreatedAtAction("GetCommentById", new { commentId = comment.Id }, comment);
        }

        [HttpGet("posts/{postId}/comments")]
        public async Task<IActionResult> GetCommentsByPostId(int postId)
        {
            var comments = await _commentsService.GetCommentsByPostIdAsync(postId);

            if (comments == null)
            {
                return NotFound();
            }

            return Ok(comments);
        }

        [HttpPut("comments/{commentId}")]
        public async Task<IActionResult> UpdateComment(int commentId, [FromBody] CommentUpdateModel commentModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingComment = await _commentsService.GetCommentByIdAsync(commentId);

            if (existingComment == null)
            {
                return NotFound();
            }

            existingComment.Text = commentModel.Text;

            await _commentsService.UpdateCommentAsync(existingComment);

            return NoContent();
        }

        [HttpDelete("comments/{commentId}")]
        public async Task<IActionResult> DeleteComment(int commentId)
        {
            var existingComment = await _commentsService.GetCommentByIdAsync(commentId);

            if (existingComment == null)
            {
                return NotFound();
            }

            await _commentsService.DeleteCommentAsync(commentId);

            return NoContent();
        }
    }
}
