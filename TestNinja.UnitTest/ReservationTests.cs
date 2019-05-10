using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnTrue()
        {
            //Arrange
            var reservation = new Reservation();
            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_UserMadeBy_ReturnTrue()
        {
            //Arrange
            var reservation = new Reservation();
            User user = new User();
            reservation.MadeBy = user;
            //Act
            var result = reservation.CanBeCancelledBy(user);
            //Assert

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_NormalUser_ReturnFalse()
        {
            //Arrange
            var reservation = new Reservation();
            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = false });
            //Assert

            Assert.IsFalse(result);
        }
    }
}