USE [FireDepartmentManagerWebAppDb]
GO

/****** Object: Table [dbo].[Incidents] Script Date: 6/24/2024 12:22:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Incidents] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [Address]       NVARCHAR (100) NOT NULL,
    [Type]          NVARCHAR (MAX) NOT NULL,
    [WaterUsed]     FLOAT (53)     NOT NULL,
    [IncidentStart] DATETIME2 (7)  NOT NULL,
    [IncidentEnd]   DATETIME2 (7)  NOT NULL,
    [VehicleId]     INT            NULL,
    [EmployeeId]    INT            NULL
);


GO
CREATE NONCLUSTERED INDEX [IX_Incidents_EmployeeId]
    ON [dbo].[Incidents]([EmployeeId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Incidents_VehicleId]
    ON [dbo].[Incidents]([VehicleId] ASC);


GO
ALTER TABLE [dbo].[Incidents]
    ADD CONSTRAINT [PK_Incidents] PRIMARY KEY CLUSTERED ([Id] ASC);


GO
ALTER TABLE [dbo].[Incidents]
    ADD CONSTRAINT [FK_Incidents_Employees_EmployeeId] FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employees] ([Id]) ON DELETE SET NULL;


GO
ALTER TABLE [dbo].[Incidents]
    ADD CONSTRAINT [FK_Incidents_Vehicles_VehicleId] FOREIGN KEY ([VehicleId]) REFERENCES [dbo].[Vehicles] ([Id]) ON DELETE SET NULL;


