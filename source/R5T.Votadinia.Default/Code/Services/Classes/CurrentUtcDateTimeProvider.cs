using System;


namespace R5T.Votadinia.Default
{
    public class CurrentUtcDateTimeProvider : ICurrentUtcDateTimeProvider
    {
        public DateTime GetCurrentUtcDateTime()
        {
            var currentUtcDateTime = DateTime.UtcNow;
            return currentUtcDateTime;
        }
    }
}
