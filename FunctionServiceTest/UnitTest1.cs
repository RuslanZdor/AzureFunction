using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FunctionServiceTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            new AzureFunction();
            new FunctionService.Test();
        }
    }
}
