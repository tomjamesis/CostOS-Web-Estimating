﻿CREATE TABLE [dbo].[GLBPROP] (
    [ID]   BIGINT         IDENTITY (1, 1) NOT NULL,
    [PKEY] NVARCHAR (255) NULL,
    [PVAL] NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IDX_PROPKEY]
    ON [dbo].[GLBPROP]([PKEY] ASC);

