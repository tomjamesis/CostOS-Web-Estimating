﻿CREATE TABLE [dbo].[QUERYROW] (
    [QROWID]     BIGINT         IDENTITY (1, 1) NOT NULL,
    [FNAME]      NVARCHAR (255) NULL,
    [RNAME]      NVARCHAR (255) NULL,
    [CNDN]       NVARCHAR (MAX) NULL,
    [CTYPE]      NVARCHAR (255) NULL,
    [QRESID]     BIGINT         NULL,
    [PRJID]      BIGINT         NULL,
    [QROWSCOUNT] INT            NULL,
    [REF__ID]    BIGINT         NULL,
    PRIMARY KEY CLUSTERED ([QROWID] ASC),
    CONSTRAINT [FKE91C7C12AB986C17] FOREIGN KEY ([QRESID]) REFERENCES [dbo].[QUERYRESOURCE] ([QRESID])
);


GO
CREATE NONCLUSTERED INDEX [IDX_PRJID]
    ON [dbo].[QUERYROW]([PRJID] ASC);


GO
CREATE NONCLUSTERED INDEX [IDX_QUERYRESOURCE]
    ON [dbo].[QUERYROW]([QRESID] ASC);

