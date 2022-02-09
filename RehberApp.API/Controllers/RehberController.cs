using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RehberApp.Business.Abstract;
using RehberApp.Business.Concrete;
using RehberApp.Core.Models;
using RehberApp.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static RehberApp.Core.Models.Result;

namespace RehberApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RehberController : ControllerBase
    {
        private readonly IRehberService _rehberService;
        public RehberController(IRehberService rehberService)
        {
            _rehberService = rehberService;
        }
        [HttpGet]
        public Task<GetManyResult<Rehber>> Get()
        {
            return _rehberService.GetRehberAsync();
        }

        [HttpPost]
        public Task<GetOneResult<Rehber>> Post([FromBody] Rehber rehber)
        {
            return _rehberService.InsertRehberAsync(rehber);
        }
    }
}
