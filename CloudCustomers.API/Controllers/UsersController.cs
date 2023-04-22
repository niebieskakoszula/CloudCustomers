using CloudCustomers.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CloudCustomers.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class UsersController : ControllerBase
	{
		private readonly IUsersService _userService;

		/*private readonly ILogger<UsersController> _logger;*/

		public UsersController(IUsersService userService)
		{
			_userService = userService;
		}
		/*public UsersController(ILogger<UsersController> logger)
		{
			_logger = logger;
		}*/

		[HttpGet(Name = "GetUsers")]
		public async Task<IActionResult> Get()
		{
			var users = await _userService.GetAllUsers();

			if(users.Any())
			{
				return Ok(users);
			}
			return NotFound();
		}
	}
}