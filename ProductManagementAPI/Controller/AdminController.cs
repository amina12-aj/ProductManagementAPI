/*using Microsoft.AspNetCore.Mvc;

namespace ProductManagementAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class AdminController : ControllerBase
    {
        private IUserService _userService;
        private IMapper _mapper;
        //declaring a constructor
        public AdminController(IUserService userService, IMapper mapper)
            _userService = userService;
            _mapper = mapper;
        }


        //the sum of all products last week
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _userService.GetById(id);
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Create(CreateRequest model)
        {
            _userService.Create(model);
            return Ok(new { message = "User created" });
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, UpdateRequest model)
        {
            _userService.Update(id, model);
            return Ok(new { message = "User updated" });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userService.Delete(id);
            return Ok(new { message = "User deleted" });
        }
    }
}*/
