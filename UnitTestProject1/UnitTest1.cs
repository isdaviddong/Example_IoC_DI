using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            WebApplicationLoggin.Pages.SalaryCalculatorModel m =
                new WebApplicationLoggin.Pages.SalaryCalculatorModel(new HR.SalaryFormula());

            var ret = m.OnGet();
            Assert.IsTrue(m.Salary == 32000);
        }
    }
}
