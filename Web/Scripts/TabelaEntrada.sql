USE [Interrail]
GO

/****** Object:  Table [dbo].[Entrada]    Script Date: 11/06/2016 12:32:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Entrada](
	[Id] [int] NOT NULL,
	[Imagem] [image] NULL,
	[FicheiroAudio] [binary](1000) NULL,
	[FicheiroTexto] [binary](1000) NULL,
	[Nome] [varchar](50) NOT NULL,
	[Coordenadas] [geography] NOT NULL,
	[Data] [datetime] NOT NULL,
	[fk_Tarefa] [int] NOT NULL,
 CONSTRAINT [PK_Entrada] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Entrada]  WITH CHECK ADD  CONSTRAINT [FK_Entrada_Tarefa] FOREIGN KEY([fk_Tarefa])
REFERENCES [dbo].[Tarefa] ([Id])
GO

ALTER TABLE [dbo].[Entrada] CHECK CONSTRAINT [FK_Entrada_Tarefa]
GO


