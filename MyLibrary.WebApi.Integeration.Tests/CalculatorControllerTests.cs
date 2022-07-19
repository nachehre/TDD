using FluentAssertions;
using Xunit;

namespace MyLibrary.WebApi.Integeration.Tests
{
    public class CalculatorControllerTests
    {
        [Fact]
        public async Task Add_should_return_3_when_inputs_are_1_and_2()
        {
            //fixture setup
            var application = new Setup();
            var client = application.CreateClient();

            //excercise
            var response = await client.GetAsync($"calculator/add/{1}/{2}");
            var responseString = await response.Content.ReadAsStringAsync();

            //verify
            responseString.Contains("3").Should().BeTrue();
        }

        [Fact]
        public async Task Sub_should_return_3_when_inputs_are_7_and_4()
        {
            //fixture setup
            var application = new Setup();
            var client = application.CreateClient();

            //Excercise
            var response = await client.GetAsync($"calculator/sub/{7}/{4}");
            var responseString = await response.Content.ReadAsStringAsync();

            //verfiy
            responseString.Contains("3").Should().BeTrue();
        }
    }
}
