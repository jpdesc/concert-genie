using Microsoft.AspNetCore.Mvc;

namespace Concert_Genie.Controllers
{
    [HttpGet]
    [Route("api/spotify/authenticate")]
    public IActionResult Authenticate()
    {
        var spotifyAuthLink = $"https://accounts.spotify.com/authorize?client_id={clientId}&response_type=code&redirect_uri={redirectUri}&scope=user-top-read";
        return Redirect(spotifyAuthLink);
    }
}