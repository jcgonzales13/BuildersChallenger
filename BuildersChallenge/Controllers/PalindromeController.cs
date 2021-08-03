using BuildersChallenge.Domain.ServicesInterface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BuildersChallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PalindromeController : ControllerBase
    {
        private readonly ILogger<PalindromeController> _logger;
        protected IPalindromeService _service;

        public PalindromeController(ILogger<PalindromeController> logger, IPalindromeService service)
        {
            _logger = logger;
            _service = service;
        }
        /// <summary>
        /// validates if word is palindrome.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Palindom")]
        public Palindrome Palindom(string text)
        { 
            return _service.IsPalindom(text);

        }
    }
}
