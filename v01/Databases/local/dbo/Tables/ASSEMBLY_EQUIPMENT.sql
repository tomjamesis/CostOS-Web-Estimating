﻿CREATE TABLE [dbo].[ASSEMBLY_EQUIPMENT] (
    [ASSEMBLYEQUIPMENTID] BIGINT           IDENTITY (1, 1) NOT NULL,
    [LASTUPDATE]          DATETIME2 (7)    NULL,
    [FRATE]               NUMERIC (30, 10) NULL,
    [FDEPRATE]            NUMERIC (30, 10) NULL,
    [ENERGYPRICE]         NUMERIC (30, 10) NULL,
    [FINALFUELRATE]       NUMERIC (30, 10) NULL,
    [FUELRATE]            NUMERIC (30, 10) NULL,
    [FACTOR1]             NUMERIC (30, 10) NULL,
    [FACTOR2]             NUMERIC (30, 10) NULL,
    [FACTOR3]             NUMERIC (30, 10) NULL,
    [QTYPUNIT]            NUMERIC (30, 10) NULL,
    [QTYPUNITFORM]        NVARCHAR (MAX)   NULL,
    [QTYPUFORMSTATE]      TINYINT          NULL,
    [LOCALFACTOR]         NUMERIC (30, 10) NULL,
    [LOCALCOUNTRY]        NVARCHAR (255)   NULL,
    [LOCALSTATE]          NVARCHAR (255)   NULL,
    [EXCHANGERATE]        NUMERIC (30, 10) NULL,
    [FIXEDCOST]           NUMERIC (30, 10) NULL,
    [FINALFIXEDCOST]      NUMERIC (30, 10) NULL,
    [UNITHOURS]           NUMERIC (30, 10) NULL,
    [PV_VARS]             NVARCHAR (MAX)   NULL,
    [EQUIPMENTID]         BIGINT           NULL,
    [ASSEMBLYID]          BIGINT           NULL,
    PRIMARY KEY CLUSTERED ([ASSEMBLYEQUIPMENTID] ASC),
    CONSTRAINT [FK71C9765514030E1E] FOREIGN KEY ([ASSEMBLYID]) REFERENCES [dbo].[ASSEMBLY] ([ASSEMBLYID]),
    CONSTRAINT [FK71C97655B2878194] FOREIGN KEY ([EQUIPMENTID]) REFERENCES [dbo].[EQUIPMENT] ([EQUIPMENTID])
);

