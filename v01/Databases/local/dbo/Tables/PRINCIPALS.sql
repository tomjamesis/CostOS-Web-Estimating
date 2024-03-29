﻿CREATE TABLE [dbo].[PRINCIPALS] (
    [PRINCIPALID] VARCHAR (255) NOT NULL,
    [AUTHTYPE]    VARCHAR (255) NULL,
    [COLOR]       VARCHAR (255) NULL,
    [EMAIL]       VARCHAR (255) NULL,
    [ENBL]        BIT           NULL,
    [HASHKEY]     VARCHAR (255) NULL,
    [NAME]        VARCHAR (255) NULL,
    [PASSWORD]    VARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([PRINCIPALID] ASC)
);

