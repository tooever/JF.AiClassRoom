using System.Threading.Tasks;
using JF.AiClassRoom.Web.Controllers;
using Shouldly;
using Xunit;

namespace JF.AiClassRoom.Web.Tests.Controllers
{
    public class HomeController_Tests: AiClassRoomWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
