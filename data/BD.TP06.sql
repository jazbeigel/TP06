USE [master]
GO
/****** Object:  Database [JJOO TP6]    Script Date: 15/8/2024 16:02:40 ******/
CREATE DATABASE [JJOO TP6]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'JJOO TP6', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\JJOO TP6.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'JJOO TP6_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\JJOO TP6_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [JJOO TP6] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [JJOO TP6].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [JJOO TP6] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [JJOO TP6] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [JJOO TP6] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [JJOO TP6] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [JJOO TP6] SET ARITHABORT OFF 
GO
ALTER DATABASE [JJOO TP6] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [JJOO TP6] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [JJOO TP6] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [JJOO TP6] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [JJOO TP6] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [JJOO TP6] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [JJOO TP6] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [JJOO TP6] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [JJOO TP6] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [JJOO TP6] SET  DISABLE_BROKER 
GO
ALTER DATABASE [JJOO TP6] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [JJOO TP6] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [JJOO TP6] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [JJOO TP6] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [JJOO TP6] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [JJOO TP6] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [JJOO TP6] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [JJOO TP6] SET RECOVERY FULL 
GO
ALTER DATABASE [JJOO TP6] SET  MULTI_USER 
GO
ALTER DATABASE [JJOO TP6] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [JJOO TP6] SET DB_CHAINING OFF 
GO
ALTER DATABASE [JJOO TP6] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [JJOO TP6] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [JJOO TP6] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'JJOO TP6', N'ON'
GO
ALTER DATABASE [JJOO TP6] SET QUERY_STORE = OFF
GO
USE [JJOO TP6]
GO
/****** Object:  User [alumno]    Script Date: 15/8/2024 16:02:41 ******/
CREATE USER [alumno] FOR LOGIN [alumno] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Deportes]    Script Date: 15/8/2024 16:02:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deportes](
	[IdDeporte] [int] NOT NULL,
	[Nombre] [varchar](200) NOT NULL,
	[Foto] [varchar](500) NOT NULL,
 CONSTRAINT [PK_Deportes] PRIMARY KEY CLUSTERED 
(
	[IdDeporte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Deportistas]    Script Date: 15/8/2024 16:02:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deportistas](
	[IdDeportista] [int] NOT NULL,
	[Apellido] [varchar](200) NOT NULL,
	[Nombre] [varchar](200) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Foto] [varchar](500) NOT NULL,
	[IdPais] [int] NOT NULL,
	[IdDeporte] [int] NOT NULL,
 CONSTRAINT [PK_Deportistas] PRIMARY KEY CLUSTERED 
(
	[IdDeportista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paises]    Script Date: 15/8/2024 16:02:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paises](
	[IdPais] [int] NOT NULL,
	[Bandera] [text] NOT NULL,
	[FechaFundacion] [date] NOT NULL,
	[Nombre] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Paises] PRIMARY KEY CLUSTERED 
(
	[IdPais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Deportes] ([IdDeporte], [Nombre], [Foto]) VALUES (1, N'Gimnasia', N'https://static01.nyt.com/images/2024/07/28/multimedia/30gymnastics-team-pin-001-esp/28oly-gymnastics-carousel-02-ljwm-superJumbo.jpg?quality=75&auto=webp')
INSERT [dbo].[Deportes] ([IdDeporte], [Nombre], [Foto]) VALUES (2, N'BMX', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRVZDzGtftvMA-75KEFxJmRCC9vQHPzKP-Myw&s')
INSERT [dbo].[Deportes] ([IdDeporte], [Nombre], [Foto]) VALUES (3, N'Futbol', N'https://www.lanacion.com.ar/resizer/v2/espana-es-un-campeonazo-olimpico-por-buen-futbol-WAGOKM72TBB7NEBFGM6CFOZNJM.JPG?auth=61b164fd162ba1bb464cde24530aa08fdb8e9bb009a7f3044532e29c6c276013&width=420&height=280&quality=70&smart=true')
INSERT [dbo].[Deportes] ([IdDeporte], [Nombre], [Foto]) VALUES (4, N'Vela', N'https://img.olympics.com/images/image/private/t_s_16_9_g_auto/t_s_w960/f_auto/primary/wrl4hfw1iydtrxv0osfu')
GO
INSERT [dbo].[Deportistas] ([IdDeportista], [Apellido], [Nombre], [FechaNacimiento], [Foto], [IdPais], [IdDeporte]) VALUES (1, N'Biles', N'Simone', CAST(N'1997-05-14' AS Date), N'data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/4RsORXhpZgAASUkqAAgAAAALAA4BAgC2AAAA2gAAAA8BAgAGAAAAkAEAABABAgAPAAAAlgEAADsBAgAUAAAA6AEAAD4BBQACAAAA/AEAAD8BBQAGAAAADAIAABECBQADAAAAPAIAABMCAwABAAAAAgAAAJiCAgASAAAAVAIAAGmHBAABAAAAZgIAACWIBAABAAAACAUAABoFAAAGAAAADAIAABECBQADAAAAPAIAABMCAwABAAAAAgAAAJiCAgASAAAAVAIAAGmHBAABAAAAZgIAACWIBAABAAAACAUAABoFAABYWFhYIGNvbXBldGVzIGluIHRoZSBYWFhYWCBGaW5hbCBvbiBEYXkgU2V2ZW4gb2YgdGhlIEFydGlzdGljIEd5bW5hc3RpY3MgV29ybGQgQ2hhbXBpb25zaGlwcyBCZWxnaXVtIDIwMTMgaGVsZ', 2, 1)
INSERT [dbo].[Deportistas] ([IdDeportista], [Apellido], [Nombre], [FechaNacimiento], [Foto], [IdPais], [IdDeporte]) VALUES (2, N'Torres Gil', N'José', CAST(N'1995-03-28' AS Date), N'https://www.tiempoar.com.ar/wp-content/uploads/2024/07/web-foto-jose-maligno-torres-NA-2.jpg', 1, 2)
INSERT [dbo].[Deportistas] ([IdDeportista], [Apellido], [Nombre], [FechaNacimiento], [Foto], [IdPais], [IdDeporte]) VALUES (3, N'Millot', N'Enzo', CAST(N'2002-07-17' AS Date), N'https://tmssl.akamaized.net/images/foto/galerie/enzo-millot-vfb-stuttgart-1032881371hjpg-1708013018-129509.jpg?lm=1708013030', 4, 3)
INSERT [dbo].[Deportistas] ([IdDeportista], [Apellido], [Nombre], [FechaNacimiento], [Foto], [IdPais], [IdDeporte]) VALUES (4, N'Kunze ', N'Kahena ', CAST(N'1991-03-20' AS Date), N'https://d2a3o6pzho379u.cloudfront.net/129316.jpg', 3, 4)
GO
INSERT [dbo].[Paises] ([IdPais], [Bandera], [FechaFundacion], [Nombre]) VALUES (1, N'https://upload.wikimedia.org/wikipedia/commons/1/1a/Flag_of_Argentina.svg', CAST(N'1812-02-27' AS Date), N'Argentina')
INSERT [dbo].[Paises] ([IdPais], [Bandera], [FechaFundacion], [Nombre]) VALUES (2, N'https://upload.wikimedia.org/wikipedia/commons/thumb/a/a4/Flag_of_the_United_States.svg/800px-Flag_of_the_United_States.svg.png', CAST(N'1777-06-15' AS Date), N'Estados Unidos')
INSERT [dbo].[Paises] ([IdPais], [Bandera], [FechaFundacion], [Nombre]) VALUES (3, N'https://upload.wikimedia.org/wikipedia/commons/thumb/0/05/Flag_of_Brazil.svg/640px-Flag_of_Brazil.svg.png', CAST(N'1889-11-19' AS Date), N'Brasil')
INSERT [dbo].[Paises] ([IdPais], [Bandera], [FechaFundacion], [Nombre]) VALUES (4, N'https://upload.wikimedia.org/wikipedia/commons/thumb/9/93/Flag_of_France_%281794%E2%80%931815%2C_1830%E2%80%931974%29.svg/200px-Flag_of_France_%281794%E2%80%931815%2C_1830%E2%80%931974%29.svg.png', CAST(N'1794-02-15' AS Date), N'Francia')
GO
ALTER TABLE [dbo].[Deportistas]  WITH CHECK ADD  CONSTRAINT [FK_Deportistas_Deportes] FOREIGN KEY([IdDeporte])
REFERENCES [dbo].[Deportes] ([IdDeporte])
GO
ALTER TABLE [dbo].[Deportistas] CHECK CONSTRAINT [FK_Deportistas_Deportes]
GO
ALTER TABLE [dbo].[Deportistas]  WITH CHECK ADD  CONSTRAINT [FK_Deportistas_Paises] FOREIGN KEY([IdPais])
REFERENCES [dbo].[Paises] ([IdPais])
GO
ALTER TABLE [dbo].[Deportistas] CHECK CONSTRAINT [FK_Deportistas_Paises]
GO
USE [master]
GO
ALTER DATABASE [JJOO TP6] SET  READ_WRITE 
GO
