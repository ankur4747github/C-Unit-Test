using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnTrue()
        {
            //Arrange
            var reservation = new Reservation();
            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });
            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
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

        [Test]
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