using NUnit.Framework;
using System;
using ConsoleApp1;
namespace DoragonSoruja
{

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("VALID", validPass.validator("Username123"));
            Assert.AreEqual("INVALID", validPass.validator("Username"));
            Assert.AreEqual("INVALID", validPass.validator("123"));
            Assert.AreEqual("INVALID", validPass.validator("Username123!"));
            Assert.AreEqual("INVALID", validPass.validator("ThisPasswordIsTooLong1234"));
        }
    }
}