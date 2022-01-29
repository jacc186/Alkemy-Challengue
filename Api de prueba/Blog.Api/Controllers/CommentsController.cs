using Blog.Api.Data.EFCore;
using Blog.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : BlogApiController<Comments, EFCoreCommentRepository>
    {
        public CommentsController(EFCoreCommentRepository repository) : base(repository)
        {
        }
    }
}
