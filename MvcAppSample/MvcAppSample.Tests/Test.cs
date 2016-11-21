using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MvcAppSample.Tests
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Go()
        {
            var x = 1;
            var y = 0;
            Assert.AreEqual(x,y);
        }
    }
}
