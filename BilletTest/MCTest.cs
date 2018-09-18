using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;

namespace BilletLibraryTest
{
    [TestClass]
    public class MCTest
    {
        [TestMethod]
        public void MCPris()
        {
            //Arrange
            var mc = new MC();
            //Act
            decimal pris = mc.Pris();
            //Assert
            Assert.AreEqual(125, pris);
        }

        [TestMethod]
        public void KøretøjNavn()
        {
            //Arrange
            var mc = new MC();
            //Act
            string pris = mc.KøretøjNavn();
            //Assert
            Assert.AreEqual("MC", pris);
        }
    }
}
