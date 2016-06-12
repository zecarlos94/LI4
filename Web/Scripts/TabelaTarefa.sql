USE [Interrail]
GO

/****** Object:  Table [dbo].[Tarefa]    Script Date: 11/06/2016 12:30:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tarefa](
	[Id] [int] NOT NULL,
	[Designacao] [text] NULL,
	[Data] [datetime] NOT NULL,
	[fk_Agenda] [int] NULL,
	[fk_Relatorio] [int] NULL,
	[fk_Local] [int] NOT NULL,
 CONSTRAINT [PK_Tarefa] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[Tarefa]  WITH CHECK ADD  CONSTRAINT [FK_Tarefa_Agenda] FOREIGN KEY([fk_Agenda])
REFERENCES [dbo].[Agenda] ([Id])
GO

ALTER TABLE [dbo].[Tarefa] CHECK CONSTRAINT [FK_Tarefa_Agenda]
GO

ALTER TABLE [dbo].[Tarefa]  WITH CHECK ADD  CONSTRAINT [FK_Tarefa_Local] FOREIGN KEY([fk_Local])
REFERENCES [dbo].[Local] ([Id])
GO

ALTER TABLE [dbo].[Tarefa] CHECK CONSTRAINT [FK_Tarefa_Local]
GO

ALTER TABLE [dbo].[Tarefa]  WITH CHECK ADD  CONSTRAINT [FK_Tarefa_Relatorio] FOREIGN KEY([fk_Relatorio])
REFERENCES [dbo].[Relatorio] ([Id])
GO

ALTER TABLE [dbo].[Tarefa] CHECK CONSTRAINT [FK_Tarefa_Relatorio]
GO


