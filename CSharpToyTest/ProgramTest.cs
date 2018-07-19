using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using CSharpToy;

namespace CSharpToyTest
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void TestAdd()
        {
            Program program = new Program();
            Assert.AreEqual(2, program.Add(1, 1), "Wrong Add");
        }
    }
}
