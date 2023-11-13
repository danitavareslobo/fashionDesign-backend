using fashionDesign.Dto.Users.Request;
using fashionDesign.Interfaces.Services;

using fashionDesignAPI.Attributes;

using Microsoft.AspNetCore.Mvc;

namespace fashionDesign.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly IUsersService _service;

        public LoginController(IUsersService service)
        {
            _service = service;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> GenerateJwtToken(AuthenticateRequest request)
        {

            return Ok(new { token = await _service.GenerateJwtToken(request) });
        }
    }
}
