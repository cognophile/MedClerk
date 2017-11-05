CREATE TABLE [dbo].[Staff] (
    [Id]         INT           IDENTITY (101, 3) NOT NULL,
    [Title]      NVARCHAR (50) NOT NULL,
    [First Name] NVARCHAR (50) NOT NULL,
    [Last Name]  NVARCHAR (50) NOT NULL,
    [Room]       INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Staff_Id] FOREIGN KEY ([StaffId]) REFERENCES [Appointments]([Id])
);

