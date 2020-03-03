﻿CREATE TABLE [dbo].[CNTRLOG] (
    [ID]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [LOGDATE]     DATETIME2 (7)  NULL,
    [EDITORID]    NVARCHAR (255) NULL,
    [DESCRIPTION] NVARCHAR (MAX) NULL,
    [SRC]         NVARCHAR (255) NULL,
    [FLTR]        NVARCHAR (255) NULL,
    [PRJID]       BIGINT         NULL,
    [OPRTN]       TINYINT        NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IDX_PRJID]
    ON [dbo].[CNTRLOG]([PRJID] ASC);

