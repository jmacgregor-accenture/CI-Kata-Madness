using System;
using CIKataFrontEnd.Mvc.Domain;
using Shouldly;
using Xunit;

namespace CIKataFrontEnd.Tests
{
    public class ValueServiceShould
    {
        [Fact]
        public void ReturnMessageContainingSuccessful()
        {
            var service = new ValueService();

            var result = service.GetValueFromApi();

            result.ShouldContain("successful");
        }
    }
}