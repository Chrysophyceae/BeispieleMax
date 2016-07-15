using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApplication2.Tests
{
    [TestClass()]
    public class RechteckServiceTests
    {
        [TestMethod()]
        public void BerechneFlaechel3b2TestReturns6()
        {
            RechteckModel objektVonRechteck = new RechteckModel(3.0,2.0);
            RechteckService objectVonRechteckService = new RechteckService();

            Assert.AreEqual(6, objectVonRechteckService.BerechneFlaeche(objektVonRechteck));
        }
    }
}