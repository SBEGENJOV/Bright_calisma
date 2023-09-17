
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/16/2023 11:29:45
-- Generated from EDMX file: C:\Users\S_BEGENJOV\Documents\GitHub\Bright_calisma\Web_Calısmaları\Temp_MF_project\user_admin\user_admin\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_plazafirma]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[firmaSet] DROP CONSTRAINT [FK_plazafirma];
GO
IF OBJECT_ID(N'[dbo].[FK_firmadepertman]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[depertmanSet] DROP CONSTRAINT [FK_firmadepertman];
GO
IF OBJECT_ID(N'[dbo].[FK_depertmancalisan]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[calisanSet] DROP CONSTRAINT [FK_depertmancalisan];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[plazaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[plazaSet];
GO
IF OBJECT_ID(N'[dbo].[firmaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[firmaSet];
GO
IF OBJECT_ID(N'[dbo].[depertmanSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[depertmanSet];
GO
IF OBJECT_ID(N'[dbo].[calisanSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[calisanSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'plazaSet'
CREATE TABLE [dbo].[plazaSet] (
    [plazaNo] int IDENTITY(1,1) NOT NULL,
    [plazaAd] nvarchar(max)  NOT NULL,
    [plazaAdres] nvarchar(max)  NOT NULL,
    [plazaTel] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'firmaSet'
CREATE TABLE [dbo].[firmaSet] (
    [firmaNo] int IDENTITY(1,1) NOT NULL,
    [firmaAd] nvarchar(max)  NOT NULL,
    [firmaAdres] nvarchar(max)  NOT NULL,
    [firmaTel] nvarchar(max)  NOT NULL,
    [plazaNo] int  NOT NULL
);
GO

-- Creating table 'depertmanSet'
CREATE TABLE [dbo].[depertmanSet] (
    [depertmanNo] int IDENTITY(1,1) NOT NULL,
    [depertmanAd] nvarchar(max)  NOT NULL,
    [depertmanAdres] nvarchar(max)  NOT NULL,
    [depertmanTel] nvarchar(max)  NOT NULL,
    [firmaNo] int  NOT NULL
);
GO

-- Creating table 'calisanSet'
CREATE TABLE [dbo].[calisanSet] (
    [calisanNo] int IDENTITY(1,1) NOT NULL,
    [calisanAdSoyad] nvarchar(max)  NOT NULL,
    [calisanAdres] nvarchar(max)  NOT NULL,
    [calisanTel] nvarchar(max)  NOT NULL,
    [depertmanNo] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [plazaNo] in table 'plazaSet'
ALTER TABLE [dbo].[plazaSet]
ADD CONSTRAINT [PK_plazaSet]
    PRIMARY KEY CLUSTERED ([plazaNo] ASC);
GO

-- Creating primary key on [firmaNo] in table 'firmaSet'
ALTER TABLE [dbo].[firmaSet]
ADD CONSTRAINT [PK_firmaSet]
    PRIMARY KEY CLUSTERED ([firmaNo] ASC);
GO

-- Creating primary key on [depertmanNo] in table 'depertmanSet'
ALTER TABLE [dbo].[depertmanSet]
ADD CONSTRAINT [PK_depertmanSet]
    PRIMARY KEY CLUSTERED ([depertmanNo] ASC);
GO

-- Creating primary key on [calisanNo] in table 'calisanSet'
ALTER TABLE [dbo].[calisanSet]
ADD CONSTRAINT [PK_calisanSet]
    PRIMARY KEY CLUSTERED ([calisanNo] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [plazaNo] in table 'firmaSet'
ALTER TABLE [dbo].[firmaSet]
ADD CONSTRAINT [FK_plazafirma]
    FOREIGN KEY ([plazaNo])
    REFERENCES [dbo].[plazaSet]
        ([plazaNo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_plazafirma'
CREATE INDEX [IX_FK_plazafirma]
ON [dbo].[firmaSet]
    ([plazaNo]);
GO

-- Creating foreign key on [firmaNo] in table 'depertmanSet'
ALTER TABLE [dbo].[depertmanSet]
ADD CONSTRAINT [FK_firmadepertman]
    FOREIGN KEY ([firmaNo])
    REFERENCES [dbo].[firmaSet]
        ([firmaNo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_firmadepertman'
CREATE INDEX [IX_FK_firmadepertman]
ON [dbo].[depertmanSet]
    ([firmaNo]);
GO

-- Creating foreign key on [depertmanNo] in table 'calisanSet'
ALTER TABLE [dbo].[calisanSet]
ADD CONSTRAINT [FK_depertmancalisan]
    FOREIGN KEY ([depertmanNo])
    REFERENCES [dbo].[depertmanSet]
        ([depertmanNo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_depertmancalisan'
CREATE INDEX [IX_FK_depertmancalisan]
ON [dbo].[calisanSet]
    ([depertmanNo]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------