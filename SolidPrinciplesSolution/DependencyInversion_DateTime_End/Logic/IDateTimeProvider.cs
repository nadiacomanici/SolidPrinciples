using System;

namespace DependencyInversion_DateTime_End.Logic
{
    public interface IDateTimeProvider
    {
        DateTime GetDateNow();
    }
}
