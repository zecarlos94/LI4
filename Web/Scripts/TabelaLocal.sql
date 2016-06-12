USE [Interrail]
GO

/****** Object:  Table [dbo].[Local]    Script Date: 11/06/2016 12:31:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Local](
	[Id] [int] NOT NULL,
	[Descricao] [text] NULL,
	[Coordenadas] [geography] NOT NULL,
	[Cidade] [varchar](50) NOT NULL,
	[Pais] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Local] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


