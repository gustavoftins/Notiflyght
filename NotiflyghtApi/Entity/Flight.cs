using System.ComponentModel.DataAnnotations;

namespace NotiflyghtApi.Entity;

public class Flight
{
    [Key]
    public long Id { get; set; }
    public string FlightNumber { get; set; }
    public DateTimeOffset FlightDate { get; set; }
    public IEnumerable<FlightSubscription> NotificationEmails { get; set; }


    public Flight()    {
    }

    public Flight(string flightNumber, DateTimeOffset flightDate, string notificationEmail)
    {
        FlightNumber = flightNumber;
        FlightDate = flightDate.UtcDateTime.Date;
        NotificationEmails = [new FlightSubscription(notificationEmail)];
    }
}