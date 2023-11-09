
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/06/2023 14:45:59
-- Generated from EDMX file: C:\Users\Александр\Desktop\Skillbox проекты\practical task 18 Animals\practical task 18 Animals\AnimalsDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SqlAnimalDB];
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

-- Creating table 'BirdsSet'
CREATE TABLE [dbo].[BirdsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Detachment] nvarchar(max)  NOT NULL,
    [Family] nvarchar(max)  NOT NULL,
    [ViweAnimal] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'AmphibiansSet'
CREATE TABLE [dbo].[AmphibiansSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Detachment] nvarchar(max)  NOT NULL,
    [Family] nvarchar(max)  NOT NULL,
    [ViweAnimal] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MammalsSet'
CREATE TABLE [dbo].[MammalsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Detachment] nvarchar(max)  NOT NULL,
    [Family] nvarchar(max)  NOT NULL,
    [ViweAnimal] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'BirdsSet'
ALTER TABLE [dbo].[BirdsSet]
ADD CONSTRAINT [PK_BirdsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AmphibiansSet'
ALTER TABLE [dbo].[AmphibiansSet]
ADD CONSTRAINT [PK_AmphibiansSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MammalsSet'
ALTER TABLE [dbo].[MammalsSet]
ADD CONSTRAINT [PK_MammalsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------