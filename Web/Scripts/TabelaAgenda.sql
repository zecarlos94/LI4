USE [Interrail]
GO

/****** Object:  Table [dbo].[Agenda]    Script Date: 11/06/2016 12:33:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Agenda](
	[Id] [int] NOT NULL,
	[Imagem] [image] NOT NULL,
	[Data] [datetime] NOT NULL,
	[fk_Utilizador] [varchar](50) NULL,
 CONSTRAINT [PK_Agenda] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Agenda]  WITH CHECK ADD  CONSTRAINT [FK_Agenda_Utilizador] FOREIGN KEY([fk_Utilizador])
REFERENCES [dbo].[Utilizador] ([Email])
GO

ALTER TABLE [dbo].[Agenda] CHECK CONSTRAINT [FK_Agenda_Utilizador]
GO


