
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/19/2023 09:28:24
-- Generated from EDMX file: C:\Users\S_BEGENJOV\Desktop\wissen\Consol\ev_calısma\modelfirstproject\modelfirstproject\school.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [School];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'studentSet'
CREATE TABLE [dbo].[studentSet] (
    [studentID] int IDENTITY(1,1) NOT NULL,
    [studentNameSurname] nvarchar(max)  NOT NULL,
    [studentAge] int  NOT NULL,
    [studentPhone] nvarchar(max)  NOT NULL,
    [studentAdres] nvarchar(max)  NOT NULL,
    [teacherID] int  NOT NULL
);
GO

-- Creating table 'teacherSet'
CREATE TABLE [dbo].[teacherSet] (
    [teacherID] int IDENTITY(1,1) NOT NULL,
    [teacherNameSurname] nvarchar(max)  NOT NULL,
    [teacherWage] decimal(18,0)  NOT NULL,
    [teacherBranch] nvarchar(max)  NOT NULL,
    [teacherMail] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [studentID] in table 'studentSet'
ALTER TABLE [dbo].[studentSet]
ADD CONSTRAINT [PK_studentSet]
    PRIMARY KEY CLUSTERED ([studentID] ASC);
GO

-- Creating primary key on [teacherID] in table 'teacherSet'
ALTER TABLE [dbo].[teacherSet]
ADD CONSTRAINT [PK_teacherSet]
    PRIMARY KEY CLUSTERED ([teacherID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [teacherID] in table 'studentSet'
ALTER TABLE [dbo].[studentSet]
ADD CONSTRAINT [FK_teacherstudent]
    FOREIGN KEY ([teacherID])
    REFERENCES [dbo].[teacherSet]
        ([teacherID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_teacherstudent'
CREATE INDEX [IX_FK_teacherstudent]
ON [dbo].[studentSet]
    ([teacherID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------