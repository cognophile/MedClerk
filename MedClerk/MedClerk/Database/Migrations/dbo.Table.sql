CREATE TABLE [dbo].[Appointments]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Staff_Id] INT NULL, 
    [Patient_Id] INT NULL, 
    [date] DATETIME NULL, 
    [time] TIME NULL, 
    CONSTRAINT [FK_Appointments_ToTable] FOREIGN KEY ([Column]) REFERENCES [ToTable]([ToTableColumn])
)
