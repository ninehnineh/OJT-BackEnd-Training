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
        public ActionResult<ServiceResponses<List<User>>> Get()
        {
            var serviceResponse = new ServiceResponses<List<User>>();
            var dbUser = _userRepository.Get();
            //serviceResponse.Data = dbUser;
            return dbUser;
        }
    }
}
