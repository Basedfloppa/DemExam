using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DistEkzamen_test;

namespace Coffe_test
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow("log","pass")]
        [DataRow("","pass")]
        [DataRow("log","")]
        [DataRow("","")]
            
        public void LoginIsNull_LoginAndPass_ResultTrue(string login, string password)
        {
            bool result = false;
        }
    }
}
