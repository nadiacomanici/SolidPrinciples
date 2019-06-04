using System;

namespace DependencyInjection_DateTime_End.Logic
{
    public interface IDateTimeProvider
    {
        DateTime GetDateNow();
    }
}
