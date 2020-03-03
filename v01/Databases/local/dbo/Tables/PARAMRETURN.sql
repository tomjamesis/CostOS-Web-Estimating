﻿CREATE TABLE [dbo].[PARAMRETURN] (
    [PARAMRETURNID] BIGINT         IDENTITY (1, 1) NOT NULL,
    [RETEQ]         NVARCHAR (MAX) NULL,
    [PARAMITEMID]   BIGINT         NULL,
    PRIMARY KEY CLUSTERED ([PARAMRETURNID] ASC),
    CONSTRAINT [FKE5568BDDB8FEF034] FOREIGN KEY ([PARAMITEMID]) REFERENCES [dbo].[PARAMITEM] ([PARAMITEMID])
);

