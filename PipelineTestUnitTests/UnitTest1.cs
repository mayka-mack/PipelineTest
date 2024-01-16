using PipelineTest;
using Xunit;

namespace PipelineTestUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("Hello, World!", TestFunctions.HelloWorld());
        }
    }
}
