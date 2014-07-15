USE [nerfgunAmJhmGvaF]
GO

/****** Object:  Table [dbo].[DataPoint]    Script Date: 7/15/2014 4:55:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[DataPoint](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [uniqueidentifier] NULL,
	[Created] [datetime] NOT NULL,
	[Lat] [float] NULL,
	[Lon] [float] NULL,
	[Party] [nvarchar](50) NULL,
	[Strength] [int] NULL,
	[Happy] [int] NULL,
	[Friendly] [int] NULL,
	[Talk] [int] NULL,
	[Political] [int] NULL,
	[Opinionated] [int] NULL,
	[Votes] [int] NULL,
	[Note] [nvarchar](max) NULL,
	[Voice] [varbinary](max) NULL,
 CONSTRAINT [PK_DataPoint] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO

SET ANSI_PADDING OFF
GO


