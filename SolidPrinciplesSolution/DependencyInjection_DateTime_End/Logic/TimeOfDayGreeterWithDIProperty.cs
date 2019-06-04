namespace DependencyInjection_DateTime_End.Logic
{
    public class TimeOfDayGreeterWithDIProperty
    {
        public IDateTimeProvider DateTimeProvider { get; set; }

        public TimeOfDayGreeterWithDIProperty()
        {
        }

        public string GetProperGreeting(string name)
        {
            var now = DateTimeProvider.GetDateNow();
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
