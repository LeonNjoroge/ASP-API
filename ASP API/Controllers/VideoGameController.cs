using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController : ControllerBase
    {
        static private List<VideoGame> videoGames = new List<VideoGame>
            {
                new VideoGame
                    {
                        Id = 1,
                        Title = "Spider-Man 2",
                        Platform = "PS5",
                        Developer = "Insomniac Games",
                        Publisher = "Sony Interactive Entertainment"
                    },
                new VideoGame
                    {
                        Id = 2,
                        Title = "Superman Reborn",
                        Platform = "Nintendo",
                        Developer = "AMG Performance",
                        Publisher = "ITC Studios"
                    },
                new VideoGame
                    {
                        Id = 3,
                        Title = "Lost in Space",
                        Platform = "PC",
                        Developer = "Terraform Games",
                        Publisher = "IDP Ent"
                    },
            };


        [HttpGet]
        public ActionResult<List<VideoGame>> GetVideoGames()
        {
            return Ok(videoGames);
        }
    }
}
