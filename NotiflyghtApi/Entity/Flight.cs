using System.ComponentModel.DataAnnotations;

namespace NotiflyghtApi.Entity;

public class Flight
{
    [Key]
    public long Id { get; set; }
    public string FlightNumber { get; set; }
    public DateTime FlightDate { get; set; }
    public IEnumerable<FlightSubscription> NotificationEmails { get; set; }
}