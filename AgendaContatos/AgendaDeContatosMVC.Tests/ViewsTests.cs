using Xunit;
using AgendaDeContatosMVC;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Threading.Tasks;
using System.Net.Http;

namespace AgendaDeContatosMVC.Tests
{
    public class ViewTests : IClassFixture<WebApplicationFactory<Program>>
    {

        private readonly WebApplicationFactory<Program> _factory;
        private readonly HttpClient httpClient;

        public ViewTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
            httpClient = _factory.CreateClient();


        }

        [Fact (Skip = "Moving to theory")]
        public async void ContactsIndexLoads()
        {
            //Arrange
            var client = _factory.CreateClient();

            //Act
            var responde = await client.GetAsync("/Contacts/Index");
            int code = (int)responde.StatusCode;

            //Assert
            Assert.Equal(200, code);
        }

        [Theory]
        [InlineData("/")]
        [InlineData("/Home/Index")]
        [InlineData("/Contacts/Index")]
        [InlineData("/Contacts/Create")]
        
        public async Task TestIfAllPagesWithoutIdLoads(string url)
        {
            //Arrange
            var client = _factory.CreateClient();

            //Act
            var response = await client.GetAsync(url);
            int code = (int)response.StatusCode;

            //Assert
            Assert.Equal(200, code);
        }

        [Theory]
        [InlineData("/Contacts/Delete/7")]
        [InlineData("/Contacts/Details/7")]
        [InlineData("/Contacts/Edit/7")]
        public async Task TestIfAllPagesThatNeedIdLoads(string url)
        {
            //Arrange
            var client = _factory.CreateClient();

            //Act
            var response = await client.GetAsync(url);
            int code = (int)response.StatusCode;

            //Assert
            Assert.Equal(200, code);
        }

        [Fact]
        public async void TestIfContentLoads()
        {
            //Arrange
            var client = _factory.CreateClient();

            //Act
            var response = await client.GetAsync("/Contacts/Index");
            var pageContent = await response.Content.ReadAsStringAsync();
            var contentString = pageContent.ToString();

            //Assert
            Assert.Contains("Ana Carolina", contentString);
        }
    }
}