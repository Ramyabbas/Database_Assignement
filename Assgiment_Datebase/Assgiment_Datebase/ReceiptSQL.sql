USE [master]
GO
/****** Object:  Database [Receipt]    Script Date: 12/6/2020 11:19:36 AM ******/
CREATE DATABASE [Receipt]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Receipt', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Receipt.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Receipt_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Receipt_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Receipt] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Receipt].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Receipt] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Receipt] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Receipt] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Receipt] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Receipt] SET ARITHABORT OFF 
GO
ALTER DATABASE [Receipt] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Receipt] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Receipt] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Receipt] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Receipt] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Receipt] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Receipt] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Receipt] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Receipt] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Receipt] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Receipt] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Receipt] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Receipt] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Receipt] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Receipt] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Receipt] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Receipt] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Receipt] SET RECOVERY FULL 
GO
ALTER DATABASE [Receipt] SET  MULTI_USER 
GO
ALTER DATABASE [Receipt] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Receipt] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Receipt] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Receipt] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Receipt] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Receipt] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Receipt', N'ON'
GO
ALTER DATABASE [Receipt] SET QUERY_STORE = OFF
GO
USE [Receipt]
GO
/****** Object:  Table [dbo].[Categore]    Script Date: 12/6/2020 11:19:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categore](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Receipt]    Script Date: 12/6/2020 11:19:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receipt](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](100) NULL,
	[CategoryID] [int] NULL,
	[Ingredients] [nvarchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categore] ON 

INSERT [dbo].[Categore] ([Id], [Name]) VALUES (1, N'Svesnk husmanskost')
INSERT [dbo].[Categore] ([Id], [Name]) VALUES (2, N'Franskt')
INSERT [dbo].[Categore] ([Id], [Name]) VALUES (3, N'Italienskt')
INSERT [dbo].[Categore] ([Id], [Name]) VALUES (4, N'Kinesiskt')
INSERT [dbo].[Categore] ([Id], [Name]) VALUES (5, N'Irakiskt')
INSERT [dbo].[Categore] ([Id], [Name]) VALUES (6, N'Persiskt')
INSERT [dbo].[Categore] ([Id], [Name]) VALUES (7, N'Spanskt')
INSERT [dbo].[Categore] ([Id], [Name]) VALUES (8, N'Amrekaniskt')
SET IDENTITY_INSERT [dbo].[Categore] OFF
GO
SET IDENTITY_INSERT [dbo].[Receipt] ON 

INSERT [dbo].[Receipt] ([Id], [Title], [Description], [CategoryID], [Ingredients]) VALUES (1033, N'pizza', N'km', 3, N'ss')
INSERT [dbo].[Receipt] ([Id], [Title], [Description], [CategoryID], [Ingredients]) VALUES (1034, N'köttbullar', N'kl', 1, N'ee')
INSERT [dbo].[Receipt] ([Id], [Title], [Description], [CategoryID], [Ingredients]) VALUES (1036, N'Pacha', N'k', 5, N'MM')
INSERT [dbo].[Receipt] ([Id], [Title], [Description], [CategoryID], [Ingredients]) VALUES (1037, N'Kebab', N'kött', 5, N'Kött med bröd')
INSERT [dbo].[Receipt] ([Id], [Title], [Description], [CategoryID], [Ingredients]) VALUES (1038, N'Pacha', N'Fåhuvud', 5, N'Kött')
SET IDENTITY_INSERT [dbo].[Receipt] OFF
GO
ALTER TABLE [dbo].[Receipt]  WITH CHECK ADD FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categore] ([Id])
GO
USE [master]
GO
ALTER DATABASE [Receipt] SET  READ_WRITE 
GO
