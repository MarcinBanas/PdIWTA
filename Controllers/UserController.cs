using PdiwtA.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PdiwtA.Controllers
{
    [ApiController]
    [Route ("[controller]")]

    public class UserController : Controller
    {
        IUserRepository userRepository;

        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpPost("GetUsers")]
        public IEnumerable<User> Get()
        {
            return userRepository.GetAll();
        }

        [HttpPost("AddUsers")]
        public User Save(TestUserDTO test)
        {
            var p = new User(test.Email, test.Phone);
            return userRepository.Save(p);
        }

    }
}
