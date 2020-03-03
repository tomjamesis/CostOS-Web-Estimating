﻿CREATE TABLE [dbo].[EXTRACODE7] (
    [GROUPCODEID] BIGINT           IDENTITY (1, 1) NOT NULL,
    [LASTUPDATE]  DATETIME2 (7)    NULL,
    [DESCRIPTION] NVARCHAR (MAX)   NULL,
    [GROUPCODE]   NVARCHAR (255)   NULL,
    [TITLE]       NVARCHAR (MAX)   NULL,
    [NOTES]       NVARCHAR (255)   NULL,
    [EDITORID]    NVARCHAR (255)   NULL,
    [UFACT]       NUMERIC (30, 10) NULL,
    [UNIT]        NVARCHAR (255)   NULL,
    PRIMARY KEY CLUSTERED ([GROUPCODEID] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IDX_GROUPCODE]
    ON [dbo].[EXTRACODE7]([GROUPCODE] ASC);

