using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CreateClass
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            int  salary = 500000;
            string name = "joe";
            string profession = "programmer";
            int birthDate = 1987;
            Employee joe = new Employee(name, birthDate,  salary, profession);

            // act  
            

            // assert  
            Assert.AreEqual(joe.getName, "joe");
        }
    }
}
