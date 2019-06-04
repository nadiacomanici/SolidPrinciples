using System;

namespace DependencyInjection_DateTime_End.Logic
{
    public class TimeOfDayGreeterWithDIConstructor
    {
        private readonly IDateTimeProvider _dateTimeProvider;

        public TimeOfDayGreeterWithDIConstructor(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
        }

        public string GetProperGreeting(string name)
        {
            var now = _dateTimeProvider.GetDateNow();
            if (now.Hour < 12)
            {
                return $"Good morning, {name}";
            }
            else
            {
                if (now.Hour < 18)
                {
                    return $"Good afternoon, {name}";
                }
                else
                {
                    return $"Good evening, {name}";
                }
            }
        }
    }
}
