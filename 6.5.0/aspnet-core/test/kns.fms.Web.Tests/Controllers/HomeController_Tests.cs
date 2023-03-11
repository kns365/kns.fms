using System.Threading.Tasks;
using kns.fms.Models.TokenAuth;
using kns.fms.Web.Controllers;
using Shouldly;
using Xunit;

namespace kns.fms.Web.Tests.Controllers
{
    public class HomeController_Tests: fmsWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}