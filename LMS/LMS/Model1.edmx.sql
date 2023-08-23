
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/29/2021 00:15:06
-- Generated from EDMX file: D:\Library Project\LMS\LMS\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [LibMS];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_LoanBook_ToTable]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LoanBook] DROP CONSTRAINT [FK_LoanBook_ToTable];
GO
IF OBJECT_ID(N'[dbo].[FK_LoanBook_ToTable_1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LoanBook] DROP CONSTRAINT [FK_LoanBook_ToTable_1];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Books]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Books];
GO
IF OBJECT_ID(N'[dbo].[Category]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Category];
GO
IF OBJECT_ID(N'[dbo].[LibMSAdmin]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LibMSAdmin];
GO
IF OBJECT_ID(N'[dbo].[LibUsers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LibUsers];
GO
IF OBJECT_ID(N'[dbo].[LoanBook]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LoanBook];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Books'
CREATE TABLE [dbo].[Books] (
    [ISBN] nvarchar(50)  NOT NULL,
    [Category] nvarchar(50)  NULL,
    [Quantity] int  NULL,
    [Author] nvarchar(50)  NULL,
    [Title] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(50)  NULL
);
GO

-- Creating table 'LibMSAdmins'
CREATE TABLE [dbo].[LibMSAdmins] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(50)  NULL,
    [Password] nvarchar(50)  NULL
);
GO

-- Creating table 'LibUsers'
CREATE TABLE [dbo].[LibUsers] (
    [StudentId] nvarchar(50)  NOT NULL,
    [UserName] nvarchar(50)  NULL,
    [Password] nvarchar(50)  NULL
);
GO

-- Creating table 'LoanBooks'
CREATE TABLE [dbo].[LoanBooks] (
    [Id] int  NOT NULL,
    [ISBN] nvarchar(50)  NOT NULL,
    [StudentId] nvarchar(50)  NOT NULL,
    [LoanReturn] bit  NULL,
    [StudentName] nvarchar(50)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ISBN] in table 'Books'
ALTER TABLE [dbo].[Books]
ADD CONSTRAINT [PK_Books]
    PRIMARY KEY CLUSTERED ([ISBN] ASC);
GO

-- Creating primary key on [Id] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'LibMSAdmins'
ALTER TABLE [dbo].[LibMSAdmins]
ADD CONSTRAINT [PK_LibMSAdmins]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [StudentId] in table 'LibUsers'
ALTER TABLE [dbo].[LibUsers]
ADD CONSTRAINT [PK_LibUsers]
    PRIMARY KEY CLUSTERED ([StudentId] ASC);
GO

-- Creating primary key on [Id] in table 'LoanBooks'
ALTER TABLE [dbo].[LoanBooks]
ADD CONSTRAINT [PK_LoanBooks]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ISBN] in table 'LoanBooks'
ALTER TABLE [dbo].[LoanBooks]
ADD CONSTRAINT [FK_LoanBook_ToTable]
    FOREIGN KEY ([ISBN])
    REFERENCES [dbo].[Books]
        ([ISBN])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LoanBook_ToTable'
CREATE INDEX [IX_FK_LoanBook_ToTable]
ON [dbo].[LoanBooks]
    ([ISBN]);
GO

-- Creating foreign key on [StudentId] in table 'LoanBooks'
ALTER TABLE [dbo].[LoanBooks]
ADD CONSTRAINT [FK_LoanBook_ToTable_1]
    FOREIGN KEY ([StudentId])
    REFERENCES [dbo].[LibUsers]
        ([StudentId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LoanBook_ToTable_1'
CREATE INDEX [IX_FK_LoanBook_ToTable_1]
ON [dbo].[LoanBooks]
    ([StudentId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------