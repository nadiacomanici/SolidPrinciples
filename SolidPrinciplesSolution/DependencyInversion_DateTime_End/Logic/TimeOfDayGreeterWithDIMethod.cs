namespace DependencyInversion_DateTime_End.Logic
{
    public class TimeOfDayGreeterWithDIMethod
    {
        public TimeOfDayGreeterWithDIMethod()
        {
        }

        public string GetProperGreeting(IDateTimeProvider dateTimeProvider, string name)
        {
            var now = dateTimeProvider.GetDateNow();
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
