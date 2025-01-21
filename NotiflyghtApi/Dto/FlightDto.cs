namespace NotiflyghtApi.Dto;

public class FlightDto
{
    public string FlightNumber { get; set; }
    public DateTimeOffset FlightDate { get; set; }
    public string NotificationEmail { get; set; }
}