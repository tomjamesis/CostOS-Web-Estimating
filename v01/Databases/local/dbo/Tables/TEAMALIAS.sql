﻿CREATE TABLE [dbo].[TEAMALIAS] (
    [ID]    BIGINT         IDENTITY (1, 1) NOT NULL,
    [TEAM]  NVARCHAR (255) NULL,
    [ALIAS] NVARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IDX_ALIAS]
    ON [dbo].[TEAMALIAS]([ALIAS] ASC);


GO
CREATE NONCLUSTERED INDEX [IDX_TEAM]
    ON [dbo].[TEAMALIAS]([TEAM] ASC);

