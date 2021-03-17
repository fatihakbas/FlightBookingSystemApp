CREATE TABLE [dbo].[Tickets]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TicketNumber] NVARCHAR(50) NOT NULL, 
    [Price] FLOAT NOT NULL, 
    [ConfirmationNumber] NVARCHAR(50) NOT NULL
)
