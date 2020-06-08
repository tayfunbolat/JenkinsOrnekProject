using JenkinsOrnek;
using System;
using Xunit;

namespace JenkinsOrnekUnits
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Calculator calculator = new Calculator();

            var actual =  calculator.Sum(5, 6);

            Assert.Equal(11, actual);
        }
    }
}
