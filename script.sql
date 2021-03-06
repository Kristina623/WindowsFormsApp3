USE [Вариант 1]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 07.02.2022 13:22:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[ID] [int] NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Водитель]    Script Date: 07.02.2022 13:22:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Водитель](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Middlename] [nvarchar](50) NOT NULL,
	[PassportSerial] [nvarchar](50) NOT NULL,
	[PassportNumber] [nvarchar](50) NOT NULL,
	[Postcode] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[AddressLife] [nvarchar](50) NOT NULL,
	[Company] [nvarchar](50) NULL,
	[Jobname] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Photo] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](50) NULL
) ON [PRIMARY]
GO
