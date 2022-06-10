using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Acme.BookStore.Pages;

public class Index_Tests : BookStoreWebTestBase
{
    [Fact]
    public async Task WelcomePage()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
