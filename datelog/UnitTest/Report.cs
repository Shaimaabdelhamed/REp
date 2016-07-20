using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
namespace UnitTest
{ 
    [TestFixture]
    public class Report
    {
        [Test]
        public void WriteTxt_null_false()
        {
            report re = new report();
            Assert.AreEqual(re.Writetxt("hi", null), true);
       
        }
    }
}
