USE [SimpraHafta2OdevDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 17.05.2023 16:12:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staffs]    Script Date: 17.05.2023 16:12:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staffs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedBy] [nvarchar](max) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](max) NOT NULL,
	[DateOfBirth] [datetime2](7) NOT NULL,
	[AddressLine1] [nvarchar](max) NOT NULL,
	[City] [nvarchar](max) NOT NULL,
	[Country] [nvarchar](max) NOT NULL,
	[Province] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Staffs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230516123643_mig_1', N'7.0.5')
GO
SET IDENTITY_INSERT [dbo].[Staffs] ON 

INSERT [dbo].[Staffs] ([Id], [CreatedBy], [CreatedAt], [FirstName], [LastName], [Email], [Phone], [DateOfBirth], [AddressLine1], [City], [Country], [Province]) VALUES (6, N'Hüdanur', CAST(N'2023-05-17T11:10:49.5143870' AS DateTime2), N'Hüdanur', N'Engin', N'hudanur.engin@gmail.com', N'5512606150', CAST(N'2000-06-16T11:08:37.5500000' AS DateTime2), N'Ev', N'Çanakkale', N'Türkiye', N'Merkez')
INSERT [dbo].[Staffs] ([Id], [CreatedBy], [CreatedAt], [FirstName], [LastName], [Email], [Phone], [DateOfBirth], [AddressLine1], [City], [Country], [Province]) VALUES (7, N'Özlem', CAST(N'2023-05-17T11:12:11.6169393' AS DateTime2), N'Özlem', N'Engin', N'ozlem@gmail.com', N'5512606150', CAST(N'1973-07-26T12:56:01.1350000' AS DateTime2), N'Ev', N'İstanbul', N'Türkiye', N'Bahçelievler')
INSERT [dbo].[Staffs] ([Id], [CreatedBy], [CreatedAt], [FirstName], [LastName], [Email], [Phone], [DateOfBirth], [AddressLine1], [City], [Country], [Province]) VALUES (8, N'Ayşe', CAST(N'2023-05-17T11:14:05.7839302' AS DateTime2), N'Ayşe', N'Öncüler', N'ayse@gmail.com', N'5512606150', CAST(N'2002-06-04T12:56:01.1350000' AS DateTime2), N'Ev', N'Çanakkale', N'Türkiye', N'Merkez')
INSERT [dbo].[Staffs] ([Id], [CreatedBy], [CreatedAt], [FirstName], [LastName], [Email], [Phone], [DateOfBirth], [AddressLine1], [City], [Country], [Province]) VALUES (9, N'Eftelya', CAST(N'2023-05-17T11:14:26.9440180' AS DateTime2), N'Eftelya', N'Özbiçerler', N'eftelya@gmail.com', N'5512606150', CAST(N'2002-03-17T12:56:01.1350000' AS DateTime2), N'Ev', N'Çanakkale', N'Türkiye', N'Merkez')
INSERT [dbo].[Staffs] ([Id], [CreatedBy], [CreatedAt], [FirstName], [LastName], [Email], [Phone], [DateOfBirth], [AddressLine1], [City], [Country], [Province]) VALUES (10, N'Ayşe', CAST(N'2023-05-17T11:14:27.9743998' AS DateTime2), N'Ayşe', N'Özbiçerler', N'ayseöz@gmail.com', N'5512606150', CAST(N'2002-04-25T12:56:01.1350000' AS DateTime2), N'Ev', N'Çanakkale', N'Türkiye', N'Merkez')
INSERT [dbo].[Staffs] ([Id], [CreatedBy], [CreatedAt], [FirstName], [LastName], [Email], [Phone], [DateOfBirth], [AddressLine1], [City], [Country], [Province]) VALUES (11, N'Yaşar', CAST(N'2023-05-17T11:14:34.4673834' AS DateTime2), N'Yaşar', N'Engin', N'yasare@gmail.com', N'5512606150', CAST(N'1994-07-28T12:56:01.1350000' AS DateTime2), N'Ev', N'Bahçelievler', N'Türkiye', N'Bahçelievler')
INSERT [dbo].[Staffs] ([Id], [CreatedBy], [CreatedAt], [FirstName], [LastName], [Email], [Phone], [DateOfBirth], [AddressLine1], [City], [Country], [Province]) VALUES (12, N'Cengiz', CAST(N'2023-05-17T11:16:31.2350726' AS DateTime2), N'Cengiz', N'Engin', N'cengize@gmail.com', N'5512606150', CAST(N'1967-03-15T12:56:01.1350000' AS DateTime2), N'Ev', N'Bahçelievler', N'Türkiye', N'Bahçelievler')
SET IDENTITY_INSERT [dbo].[Staffs] OFF
GO
