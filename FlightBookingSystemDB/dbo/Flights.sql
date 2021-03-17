CREATE TABLE [dbo].[Flights]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Number] NVARCHAR(20) NOT NULL, 
    [DepartureDateTime] DATETIME2 NOT NULL, 
    [ArrivalDateTime] DATETIME2 NOT NULL, 
    [DurationOnInMinutes] INT NOT NULL, 
    [DistanceInMiles] INT NOT NULL, 
    [DepartureAirportId] INT NOT NULL, 
    [ArrivalAirportId] INT NOT NULL
)
