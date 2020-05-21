using System;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {

        [Fact]
        public void Get_Returns_1_For_1()
 
        {
            var FizzBuzz = new FizzBuzz();
            var result = FizzBuzz.Get(1);
            Assert.Equal("1", result);
        }
    }
}
