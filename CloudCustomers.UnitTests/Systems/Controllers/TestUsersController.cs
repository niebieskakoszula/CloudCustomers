using CloudCustomers.API.Models;
using CloudCustomers.API.Services.Interfaces;
using CloudCustomers.UnitTests.Fixtures;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace CloudCustomers.UnitTests.Systems.Controllers
{
    public class TestUsersController
    {
        static Mock<IUsersService> mockUserService = new Mock<IUsersService>();
		[Fact]
        public async Task Get_OnSuccess_ReturnsStatusCode200()
        {
			//Arrange
			mockUserService.Setup(service => service.GetAllUsers())
				.ReturnsAsync(UsersFixture.GetTestUsers());
			var sut = new UsersController(mockUserService.Object);

            //Act
            var result = (OkObjectResult)await sut.Get();

            //Assert
            result.StatusCode.Should().Be(200);
        }
        [Fact]
        public async Task Get_OnSuccess_InvokesUserService_ExaclyOnce()
		{
            //Arrange
            mockUserService.Setup(service => service.GetAllUsers())
                .ReturnsAsync(UsersFixture.GetTestUsers());
			var sut = new UsersController(mockUserService.Object);

            //Act
            var result = (OkObjectResult) await sut.Get();

            //Assert
            mockUserService.Verify(
                service => service.GetAllUsers(),
                Times.Once);
		}
        [Fact]
        public async Task Get_OnSuccess_ReturnsListOfUsers()
        {
			//Arrange
			mockUserService.Setup(service => service.GetAllUsers())
				.ReturnsAsync(new List<User>() {new User(), new User() });
			var sut = new UsersController(mockUserService.Object);

			//Act
			var result = await sut.Get();

			//Assert
            result.Should().BeOfType<OkObjectResult>();
            var objectResult = ((OkObjectResult)result);
            objectResult.Value.Should().BeOfType<List<User>>();
		}

		[Fact]
		public async Task Get_OnNoUsersFound_Returns404()
		{
			//Arrange
			mockUserService.Setup(service => service.GetAllUsers())
				.ReturnsAsync(new List<User>());
			var sut = new UsersController(mockUserService.Object);

			//Act
			var result = await sut.Get();

			//Assert
			result.Should().BeOfType<NotFoundResult>();
			var objectResult = (NotFoundResult)result;
			objectResult.StatusCode.Should().Be(404);
		}
	}

}
//Arrange
//Act
//Assert