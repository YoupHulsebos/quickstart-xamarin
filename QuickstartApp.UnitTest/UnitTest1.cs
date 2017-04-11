using NUnit.Framework;
using System;

namespace QuickstartApp.UnitTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Fail()
        {
            Assert.IsFalse(true);
        }
    }
}
