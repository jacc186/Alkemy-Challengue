using Blog.Api.Data.EFCore;
using Blog.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : BlogApiController<User, EFCoreUserRepository>
    {
        public UsersController(EFCoreUserRepository repository) : base(repository)
        {

        }
    }
}
