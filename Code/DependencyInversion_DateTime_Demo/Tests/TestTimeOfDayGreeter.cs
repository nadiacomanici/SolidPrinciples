using DependencyInversion_DateTime_Begin.Logic;
using Moq;
using NUnit.Framework;

namespace DependencyInversion_DateTime_Begin.Tests
{
    [TestFixture]
    public class TestTimeOfDayGreeter
    {
        private static string name = "Nadia";
        private Mock<DateTimeProvider> dateTimeProvider;

        public TestTimeOfDayGreeter()
        {
            dateTimeProvider = new Mock<DateTimeProvider>();
        }

        [Test]
        public void TimeOfDayGreeting_GetProperGreeting_WithMorningTime_Success()
        {
            // arrange
            dateTimeProvider.Setup(dtp => dtp.GetNow()).
                Returns(new System.DateTime(2020, 06, 27, 08, 05, 00));

            var greeter = new TimeOfDayGreeter(dateTimeProvider.Object);

            // act
            var greeting = greeter.GetProperGreeting(name);

            // assert
            Assert.That(greeting, Is.EqualTo("Good morning, Nadia"));
        }

        [Test]
        public void TimeOfDayGreeting_GetProperGreeting_WithAfternoonTime_Success()
        {
            // arrange
            dateTimeProvider.Setup(dtp => dtp.GetNow()).
                Returns(new System.DateTime(2020, 06, 27, 12, 30, 00));
            var greeter = new TimeOfDayGreeter(dateTimeProvider.Object);

            // act
            var greeting = greeter.GetProperGreeting(name);

            // assert
            Assert.That(greeting, Is.EqualTo("Good afternoon, Nadia"));
        }

        [Test]
        public void TimeOfDayGreeting_GetProperGreeting_WithEveningTime_Success()
        {
            // arrange
            dateTimeProvider.Setup(dtp => dtp.GetNow()).
                Returns(new System.DateTime(2020, 06, 27, 19, 30, 00));
            var greeter = new TimeOfDayGreeter(dateTimeProvider.Object);

            // act
            var greeting = greeter.GetProperGreeting(name);

            // assert
            Assert.That(greeting, Is.EqualTo("Good evening, Nadia"));
        }
    }
}
