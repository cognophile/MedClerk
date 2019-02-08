CREATE TABLE [dbo].[Staff] (
    [Staff Id]   INT           IDENTITY (101, 3) NOT NULL,
    [Title]      NVARCHAR (50) NOT NULL,
    [Name] NVARCHAR (50) NOT NULL,
    [Room]       INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Staff Id] ASC)
);

