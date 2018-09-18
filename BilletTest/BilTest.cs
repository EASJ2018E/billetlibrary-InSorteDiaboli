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
        public void K�ret�jNavn()
        {
            //Arrange
            var bil = new Bil();
            //Act
            string pris = bil.K�ret�jNavn();
            //Assert
            Assert.AreEqual("Bil", pris);
        }
    }
}
