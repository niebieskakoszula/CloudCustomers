using CloudCustomers.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudCustomers.UnitTests.Fixtures
{
	public static class UsersFixture
	{
		public static List<User> GetTestUsers() =>
			new()
			{
				new User
				{
					Name = "Tester1",
					Email = "user.tester1@dev.com",
					Address = new Address
					{
						Street ="al. Jana Pawła II 21/37",
						City = "Inowrocław",
						ZipCode = "09-123"
					}
				},
				new User
				{
					Name = "Tester2",
					Email = "user.tester2@dev.com",
					Address = new Address
					{
						Street ="al. Jana Pawła II 21/37",
						City = "Inowrocław",
						ZipCode = "09-123"
					}
				},
				new User
				{
					Name = "Tester3",
					Email = "user.tester3@dev.com",
					Address = new Address
					{
						Street ="al. Jana Pawła II 21/37",
						City = "Inowrocław",
						ZipCode = "09-123"
					}
				}
			};
	}
}
