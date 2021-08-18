using System.Threading.Tasks;
using RevisionControl.Models.TokenAuth;
using RevisionControl.Web.Controllers;
using Shouldly;
using Xunit;

namespace RevisionControl.Web.Tests.Controllers
{
    public class HomeController_Tests: RevisionControlWebTestBase
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