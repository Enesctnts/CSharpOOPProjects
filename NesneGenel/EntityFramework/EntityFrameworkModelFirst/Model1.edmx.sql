
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/03/2022 11:58:24
-- Generated from EDMX file: C:\Users\303ENES_SABAH\Documents\GitHub\CSharpOOP\NesneGenel\EntityFramework\EntityFrameworkModelFirst\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [OtoDB];
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

-- Creating table 'OtomobilSet'
CREATE TABLE [dbo].[OtomobilSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Plaka] nvarchar(max)  NOT NULL,
    [Marka] nvarchar(max)  NOT NULL,
    [Fiyat] decimal(18,0)  NOT NULL,
    [Renk] nvarchar(max)  NOT NULL,
    [Model] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'OtomobilSet'
ALTER TABLE [dbo].[OtomobilSet]
ADD CONSTRAINT [PK_OtomobilSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------