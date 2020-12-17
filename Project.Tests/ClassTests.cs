using Xunit;

namespace Project.Tests
{
    public class ClassTests
    {
        [Fact]
        public void MethodReturnsTrue()
        {
            var obj = new Class();

            Assert.True(obj.Method());
        }
    }
}