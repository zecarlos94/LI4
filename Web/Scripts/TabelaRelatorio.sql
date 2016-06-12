USE [Interrail]
GO

/****** Object:  Table [dbo].[Relatorio]    Script Date: 11/06/2016 12:31:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Relatorio](
	[Id] [int] NOT NULL,
	[Data] [datetime] NOT NULL,
	[Titulo] [varchar](50) NOT NULL,
	[Tipo] [int] NOT NULL,
	[fk_Utilizador] [varchar](50) NULL,
 CONSTRAINT [PK_Relatorio] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Relatorio]  WITH CHECK ADD  CONSTRAINT [FK_Relatorio_Utilizador] FOREIGN KEY([fk_Utilizador])
REFERENCES [dbo].[Utilizador] ([Email])
GO

ALTER TABLE [dbo].[Relatorio] CHECK CONSTRAINT [FK_Relatorio_Utilizador]
GO


