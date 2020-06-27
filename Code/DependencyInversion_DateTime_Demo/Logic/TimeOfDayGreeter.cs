using System;

namespace DependencyInversion_DateTime_Begin.Logic
{
    public class DateTimeProvider
    {
        public virtual DateTime GetNow()
        {
            return DateTime.Now;
        }
    }

    public class TimeOfDayGreeter
    {
        private readonly DateTimeProvider dateTimeProvider;

        public TimeOfDayGreeter(DateTimeProvider dateTimeProvider)
        {
            this.dateTimeProvider = dateTimeProvider;
        }

        public string GetProperGreeting(string name)
        {
            var now = dateTimeProvider.GetNow();
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
