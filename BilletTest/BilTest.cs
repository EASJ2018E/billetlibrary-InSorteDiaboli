using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;

namespace BilletLibraryTest
{
    [TestClass]
    public class BilTest
    {
        [TestMethod]
        public void BilPris()
        {
            //Arrange
            var bil = new Bil();
            //Act
            decimal pris = bil.Pris();
            //Assert
            Assert.AreEqual(240, pris);
        }

        [TestMethod]
        public void KøretøjNavn()
        {
            //Arrange
            var bil = new Bil();
            //Act
            string pris = bil.KøretøjNavn();
            //Assert
            Assert.AreEqual("Bil", pris);
        }
    }
}
