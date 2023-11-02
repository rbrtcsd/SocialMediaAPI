using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Data.Entities;
using SocialMedia.Models.Post;
using SocialMedia.Models.User.Responses;
using SocialMedia.Services.Post;

namespace SocialMedia.WebAPI.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class PostController : ControllerBase
{
    private readonly IPostService _postService;

    public PostController(IPostService postService)
    {
        _postService = postService;
    }

[HttpPost("Create")]
public async Task<IActionResult> CreateNote([FromBody] PostCreate request)
{
    if (!ModelState.IsValid)
        return BadRequest(ModelState);

    var response = await _postService.CreateNoteAsync(request);
    if (response is not null)
        return Ok(response);

    return BadRequest(new TextResponse("Could not create note."));
}

[HttpGet]
public async Task<IActionResult> GetAllPosts()
{
    var posts = await _postService.GetAllPostsAsync();
    return Ok(posts);
}

}
