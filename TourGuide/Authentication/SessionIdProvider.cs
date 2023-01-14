namespace TourGuide.Authentication
{
    public interface ISessionIdProvider
    {
        Guid SessionId { get; }
    }

    public class SessionIdProvider : ISessionIdProvider
    {
        public Guid SessionId { get; } = Guid.NewGuid();
    }
}
