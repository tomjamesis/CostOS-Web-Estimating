﻿CREATE TABLE [dbo].[RATEBUILDUPCOLS] (
    [ID]          BIGINT           IDENTITY (1, 1) NOT NULL,
    [TEMPLATEID]  BIGINT           NULL,
    [RESTYPE]     NVARCHAR (MAX)   NULL,
    [TABLEPREF]   NVARCHAR (MAX)   NULL,
    [SORTPREF]    NVARCHAR (MAX)   NULL,
    [APPLYALL]    BIT              NULL,
    [ROWFORMULA]  NVARCHAR (MAX)   NULL,
    [COLNAME0]    NVARCHAR (MAX)   NULL,
    [COLTYPE0]    INT              NULL,
    [COLACT0]     BIT              NULL,
    [COLFORM0]    NVARCHAR (MAX)   NULL,
    [COLNAME1]    NVARCHAR (MAX)   NULL,
    [COLTYPE1]    INT              NULL,
    [COLACT1]     BIT              NULL,
    [COLFORM1]    NVARCHAR (MAX)   NULL,
    [COLNAME2]    NVARCHAR (MAX)   NULL,
    [COLTYPE2]    INT              NULL,
    [COLACT2]     BIT              NULL,
    [COLFORM2]    NVARCHAR (MAX)   NULL,
    [COLNAME3]    NVARCHAR (MAX)   NULL,
    [COLTYPE3]    INT              NULL,
    [COLACT3]     BIT              NULL,
    [COLFORM3]    NVARCHAR (MAX)   NULL,
    [COLNAME4]    NVARCHAR (MAX)   NULL,
    [COLTYPE4]    INT              NULL,
    [COLACT4]     BIT              NULL,
    [COLFORM4]    NVARCHAR (MAX)   NULL,
    [COLNAME5]    NVARCHAR (MAX)   NULL,
    [COLTYPE5]    INT              NULL,
    [COLACT5]     BIT              NULL,
    [COLFORM5]    NVARCHAR (MAX)   NULL,
    [COLNAME6]    NVARCHAR (MAX)   NULL,
    [COLTYPE6]    INT              NULL,
    [COLACT6]     BIT              NULL,
    [COLFORM6]    NVARCHAR (MAX)   NULL,
    [COLNAME7]    NVARCHAR (MAX)   NULL,
    [COLTYPE7]    INT              NULL,
    [COLACT7]     BIT              NULL,
    [COLFORM7]    NVARCHAR (MAX)   NULL,
    [COLNAME8]    NVARCHAR (MAX)   NULL,
    [COLTYPE8]    INT              NULL,
    [COLACT8]     BIT              NULL,
    [COLFORM8]    NVARCHAR (MAX)   NULL,
    [COLNAME9]    NVARCHAR (MAX)   NULL,
    [COLTYPE9]    INT              NULL,
    [COLACT9]     BIT              NULL,
    [COLFORM9]    NVARCHAR (MAX)   NULL,
    [COLNAME10]   NVARCHAR (MAX)   NULL,
    [COLTYPE10]   INT              NULL,
    [COLACT10]    BIT              NULL,
    [COLFORM10]   NVARCHAR (MAX)   NULL,
    [COLNAME11]   NVARCHAR (MAX)   NULL,
    [COLTYPE11]   INT              NULL,
    [COLACT11]    BIT              NULL,
    [COLFORM11]   NVARCHAR (MAX)   NULL,
    [COLNAME12]   NVARCHAR (MAX)   NULL,
    [COLTYPE12]   INT              NULL,
    [COLACT12]    BIT              NULL,
    [COLFORM12]   NVARCHAR (MAX)   NULL,
    [COLNAME13]   NVARCHAR (MAX)   NULL,
    [COLTYPE13]   INT              NULL,
    [COLACT13]    BIT              NULL,
    [COLFORM13]   NVARCHAR (MAX)   NULL,
    [COLNAME14]   NVARCHAR (MAX)   NULL,
    [COLTYPE14]   INT              NULL,
    [COLACT14]    BIT              NULL,
    [COLFORM14]   NVARCHAR (MAX)   NULL,
    [COLDEFVAL0]  NUMERIC (30, 10) NULL,
    [COLDEFVAL1]  NUMERIC (30, 10) NULL,
    [COLDEFVAL2]  NUMERIC (30, 10) NULL,
    [COLDEFVAL3]  NUMERIC (30, 10) NULL,
    [COLDEFVAL4]  NUMERIC (30, 10) NULL,
    [COLDEFVAL5]  NUMERIC (30, 10) NULL,
    [COLDEFVAL6]  NUMERIC (30, 10) NULL,
    [COLDEFVAL7]  NUMERIC (30, 10) NULL,
    [COLDEFVAL8]  NUMERIC (30, 10) NULL,
    [COLDEFVAL9]  NUMERIC (30, 10) NULL,
    [COLDEFVAL10] NUMERIC (30, 10) NULL,
    [COLDEFVAL11] NUMERIC (30, 10) NULL,
    [COLDEFVAL12] NUMERIC (30, 10) NULL,
    [COLDEFVAL13] NUMERIC (30, 10) NULL,
    [COLDEFVAL14] NUMERIC (30, 10) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FKB7E836FC9A9C964D] FOREIGN KEY ([TEMPLATEID]) REFERENCES [dbo].[PROJECTTEMPLATE] ([ID])
);

