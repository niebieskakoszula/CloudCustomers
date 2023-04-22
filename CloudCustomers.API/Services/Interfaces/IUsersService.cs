using CloudCustomers.API.Models;

namespace CloudCustomers.API.Services.Interfaces
{
	public interface IUsersService
	{
		Task<List<User>> GetAllUsers();
	}
}
