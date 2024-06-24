USE [FireDepartmentManagerWebAppDb]
GO

/****** Object: Table [dbo].[Vehicles] Script Date: 6/24/2024 12:22:50 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Vehicles] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [CarModel]    NVARCHAR (50) NOT NULL,
    [IsMonday]    BIT           NOT NULL,
    [IsTuesday]   BIT           NOT NULL,
    [IsWednesday] BIT           NOT NULL,
    [IsThursday]  BIT           NOT NULL,
    [IsFriday]    BIT           NOT NULL,
    [IsSaturday]  BIT           NOT NULL,
    [isSunday]    BIT           NOT NULL
);


