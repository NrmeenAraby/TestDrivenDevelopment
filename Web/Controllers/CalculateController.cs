using Microsoft.AspNetCore.Mvc;
using Domain;
using System.Reflection.Metadata.Ecma335;
namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculateController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CalculateController> _logger;

        public CalculateController(ILogger<CalculateController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Add/{a}/{b}")]
        public int Get(int a,int b)
        {
            return new Calculator().Sum(a, b); 
        }
    }
}
