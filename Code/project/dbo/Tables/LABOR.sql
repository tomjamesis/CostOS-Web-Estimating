﻿CREATE TABLE [dbo].[LABOR] (
    [LABORID]              BIGINT           IDENTITY (1, 1) NOT NULL,
    [DESCRIPTION]          NVARCHAR (MAX)   NULL,
    [UNIT]                 NVARCHAR (255)   NULL,
    [RATE]                 NUMERIC (30, 10) NULL,
    [IKA]                  NUMERIC (30, 10) NULL,
    [TOTALRATE]            NUMERIC (30, 10) NULL,
    [GROUPCODE]            NVARCHAR (255)   NULL,
    [GEKCODE]              NVARCHAR (255)   NULL,
    [PROJECT]              NVARCHAR (255)   NULL,
    [VIRTUAL]              BIT              NULL,
    [PREDICTED]            BIT              NULL,
    [CONCEPTUAL]           BIT              NULL,
    [TCHTYPE]              INT              NULL,
    [TUNIT]                NUMERIC (30, 10) NULL,
    [TVAL]                 NVARCHAR (255)   NULL,
    [TCOLOR]               INT              NULL,
    [TREGTYPE]             INT              NULL,
    [TRIDS]                NVARCHAR (MAX)   NULL,
    [TRDATE]               DATETIME2 (7)    NULL,
    [CONTACTPERSON]        NVARCHAR (255)   NULL,
    [PHONENUMBER]          NVARCHAR (255)   NULL,
    [MOBILENUMBER]         NVARCHAR (255)   NULL,
    [FAXNUMBER]            NVARCHAR (255)   NULL,
    [EMAIL]                NVARCHAR (255)   NULL,
    [CITY]                 NVARCHAR (255)   NULL,
    [ADDRESS]              NVARCHAR (255)   NULL,
    [NOTES]                NVARCHAR (255)   NULL,
    [EDITORID]             NVARCHAR (255)   NULL,
    [STATEPROVINCE]        NVARCHAR (255)   NULL,
    [COUNTRY]              NVARCHAR (255)   NULL,
    [CREATEUSER]           NVARCHAR (255)   NULL,
    [CREATEDATE]           DATETIME2 (7)    NULL,
    [LASTUPDATE]           DATETIME2 (7)    NULL,
    [ACCRIGHTS]            NVARCHAR (255)   NULL,
    [KEYW]                 NVARCHAR (MAX)   NULL,
    [RESCODE]              NVARCHAR (255)   NULL,
    [TITLE]                NVARCHAR (MAX)   NULL,
    [CURRENCY]             NVARCHAR (255)   NULL,
    [DATABASEID]           BIGINT           NULL,
    [DATABASECREATIONDATE] BIGINT           NULL,
    [EXTRACODE1]           NVARCHAR (255)   NULL,
    [EXTRACODE2]           NVARCHAR (255)   NULL,
    [EXTRACODE3]           NVARCHAR (255)   NULL,
    [EXTRACODE4]           NVARCHAR (255)   NULL,
    [EXTRACODE5]           NVARCHAR (255)   NULL,
    [EXTRACODE6]           NVARCHAR (255)   NULL,
    [EXTRACODE7]           NVARCHAR (255)   NULL,
    [EXTRACODE8]           NVARCHAR (255)   NULL,
    [EXTRACODE9]           NVARCHAR (255)   NULL,
    [EXTRACODE10]          NVARCHAR (255)   NULL,
    [BURATE]               NUMERIC (30, 10) NULL,
    [OVERTYPE]             INT              NULL,
    [PRJID]                BIGINT           NULL,
    [REF__ID]              BIGINT           NULL,
    PRIMARY KEY CLUSTERED ([LABORID] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IDX_MDBID]
    ON [dbo].[LABOR]([DATABASEID] ASC);


GO
CREATE NONCLUSTERED INDEX [IDX_PRJID]
    ON [dbo].[LABOR]([PRJID] ASC);

