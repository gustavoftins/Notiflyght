namespace NotiflyghtApi.Entity;

public class FlightSubscription
{
    public long Id { get; set; }
    public string NotificationEmail { get; set; }
    public long FlightId { get; set; }
}