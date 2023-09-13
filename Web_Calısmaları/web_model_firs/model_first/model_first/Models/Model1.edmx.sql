
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/13/2023 21:47:00
-- Generated from EDMX file: C:\Users\S_BEGENJOV\Documents\GitHub\Bright_calisma\Web_Calısmaları\web_model_firs\model_first\model_first\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [mfweb];
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

-- Creating table 'PersonelSet'
CREATE TABLE [dbo].[PersonelSet] (
    [PersonelNo] int IDENTITY(1,1) NOT NULL,
    [AdSoyad] nvarchar(max)  NOT NULL,
    [Yas] int  NOT NULL,
    [Telefon] nvarchar(max)  NOT NULL,
    [Adres] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UrunSet'
CREATE TABLE [dbo].[UrunSet] (
    [UrunNo] int IDENTITY(1,1) NOT NULL,
    [UrunAdi] nvarchar(max)  NOT NULL,
    [Fiyat] int  NOT NULL,
    [Marka] nvarchar(max)  NOT NULL,
    [Model] nvarchar(max)  NOT NULL,
    [PersonelNo] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [PersonelNo] in table 'PersonelSet'
ALTER TABLE [dbo].[PersonelSet]
ADD CONSTRAINT [PK_PersonelSet]
    PRIMARY KEY CLUSTERED ([PersonelNo] ASC);
GO

-- Creating primary key on [UrunNo] in table 'UrunSet'
ALTER TABLE [dbo].[UrunSet]
ADD CONSTRAINT [PK_UrunSet]
    PRIMARY KEY CLUSTERED ([UrunNo] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PersonelNo] in table 'UrunSet'
ALTER TABLE [dbo].[UrunSet]
ADD CONSTRAINT [FK_PersonelUrun]
    FOREIGN KEY ([PersonelNo])
    REFERENCES [dbo].[PersonelSet]
        ([PersonelNo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonelUrun'
CREATE INDEX [IX_FK_PersonelUrun]
ON [dbo].[UrunSet]
    ([PersonelNo]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------