using AW_Basic_App_GitHub;
using Xunit;

namespace AW_Basic_App_GitHub.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            Class1 tp = new Class1();

            //Act
            var result = tp.Name;

            //Assert
            Assert.Equal("[Firstname Lastname] - God's Chosen Programmer", result);
        }
    }
}