using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApiA.Controllers
{
    [ApiController]
    [Route("test")]
    public class TestController: ControllerBase
    {
        private readonly HttpClient _client;

        public TestController(IHttpClientFactory httpClientFactory)
        {
            _client = httpClientFactory.CreateClient();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _client.GetAsync("http://localhost:5001/data");
            var content = await result.Content.ReadAsStringAsync();

            return Content(content, "application/json");
        }
    }
}