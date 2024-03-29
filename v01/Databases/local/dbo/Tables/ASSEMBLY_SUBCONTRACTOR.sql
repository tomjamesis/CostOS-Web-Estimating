﻿CREATE TABLE [dbo].[ASSEMBLY_SUBCONTRACTOR] (
    [ASSEMBLYSUBCONTRACTORID] BIGINT           IDENTITY (1, 1) NOT NULL,
    [LASTUPDATE]              DATETIME2 (7)    NULL,
    [FRATE]                   NUMERIC (30, 10) NULL,
    [FIKARATE]                NUMERIC (30, 10) NULL,
    [FACTOR1]                 NUMERIC (30, 10) NULL,
    [FACTOR2]                 NUMERIC (30, 10) NULL,
    [FACTOR3]                 NUMERIC (30, 10) NULL,
    [QTYPUNIT]                NUMERIC (30, 10) NULL,
    [QTYPUNITFORM]            NVARCHAR (MAX)   NULL,
    [QTYPUFORMSTATE]          TINYINT          NULL,
    [LOCALFACTOR]             NUMERIC (30, 10) NULL,
    [LOCALCOUNTRY]            NVARCHAR (255)   NULL,
    [LOCALSTATE]              NVARCHAR (255)   NULL,
    [EXCHANGERATE]            NUMERIC (30, 10) NULL,
    [FIXEDCOST]               NUMERIC (30, 10) NULL,
    [FINALFIXEDCOST]          NUMERIC (30, 10) NULL,
    [PV_VARS]                 NVARCHAR (MAX)   NULL,
    [SUBCONTRACTORID]         BIGINT           NULL,
    [ASSEMBLYID]              BIGINT           NULL,
    PRIMARY KEY CLUSTERED ([ASSEMBLYSUBCONTRACTORID] ASC),
    CONSTRAINT [FK3F0CDDFC14030E1E] FOREIGN KEY ([ASSEMBLYID]) REFERENCES [dbo].[ASSEMBLY] ([ASSEMBLYID]),
    CONSTRAINT [FK3F0CDDFC7C0276B4] FOREIGN KEY ([SUBCONTRACTORID]) REFERENCES [dbo].[SUBCONTRACTOR] ([SUBCONTRACTORID])
);

