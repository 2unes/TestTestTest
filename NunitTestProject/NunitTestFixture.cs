using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NunitTestProject
{
    [TestFixture]
    public class NunitTestFixture
    {

        [Test]
        public void NunitTest()
        {
            Assert.IsTrue(true);
        }
    }
}
