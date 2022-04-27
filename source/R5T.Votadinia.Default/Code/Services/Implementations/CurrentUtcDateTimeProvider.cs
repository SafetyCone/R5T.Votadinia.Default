using System;

using R5T.T0064;


namespace R5T.Votadinia.Default
{
    [ServiceImplementationMarker]
    public class CurrentUtcDateTimeProvider : ICurrentUtcDateTimeProvider, IServiceImplementation
    {
        public DateTime GetCurrentUtcDateTime()
        {
            var currentUtcDateTime = DateTime.UtcNow;
            return currentUtcDateTime;
        }
    }
}
