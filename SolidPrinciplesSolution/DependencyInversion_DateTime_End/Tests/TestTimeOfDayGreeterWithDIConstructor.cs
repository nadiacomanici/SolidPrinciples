using System;
using DependencyInversion_DateTime_End.Logic;
using Moq;
using NUnit.Framework;

namespace DependencyInversion_DateTime_End.Tests
{
    [TestFixture]
    public class TestTimeOfDayGreeterWithDIConstructor
    {
        private static string _name = "Nadia";
        private static Random _random = new Random();

        private Mock<IDateTimeProvider> _dateTimeProvider;

        [SetUp]
        public void Setup()
        {
            _dateTimeProvider = new Mock<IDateTimeProvider>();
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(9)]
        [TestCase(10)]
        [TestCase(11)]
        public void TimeOfDayGreeterWithDIConstructor_GetProperGreeting_WithMorningTime_Success(int hour)
        {
            // arrange
            var date = new System.DateTime(2019, 01, 01, hour, _random.Next(0, 59), _random.Next(0, 59));
            _dateTimeProvider.Setup(p => p.GetDateNow())
                .Returns(date);

            var greeter = new TimeOfDayGreeterWithDIConstructor(_dateTimeProvider.Object);

            // act
            var greeting = greeter.GetProperGreeting(_name);

            // assert
            Assert.That(greeting, Is.EqualTo($"Good morning, {_name}"));
        }

        [TestCase(12)]
        [TestCase(13)]
        [TestCase(14)]
        [TestCase(15)]
        [TestCase(16)]
        [TestCase(17)]
        public void TimeOfDayGreeting_GetProperGreeting_WithAfternoonTime_Success(int hour)
        {
            // arrange
            var date = new System.DateTime(2019, 01, 01, hour, _random.Next(0, 59), _random.Next(0, 59));
            _dateTimeProvider.Setup(p => p.GetDateNow())
                .Returns(date);

            var greeter = new TimeOfDayGreeterWithDIConstructor(_dateTimeProvider.Object);

            // act
            var greeting = greeter.GetProperGreeting(_name);

            // assert
            Assert.That(greeting, Is.EqualTo($"Good afternoon, {_name}"));
        }
        
        [TestCase(18)]
        [TestCase(19)]
        [TestCase(20)]
        [TestCase(21)]
        [TestCase(22)]
        [TestCase(23)]
        public void TimeOfDayGreeting_GetProperGreeting_WithEveningTime_Success(int hour)
        {
            // arrange
            var date = new System.DateTime(2019, 01, 01, hour, _random.Next(0, 59), _random.Next(0, 59));
            _dateTimeProvider.Setup(p => p.GetDateNow())
                .Returns(date);

            var greeter = new TimeOfDayGreeterWithDIConstructor(_dateTimeProvider.Object);

            // act
            var greeting = greeter.GetProperGreeting(_name);

            // assert
            Assert.That(greeting, Is.EqualTo($"Good evening, {_name}"));
        }
    }
}
