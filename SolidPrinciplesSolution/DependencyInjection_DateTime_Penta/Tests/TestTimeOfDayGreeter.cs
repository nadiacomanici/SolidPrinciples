using System;
using DependencyInjection_DateTime_Begin.Logic;
using NSubstitute;
using NUnit.Framework;

namespace DependencyInjection_DateTime_Begin.Tests
{
    [TestFixture]
    public class TestTimeOfDayGreeter
    {
        private static string _name = "Nadia";
        private IDateTimeProvider _provider;

        [SetUp]
        public void SetUp()
        {
            //_provider = new DateTimeProvider();
            _provider = Substitute.For<IDateTimeProvider>();
        }

        [Test]
        public void TimeOfDayGreeting_GetProperGreeting_WithMorningTime_Success()
        {
            // arrange
            _provider.GetDateTime().Returns(new DateTime(2019, 05, 04, 9, 0, 0));
            var greeter = new TimeOfDayGreeter(_provider);

            // act
            var greeting = greeter.GetProperGreeting(_name);

            // assert
            Assert.AreEqual($"Good morning, {_name}", greeting);
            _provider.Received(1).GetDateTime();
        }
        
        [Test]
        public void TimeOfDayGreeting_GetProperGreeting_WithAfternoonTime_Success()
        {
            // arrange
            _provider.GetDateTime().Returns(new DateTime(2019, 05, 04, 15, 0, 0));
            var greeter = new TimeOfDayGreeter(_provider);

            // act
            var greeting = greeter.GetProperGreeting(_name);

            // assert
            Assert.AreEqual($"Good afternoon, {_name}", greeting);
            _provider.Received(1).GetDateTime();
        }

        [Test]
        public void TimeOfDayGreeting_GetProperGreeting_WithEveningTime_Success()
        {
            // arrange
            _provider.GetDateTime().Returns(new DateTime(2019, 05, 04, 22, 0, 0));
            var greeter = new TimeOfDayGreeter(_provider);

            // act
            var greeting = greeter.GetProperGreeting(_name);

            // assert
            Assert.AreEqual($"Good evening, {_name}", greeting);
            _provider.Received(1).GetDateTime();
        }
    }
}
