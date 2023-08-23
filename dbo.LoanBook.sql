CREATE TABLE [dbo].[LoanBook] (
    [Id]          INT           NOT NULL,
    [ISBN]        NVARCHAR (50) NOT NULL,
    [StudentId]   NVARCHAR (50) NOT NULL,
    [LoanReturn]  BIT           NULL,
    [StudentName] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_LoanBook_ToTable] FOREIGN KEY ([ISBN]) REFERENCES [dbo].[Books] ([ISBN]),
    CONSTRAINT [FK_LoanBook_ToTable_1] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[LibUsers] ([StudentId])
);

