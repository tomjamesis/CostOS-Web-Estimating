﻿CREATE TABLE [dbo].[BOQITEM_ASSEMBLY] (
    [BOQITEMASSEMBLYID] BIGINT           IDENTITY (1, 1) NOT NULL,
    [FRATE]             NUMERIC (30, 10) NULL,
    [FEQURATE]          NUMERIC (30, 10) NULL,
    [FLABRATE]          NUMERIC (30, 10) NULL,
    [FMATRATE]          NUMERIC (30, 10) NULL,
    [FSHPRATE]          NUMERIC (30, 10) NULL,
    [FFABRATE]          NUMERIC (30, 10) NULL,
    [FSUBRATE]          NUMERIC (30, 10) NULL,
    [FCONRATE]          NUMERIC (30, 10) NULL,
    [FIXEDCOST]         NUMERIC (30, 10) NULL,
    [FINALFIXEDCOST]    NUMERIC (30, 10) NULL,
    [VARIABLECOST]      NUMERIC (30, 10) NULL,
    [TOTALCOST]         NUMERIC (30, 10) NULL,
    [LABCOST]           NUMERIC (30, 10) NULL,
    [EQUCOST]           NUMERIC (30, 10) NULL,
    [SUBCOST]           NUMERIC (30, 10) NULL,
    [MATTOTCOST]        NUMERIC (30, 10) NULL,
    [CONCOST]           NUMERIC (30, 10) NULL,
    [FACTOR1]           NUMERIC (30, 10) NULL,
    [PARAMITEMID]       BIGINT           NULL,
    [FACTOR2]           NUMERIC (30, 10) NULL,
    [FACTOR3]           NUMERIC (30, 10) NULL,
    [QTYPUNIT]          NUMERIC (30, 10) NULL,
    [QTYPUNITFORM]      NVARCHAR (MAX)   NULL,
    [QTYPUFORMSTATE]    TINYINT          NULL,
    [COSTCENTER]        NUMERIC (30, 10) NULL,
    [LOCALFACTOR]       NUMERIC (30, 10) NULL,
    [LOCALCOUNTRY]      NVARCHAR (255)   NULL,
    [LOCALSTATE]        NVARCHAR (255)   NULL,
    [TOTALUNITS]        NUMERIC (30, 10) NULL,
    [USERTOTALUNITS]    BIT              NULL,
    [LAST_UPDATE]       DATETIME2 (7)    NULL,
    [PV_VARS]           NVARCHAR (MAX)   NULL,
    [ASSEMBLYID]        BIGINT           NULL,
    [BOQITEMID]         BIGINT           NULL,
    [PRJID]             BIGINT           NULL,
    [REF__ID]           BIGINT           NULL,
    PRIMARY KEY CLUSTERED ([BOQITEMASSEMBLYID] ASC),
    CONSTRAINT [FK9CA97A6E14030E1E] FOREIGN KEY ([ASSEMBLYID]) REFERENCES [dbo].[ASSEMBLY] ([ASSEMBLYID]),
    CONSTRAINT [FK9CA97A6E89F3BCA6] FOREIGN KEY ([BOQITEMID]) REFERENCES [dbo].[BOQITEM] ([BOQITEMID]),
    CONSTRAINT [FK9CA97A6EB8FEF034] FOREIGN KEY ([PARAMITEMID]) REFERENCES [dbo].[PARAMITEM] ([PARAMITEMID])
);


GO
CREATE NONCLUSTERED INDEX [IDX_ASSEMBLY]
    ON [dbo].[BOQITEM_ASSEMBLY]([ASSEMBLYID] ASC);


GO
CREATE NONCLUSTERED INDEX [IDX_BOQITEM]
    ON [dbo].[BOQITEM_ASSEMBLY]([BOQITEMID] ASC);


GO
CREATE NONCLUSTERED INDEX [IDX_PARAMITEM]
    ON [dbo].[BOQITEM_ASSEMBLY]([PARAMITEMID] ASC);


GO
CREATE NONCLUSTERED INDEX [IDX_PRJID]
    ON [dbo].[BOQITEM_ASSEMBLY]([PRJID] ASC);

