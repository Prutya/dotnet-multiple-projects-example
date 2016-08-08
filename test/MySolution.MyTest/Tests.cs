using System;
using Xunit;
using MySolution.MyService;

namespace MySolution.MyTest
{
    public class MyClassTests
    {
        [Fact]
        public void SayHello_Always_ReturnsHelloWorld() 
        {
            var hello = MyClass.SayHello();

            Assert.Equal("Hello World!", hello);
        }
    }
}
