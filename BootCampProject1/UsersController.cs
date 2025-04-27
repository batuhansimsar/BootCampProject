using BootCampProject.Entities;
using BootCampProject.Business;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly UserManager _userManager;

        public UsersController(UserManager userManager)
        {
            _userManager = userManager;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _userManager.GetUserById(id);
            if (user == null) return NotFound();
            return Ok(user);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userManager.GetAllUsers();
            return Ok(users);
        }

        [HttpPost]
        public IActionResult Add(User user)
        {
            _userManager.AddUser(user);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(User user)
        {
            _userManager.UpdateUser(user);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(User user)
        {
            _userManager.DeleteUser(user);
            return Ok();
        }
    }
}
