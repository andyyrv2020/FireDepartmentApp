USE [FireDepartmentManagerWebAppDb]
GO

/****** Object: Table [dbo].[Employees] Script Date: 6/24/2024 12:22:34 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employees] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]    NVARCHAR (MAX) NOT NULL,
    [LastName]     NVARCHAR (MAX) NOT NULL,
    [DateOfBirth]  DATE           NOT NULL,
    [EmailAddress] NVARCHAR (MAX) NOT NULL,
    [PhoneNumber]  NVARCHAR (MAX) NOT NULL,
    [VehicleId]    INT            NULL
);


GO
CREATE NONCLUSTERED INDEX [IX_Employees_VehicleId]
    ON [dbo].[Employees]([VehicleId] ASC);


GO
ALTER TABLE [dbo].[Employees]
    ADD CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED ([Id] ASC);


GO
ALTER TABLE [dbo].[Employees]
    ADD CONSTRAINT [FK_Employees_Vehicles_VehicleId] FOREIGN KEY ([VehicleId]) REFERENCES [dbo].[Vehicles] ([Id]) ON DELETE SET NULL;


