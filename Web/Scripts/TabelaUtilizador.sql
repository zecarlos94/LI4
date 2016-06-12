USE [Interrail]
GO

/****** Object:  Table [dbo].[Utilizador]    Script Date: 11/06/2016 12:29:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Utilizador](
	[Email] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[PrimeiroNome] [varchar](50) NOT NULL,
	[Apelido] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Utilizador] PRIMARY KEY CLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


