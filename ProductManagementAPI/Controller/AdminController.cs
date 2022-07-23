using Microsoft.AspNetCore.Mvc;

namespace ProductManagementAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class UserController : ControllerBase
    {
       private IUserService _userService;
        private IMapper _mapper;
        //declaring a constructor
     public UserController( IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }


        //the sum of all products last week
        [HttpGet("{price}")]

        public IActionResult GetAll()
        {
            return View();
        }
    }
}
