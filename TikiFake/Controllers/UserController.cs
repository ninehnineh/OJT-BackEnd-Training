using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TikiFake.Models;
using TikiFake.Repositorys;

namespace TikiFake.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpGet]
        public async Task<ActionResult<ServiceResponses<List<User>>>> Get()
        {
            return Ok(await _userRepository.Get());
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponses<List<User>>>> Delete(string id)
        {
            var user = _userRepository.Get(id);

            return Ok(await _userRepository.Delete(id));
        }
    }
}
