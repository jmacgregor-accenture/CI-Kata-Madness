using CIKataBackEnd.WebApi.Domain;
using Shouldly;
using Xunit;

namespace CIKataBackEnd.Tests
{
    public class BusinessLogicServiceShould
    {
        [Fact]
        public void ReturnSuccessfulMessage()
        {
            var businessLogicService = new BusinessLogicService();

            var result = businessLogicService.MakeUpValue();
            
            result.ShouldContain("this value is here in order to fail this test like a student who never enrolled");
        }
    }
}