using System;
using Utils;
using Xunit;

namespace XUnitTestProject1
{
    public class XUnitTest1
    {
        /// <summary>
        /// Facts are Test that are always true
        /// </summary>
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }



        [Theory]
        [InlineData("martin.murphy@whiteboard-it.com")]
        [InlineData("a@a.com")]
        public void ShouldBeValid(string email)
        {
            Assert.True(EmailUtils.IsValidEmail(email));
        }

        [Theory]
        [InlineData("a")]
        [InlineData("asdffds@")]
        [InlineData("asf@a.")]
        [InlineData("asdf@asf")]
        public void ShouldBeInvalid(string email)
        {
            Assert.False(EmailUtils.IsValidEmail(email));
        }

    }
}
