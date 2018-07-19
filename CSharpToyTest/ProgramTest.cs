using System;
using NUnit.Framework;

using CSharpToy;

namespace CSharpToyTest
{

    [TestFixture]
    public class ProgramTest
    {
        private Program program;

        [SetUp]
        protected void SetUp()
        {
            program = new Program();
        }

        [Test]
        public void TestAdd()
        {
            Assert.AreEqual(2, program.Add(1, 1));
        }
    }
}
