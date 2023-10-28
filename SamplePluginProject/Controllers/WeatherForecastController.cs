using Microsoft.AspNetCore.Mvc;
using SamplePluginProject.Models;
using SamplePluginProject.Services;

namespace SamplePluginProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IPostService _postService;

        public WeatherForecastController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpPost]
        public IActionResult Post()
        {
            _postService.CreatePost(new PostContent()
            {
                Id = 1,
                Title = "Sample Post",
                Content = "This is a sample content."
            });

            return Ok("");
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("");
        }
    }
}