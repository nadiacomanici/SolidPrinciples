using System;

namespace DependencyInjection_DateTime_End.Logic
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime GetDateNow()
        {
            return DateTime.Now;
        }
    }
}
