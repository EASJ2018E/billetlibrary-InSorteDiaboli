using System;
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
            string navn = bil.KøretøjNavn();
            //Assert
            Assert.AreSame("Bil", navn);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void NummerpladeLength()
        {
            //Arrange
            var bil = new Bil("SD121212", new DateTime(2018, 2, 2));
            //Act
            
            //Assert
            Assert.Fail();
        }

        [TestMethod]
        public void TicketPrice()
        {
            //Arrange
            var bil = new Bil();
            //Act
            var brobizz = bil.UsesBrobizz();
            //Assert
            Assert.AreEqual(228, brobizz);
        }
    }
}
