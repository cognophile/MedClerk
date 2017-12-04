CREATE TABLE [dbo].[Patients] (
    [Patient Id]    INT           IDENTITY (300, 6) NOT NULL,
    [Patient Name]          NVARCHAR (50) NOT NULL,
    [Date of Birth] DATE          NOT NULL,
    [Address]       NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Patient Id] ASC)
);

