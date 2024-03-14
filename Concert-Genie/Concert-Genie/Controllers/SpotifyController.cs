using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Concert_Genie.Controllers
{
    [ApiController]
    [Route("Api")]
    public class ApiController : Controller
    {
        private readonly IConfiguration _configuration;
        public ApiController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("GetAccessToken")]
        public ActionResult GetAccessToken()
        {
            var baseUri = _configuration["SpotifyTokenUri"];
            return Redirect(baseUri);
        }
    }



}