﻿CREATE TABLE [dbo].[BC_ELEMMATERIAL] (
    [ID]          BIGINT     IDENTITY (1, 1) NOT NULL,
    [THICKNESS]   FLOAT (53) NULL,
    [ELEMINFO_ID] BIGINT     NULL,
    [MATERIAL_ID] BIGINT     NULL,
    [MODEL_ID]    BIGINT     NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FKC1DD6CF43F9ED03F] FOREIGN KEY ([ELEMINFO_ID]) REFERENCES [dbo].[BC_ELEMENTINFO] ([ID]),
    CONSTRAINT [FKC1DD6CF44160E6D4] FOREIGN KEY ([MODEL_ID]) REFERENCES [dbo].[BC_MODEL] ([ID]),
    CONSTRAINT [FKC1DD6CF4BAA04896] FOREIGN KEY ([MATERIAL_ID]) REFERENCES [dbo].[BC_MATERIAL] ([ID])
);

