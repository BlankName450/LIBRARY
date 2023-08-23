CREATE TABLE [dbo].[Books] (
    [ISBN]     NVARCHAR (50) NOT NULL,
    [Category] NVARCHAR (50) NULL,
    [Quantity] INT           NULL,
    [Author]   NVARCHAR (50) NULL,
    [Title]    NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED ([ISBN] ASC)
);

