using System;

namespace DependencyInjection_DateTime_Begin.Logic
{
    public class TimeOfDayGreeter
    {
        public string GetProperGreeting(string name)
        {
            var now = DateTime.Now;
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
