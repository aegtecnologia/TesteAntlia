USE [MovimentosManuais]
GO

/****** Object:  Table [dbo].[PRODUTO]    Script Date: 9/21/2019 11:00:54 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PRODUTO](
	[COD_PRODUTO] [char](4) NOT NULL,
	[DES_PRODUTO] [varchar](30) NULL,
	[STA_STATUS] [char](1) NULL,
 CONSTRAINT [PK_PRODUTO] PRIMARY KEY CLUSTERED 
(
	[COD_PRODUTO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


