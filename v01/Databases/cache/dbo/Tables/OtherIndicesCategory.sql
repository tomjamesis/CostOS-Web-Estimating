﻿CREATE TABLE [dbo].[OtherIndicesCategory]
(
	[OtherIndiceCategoryId]		SMALLINT		NOT NULL,
	[Name]						NVARCHAR(MAX)	NOT NULL,
	[CreatedDate]				DATE			NOT NULL,
	
	CONSTRAINT [PK_OtherIndiceCatergory] PRIMARY KEY CLUSTERED ([OtherIndiceCategoryId] ASC)
)
