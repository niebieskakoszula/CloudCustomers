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
			int a = 5;

			if (users.Any())
			{
				return Ok(users);
			}
			return NotFound();
		}

		[HttpGet(Name = "FakeMethod2")]
		public async Task<IActionResult> FakeMethod2()
		{
			var users = await _userService.GetAllUsers();

			if (users.Any())
			{
				return Ok(users);
			}
			return NotFound();
		}

		[HttpGet(Name = "FakeMethod3")]
		public async Task<IActionResult> FakeMethod3()
		{
			var users = await _userService.GetAllUsers();

			if (users.Any())
			{
				return Ok(users);
			}
			return NotFound();
		}

		[HttpGet(Name = "FakeMethod4")]
		public async Task<IActionResult> FakeMethod4()
		{
			var users = await _userService.GetAllUsers();

			if (users.Any())
			{
				return Ok(users);
			}
			return NotFound();
		}

		[HttpGet(Name = "FakeMethod5")]
		public async Task<IActionResult> FakeMethod5()
		{
			var users = await _userService.GetAllUsers();

			if (users.Any())
			{
				return Ok(users);
			}
			return NotFound();
		}

		[HttpGet(Name = "FakeMethod6")]
		public async Task<IActionResult> FakeMethod6()
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