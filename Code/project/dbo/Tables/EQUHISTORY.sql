﻿CREATE TABLE [dbo].[EQUHISTORY] (
    [ID]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [EQUIPMENTID] BIGINT         NULL,
    [BASETABLEID] NVARCHAR (255) NULL,
    [RSRC]        NVARCHAR (MAX) NULL,
    [PREDDATE]    DATETIME2 (7)  NULL,
    [PRJID]       BIGINT         NULL,
    [REF__ID]     BIGINT         NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FKA141F32BB2878194] FOREIGN KEY ([EQUIPMENTID]) REFERENCES [dbo].[EQUIPMENT] ([EQUIPMENTID])
);


GO
CREATE NONCLUSTERED INDEX [IDX_EQUIPMENT]
    ON [dbo].[EQUHISTORY]([EQUIPMENTID] ASC);


GO
CREATE NONCLUSTERED INDEX [IDX_PRJID]
    ON [dbo].[EQUHISTORY]([PRJID] ASC);

