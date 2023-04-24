using CloudCustomers.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CloudCustomers.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class UsersController : ControllerBase
	{
		private readonly IUsersService _userService;

		private readonly ILogger<UsersController> _logger;

		public UsersController(IUsersService userService)
		{
			_userService = userService;
		}
		public UsersController(ILogger<UsersController> logger, IUsersService userService) : this(userService)
		{
			_logger = logger;
		}

		[HttpGet(Name = "GetUsers")]
		public async Task<IActionResult> Get()
		{
			var users = await _userService.GetAllUsers();

			if (users.Any())
			{
				return Ok(users);
			}
			return NotFound();
		}

		[HttpGet(Name = "FakeMethod_1")]
		public async Task<IActionResult> FakeMethod_1()
		{
			var users = await _userService.GetAllUsers();

			if (users.Any())
			{
				return Ok(users);
			}
			return NotFound();
		}

		[HttpGet(Name = "FakeMethod_2")]
		public async Task<IActionResult> FakeMethod_2()
		{
			var users = await _userService.GetAllUsers();

			if (users.Any())
			{
				return Ok(users);
			}
			return NotFound();
		}
	}
}