﻿CREATE TABLE [dbo].[PROJECTEPS] (
    [PROJECTEPSID] BIGINT         IDENTITY (1, 1) NOT NULL,
    [CODE]         NVARCHAR (255) NULL,
    [TITLE]        NVARCHAR (255) NULL,
    [EDITORID]     NVARCHAR (255) NULL,
    [DESCRIPTION]  NVARCHAR (MAX) NULL,
    [LASTUPDATE]   DATETIME2 (7)  NULL,
    [PARENTID]     BIGINT         NULL,
    PRIMARY KEY CLUSTERED ([PROJECTEPSID] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IDX_CODE]
    ON [dbo].[PROJECTEPS]([CODE] ASC);

