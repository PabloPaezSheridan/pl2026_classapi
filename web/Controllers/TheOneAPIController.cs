using System.Threading.Tasks;
using Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheOneAPIController : ControllerBase
    {
        private readonly TheOneAPIService _theOneAPIService;

        public TheOneAPIController( TheOneAPIService theOneAPIService)
        {
            _theOneAPIService = theOneAPIService;
            
        }

        [HttpGet("books")]
        public async Task<IActionResult> GetAllBooks()
        {
            return Ok(await _theOneAPIService.GetAllBooks());
        }
    }
}
