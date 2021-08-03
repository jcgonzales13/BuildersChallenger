using BuildersChallenge.Domain.ServicesInterface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace BuildersChallenge.Controllers
{
    public class BinarySearchTreeController : ControllerBase
    {
        private readonly ILogger<BinarySearchTreeController> _logger;
        protected IBinarySearchTreeService _service;

        public BinarySearchTreeController(ILogger<BinarySearchTreeController> logger, IBinarySearchTreeService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        [Route("BinarySearchTree")]
        public String Index()
        {
            return _service.Show();
        }
    }
}
