USE [master]
GO
/****** Object:  Database [SocialMedia]    Script Date: 16.03.2023 13:30:31 ******/
CREATE DATABASE [SocialMedia]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SocialMedia', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SocialMedia.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SocialMedia_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SocialMedia_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SocialMedia] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SocialMedia].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SocialMedia] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SocialMedia] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SocialMedia] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SocialMedia] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SocialMedia] SET ARITHABORT OFF 
GO
ALTER DATABASE [SocialMedia] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SocialMedia] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SocialMedia] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SocialMedia] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SocialMedia] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SocialMedia] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SocialMedia] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SocialMedia] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SocialMedia] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SocialMedia] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SocialMedia] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SocialMedia] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SocialMedia] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SocialMedia] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SocialMedia] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SocialMedia] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SocialMedia] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SocialMedia] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SocialMedia] SET  MULTI_USER 
GO
ALTER DATABASE [SocialMedia] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SocialMedia] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SocialMedia] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SocialMedia] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SocialMedia] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SocialMedia] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SocialMedia] SET QUERY_STORE = OFF
GO
USE [SocialMedia]
GO
/****** Object:  User [sa]    Script Date: 16.03.2023 13:30:32 ******/
CREATE USER [sa] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[AccountsTable]    Script Date: 16.03.2023 13:30:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountsTable](
	[UserID] [smallint] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Name] [varchar](50) NULL,
	[Surname] [varchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Followers] [varchar](100) NULL,
	[Followed] [varchar](100) NULL,
	[UploadedCount] [smallint] NULL,
	[UploadedPhoto] [image] NULL,
	[Bio] [varchar](100) NULL,
	[imgFileName] [varchar](150) NULL,
	[PrivateSetting] [bit] NULL,
 CONSTRAINT [PK_AccountsTable] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FollowedTable]    Script Date: 16.03.2023 13:30:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FollowedTable](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NULL,
	[WhoTheyFollowed] [varchar](50) NULL,
 CONSTRAINT [PK_FollowedTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FollowersTable]    Script Date: 16.03.2023 13:30:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FollowersTable](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NULL,
	[WhoFollowesThem] [varchar](50) NULL,
 CONSTRAINT [PK_FollowersTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NotificationsTable]    Script Date: 16.03.2023 13:30:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NotificationsTable](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[MessageSender] [varchar](50) NULL,
	[MessageReciever] [varchar](50) NULL,
	[Notification] [varchar](150) NULL,
	[Answer] [bit] NULL,
 CONSTRAINT [PK_Notification] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pics1Table]    Script Date: 16.03.2023 13:30:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pics1Table](
	[PicId] [smallint] IDENTITY(1,1) NOT NULL,
	[Pics] [image] NULL,
 CONSTRAINT [PK_pics1Table] PRIMARY KEY CLUSTERED 
(
	[PicId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[picTable2]    Script Date: 16.03.2023 13:30:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[picTable2](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[picFile] [varchar](100) NULL,
	[pics] [image] NULL,
 CONSTRAINT [PK_picTable2] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PostTable]    Script Date: 16.03.2023 13:30:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostTable](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[UserId] [smallint] NULL,
	[FilePath] [varchar](100) NULL,
	[Picture] [image] NULL,
	[Username] [varchar](50) NULL,
	[postDate] [smalldatetime] NULL,
 CONSTRAINT [PK_PostTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AccountsTable] ON 

INSERT [dbo].[AccountsTable] ([UserID], [Username], [Password], [Name], [Surname], [Email], [Followers], [Followed], [UploadedCount], [UploadedPhoto], [Bio], [imgFileName], [PrivateSetting]) VALUES (1, N'nazsph', N'123', N'Ayşe Naz', N'Sipahi', N'a.nazsipahi@gmail.com', N'10', N'11', 12, NULL, N'Rise and Shine', N'D:\ayşe\2021- 29.07.2022\camera\IMG_20211231_135540.jpg', NULL)
INSERT [dbo].[AccountsTable] ([UserID], [Username], [Password], [Name], [Surname], [Email], [Followers], [Followed], [UploadedCount], [UploadedPhoto], [Bio], [imgFileName], [PrivateSetting]) VALUES (2, N'bgmeda', N'123', N'Begüm Eda', N'Kaplan', N'bgmeda@gmail.com', N'21', N'22', 23, NULL, N'Aesthatic', N'D:\ayşe\2021- 29.07.2022\camera\IMG_20211104_212544.jpg', NULL)
INSERT [dbo].[AccountsTable] ([UserID], [Username], [Password], [Name], [Surname], [Email], [Followers], [Followed], [UploadedCount], [UploadedPhoto], [Bio], [imgFileName], [PrivateSetting]) VALUES (3, N'zrana', N'123', N'Zeynep Rana', N'Tonkaz', N'zrana@gmail.com', N'30', N'31', 32, NULL, N'Seyahatname', N'D:\ayşe\2021- 29.07.2022\camera\IMG_20220513_183050.jpg', NULL)
INSERT [dbo].[AccountsTable] ([UserID], [Username], [Password], [Name], [Surname], [Email], [Followers], [Followed], [UploadedCount], [UploadedPhoto], [Bio], [imgFileName], [PrivateSetting]) VALUES (4, N'Şewal', N'123', N'Şevval', N'Kibar', N'sewal@gmail.com', N'40', N'41', 42, NULL, N'Aşko', N'D:\ayşe\2021- 29.07.2022\camera\IMG_20220528_131105.jpg', NULL)
INSERT [dbo].[AccountsTable] ([UserID], [Username], [Password], [Name], [Surname], [Email], [Followers], [Followed], [UploadedCount], [UploadedPhoto], [Bio], [imgFileName], [PrivateSetting]) VALUES (7, N'sph', N'123', N'ayşenaz', N'sph', N'aysenaz.sipahi22@gmail.com', NULL, NULL, NULL, NULL, NULL, N'D:\ayşe\2021- 29.07.2022\wp\IMG-20220513-WA0004.jpg', 1)
INSERT [dbo].[AccountsTable] ([UserID], [Username], [Password], [Name], [Surname], [Email], [Followers], [Followed], [UploadedCount], [UploadedPhoto], [Bio], [imgFileName], [PrivateSetting]) VALUES (8, N'aa', N'2', N'aa', N'aa', N'a@gmail.com', N'0', N'0', NULL, NULL, N'Fıstıkk', N'D:\ayşe\2021- 29.07.2022\wp\IMG-20220529-WA0030.jpg', 0)
INSERT [dbo].[AccountsTable] ([UserID], [Username], [Password], [Name], [Surname], [Email], [Followers], [Followed], [UploadedCount], [UploadedPhoto], [Bio], [imgFileName], [PrivateSetting]) VALUES (116, N'aa2', N'1', N'aa2', N'aa2', N'abc@hotmail.com', N'0', N'0', NULL, NULL, NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[AccountsTable] OFF
GO
SET IDENTITY_INSERT [dbo].[FollowedTable] ON 

INSERT [dbo].[FollowedTable] ([Id], [Username], [WhoTheyFollowed]) VALUES (234, N'aa2', N'aa')
INSERT [dbo].[FollowedTable] ([Id], [Username], [WhoTheyFollowed]) VALUES (313, N'bgmeda', N'zrana')
INSERT [dbo].[FollowedTable] ([Id], [Username], [WhoTheyFollowed]) VALUES (314, N'sph', N'nazsph')
INSERT [dbo].[FollowedTable] ([Id], [Username], [WhoTheyFollowed]) VALUES (315, N'nazsph', N'sph')
SET IDENTITY_INSERT [dbo].[FollowedTable] OFF
GO
SET IDENTITY_INSERT [dbo].[FollowersTable] ON 

INSERT [dbo].[FollowersTable] ([Id], [Username], [WhoFollowesThem]) VALUES (242, N'aa', N'aa2')
INSERT [dbo].[FollowersTable] ([Id], [Username], [WhoFollowesThem]) VALUES (321, N'zrana', N'bgmeda')
INSERT [dbo].[FollowersTable] ([Id], [Username], [WhoFollowesThem]) VALUES (322, N'nazsph', N'sph')
INSERT [dbo].[FollowersTable] ([Id], [Username], [WhoFollowesThem]) VALUES (323, N'sph', N'nazsph')
SET IDENTITY_INSERT [dbo].[FollowersTable] OFF
GO
SET IDENTITY_INSERT [dbo].[NotificationsTable] ON 

INSERT [dbo].[NotificationsTable] ([Id], [MessageSender], [MessageReciever], [Notification], [Answer]) VALUES (259, N'nazsph', N'bgmeda', NULL, 0)
INSERT [dbo].[NotificationsTable] ([Id], [MessageSender], [MessageReciever], [Notification], [Answer]) VALUES (266, N'aa', N'aa2', NULL, 0)
INSERT [dbo].[NotificationsTable] ([Id], [MessageSender], [MessageReciever], [Notification], [Answer]) VALUES (446, N'aa2', N'bgmeda', NULL, 0)
INSERT [dbo].[NotificationsTable] ([Id], [MessageSender], [MessageReciever], [Notification], [Answer]) VALUES (449, N'aa', N'bgmeda', NULL, 0)
SET IDENTITY_INSERT [dbo].[NotificationsTable] OFF
GO
SET IDENTITY_INSERT [dbo].[PostTable] ON 

INSERT [dbo].[PostTable] ([Id], [UserId], [FilePath], [Picture], [Username], [postDate]) VALUES (270, NULL, N'D:\ayşe\2021- 29.07.2022\wp\IMG-20211029-WA0013.jpg', NULL, N'sph', CAST(N'2023-05-02T17:06:00' AS SmallDateTime))
INSERT [dbo].[PostTable] ([Id], [UserId], [FilePath], [Picture], [Username], [postDate]) VALUES (271, NULL, N'D:\ayşe\2021- 29.07.2022\wp\IMG-20211029-WA0012.jpg', NULL, N'sph', CAST(N'2023-05-02T17:06:00' AS SmallDateTime))
INSERT [dbo].[PostTable] ([Id], [UserId], [FilePath], [Picture], [Username], [postDate]) VALUES (272, NULL, N'D:\ayşe\2021- 29.07.2022\wp\IMG-20220122-WA0001.jpg', NULL, N'zrana', CAST(N'2023-05-02T17:12:00' AS SmallDateTime))
INSERT [dbo].[PostTable] ([Id], [UserId], [FilePath], [Picture], [Username], [postDate]) VALUES (372, NULL, N'D:\ayşe\2021- 29.07.2022\wp\IMG-20220402-WA0119.jpg', NULL, N'zrana', CAST(N'2023-02-19T19:20:00' AS SmallDateTime))
INSERT [dbo].[PostTable] ([Id], [UserId], [FilePath], [Picture], [Username], [postDate]) VALUES (373, NULL, N'D:\ayşe\2021- 29.07.2022\wp\IMG-20220327-WA0005.jpg', NULL, N'nazsph', CAST(N'2023-02-19T19:30:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[PostTable] OFF
GO
ALTER TABLE [dbo].[AccountsTable] ADD  CONSTRAINT [DF_AccountsTable_Followers]  DEFAULT ((0)) FOR [Followers]
GO
ALTER TABLE [dbo].[AccountsTable] ADD  CONSTRAINT [DF_AccountsTable_Followed]  DEFAULT ((0)) FOR [Followed]
GO
ALTER TABLE [dbo].[AccountsTable] ADD  DEFAULT ((0)) FOR [PrivateSetting]
GO
ALTER TABLE [dbo].[NotificationsTable] ADD  DEFAULT ((0)) FOR [Answer]
GO
USE [master]
GO
ALTER DATABASE [SocialMedia] SET  READ_WRITE 
GO
