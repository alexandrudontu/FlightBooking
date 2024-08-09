using System.ComponentModel;

namespace Flights.DTOs
{
    public record FlightSearchParameters(

        [DefaultValue("07/05/2024 11:30:00 AM")]
        DateTime? FromDate,

        [DefaultValue("07/06/2024 11:30:00 AM")]
        DateTime? ToDate,

        [DefaultValue("Los Angeles")]
        string? From,

        [DefaultValue("Berlin")]
        string? Destination,

        [DefaultValue(1)]
        int? NumberOfPassengers
        );

}
