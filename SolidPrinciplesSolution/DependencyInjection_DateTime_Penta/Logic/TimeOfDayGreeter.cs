using System;

namespace DependencyInjection_DateTime_Begin.Logic
{
    public class TimeOfDayGreeter
    {
        private readonly IDateTimeProvider _dateTimeProvider;

        public TimeOfDayGreeter(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
        }

        public string GetProperGreeting(string name)
        {
            var now = _dateTimeProvider.GetDateTime();
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
