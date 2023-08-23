CREATE TABLE [dbo].[LibUsers] (
    [StudentId] NVARCHAR (50) NOT NULL,
    [UserName]  NVARCHAR (50) NULL,
    [Password]  NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([StudentId] ASC)
);

