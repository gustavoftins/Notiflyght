namespace NotiflyghtApi.Entity;

public class FlightSubscription
{
    public FlightSubscription(string notificationEmail)
    {
        NotificationEmail = notificationEmail;
    }

    public long Id { get; set; }
    public string NotificationEmail { get; set; }
    public long FlightId { get; set; }
}