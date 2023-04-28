using SafariParkApp;

namespace SafariParkTests
{
    public class Tests
    {
        [Test]
        public void WhenADefaultVehicle_MovesTwice_ItsPositionIs20()
        {
            Vehicle v = new Vehicle();
            var result = v.Move(2);
            Assert.AreEqual(20, v.Position);
            Assert.AreEqual("Moving along 2 times", result);
        }
        [Test]
        public void WhenAVehicleWithSpeed40_IsMovedOnce_ItsPositionIs40()
        {
            Vehicle v = new Vehicle(4, 40);
            var result = v.Move();
            Assert.AreEqual(40, v.Position);
            Assert.AreEqual("Moving along", result);
        }
    }
}
