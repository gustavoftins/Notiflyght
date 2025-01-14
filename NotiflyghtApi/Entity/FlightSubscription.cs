namespace NotiflyghtApi.Entity;

public class FlightSubscription
{
    public string FlightNumber { get; set; }
    public DateTime FlightDate { get; set; }
    public IEnumerable<string> NotificationEmails { get; set; }
}