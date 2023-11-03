using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SocialMedia.Models.Likes;
using SocialMedia.Models.User.Responses;
using SocialMedia.Services.Likes;

namespace SocialMedia.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LikesController : ControllerBase
{
    private readonly ILikesService _likesService;

    public LikesController(ILikesService likesService)
    {
        _likesService = likesService;
    }

    [HttpPost("Create")]
    public async Task<IActionResult> CreateLike([FromBody] LikeCreate request)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var response = await _likesService.CreateLikeOnPost(request);
        if (response is not null)
            return Ok(response);

        return BadRequest(new TextResponse("Could not create note."));
    }
}