using Microsoft.AspNetCore.Mvc;

namespace CloudCustomers.API.Controllers
{
	public interface IUserController
	{
		Task<IActionResult> Get();
	}
}
