USE [master]
GO
/****** Object:  Database [TP06]    Script Date: 10/7/2025 15:56:29 ******/
CREATE DATABASE [TP06]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TP06', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\TP06.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TP06_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\TP06_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [TP06] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TP06].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TP06] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TP06] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TP06] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TP06] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TP06] SET ARITHABORT OFF 
GO
ALTER DATABASE [TP06] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TP06] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TP06] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TP06] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TP06] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TP06] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TP06] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TP06] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TP06] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TP06] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TP06] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TP06] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TP06] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TP06] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TP06] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TP06] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TP06] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TP06] SET RECOVERY FULL 
GO
ALTER DATABASE [TP06] SET  MULTI_USER 
GO
ALTER DATABASE [TP06] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TP06] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TP06] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TP06] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TP06] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TP06', N'ON'
GO
ALTER DATABASE [TP06] SET QUERY_STORE = OFF
GO
USE [TP06]
GO
/****** Object:  User [alumno]    Script Date: 10/7/2025 15:56:29 ******/
CREATE USER [alumno] FOR LOGIN [alumno] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[DatoFamiliar]    Script Date: 10/7/2025 15:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatoFamiliar](
	[Id] [int] NOT NULL,
	[IdUsuario] [int] NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Parentesco] [varchar](50) NULL,
	[Descripción] [varchar](50) NULL,
 CONSTRAINT [PK_DatoFamiliar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatoPersonal]    Script Date: 10/7/2025 15:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatoPersonal](
	[Id] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Contraseña] [varchar](50) NULL,
	[FechaNacimiento] [date] NULL,
	[Foto] [varchar](50) NULL,
 CONSTRAINT [PK_DatoPersonal_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatosInteres]    Script Date: 10/7/2025 15:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatosInteres](
	[id] [int] NOT NULL,
	[idusuario] [int] NULL,
	[TipoIntereses] [int] NULL,
	[Interes] [varchar](50) NULL,
 CONSTRAINT [PK_DatosInteres] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DatoFamiliar] ([Id], [IdUsuario], [Nombre], [Apellido], [Parentesco], [Descripción]) VALUES (20, 10, N'Esteban', N'Suti', N'Padre', N'Padre de Uriel, trabaja en logística')
INSERT [dbo].[DatoFamiliar] ([Id], [IdUsuario], [Nombre], [Apellido], [Parentesco], [Descripción]) VALUES (21, 10, N'Dana', N'Kohan', N'Madre', N'Madre de Uriel, abogada')
INSERT [dbo].[DatoFamiliar] ([Id], [IdUsuario], [Nombre], [Apellido], [Parentesco], [Descripción]) VALUES (22, 11, N'Hernán', N'Vitas', N'Padre', N'Padre de Alan, ingeniero electrónico')
INSERT [dbo].[DatoFamiliar] ([Id], [IdUsuario], [Nombre], [Apellido], [Parentesco], [Descripción]) VALUES (23, 11, N'Romina', N'Bursztyn', N'Madre', N'Madre de Alan, psicóloga')
INSERT [dbo].[DatoFamiliar] ([Id], [IdUsuario], [Nombre], [Apellido], [Parentesco], [Descripción]) VALUES (24, 12, N'Javi', N'Wagmaister', N'Padre', N'Padre de Santiago, arquitecto')
INSERT [dbo].[DatoFamiliar] ([Id], [IdUsuario], [Nombre], [Apellido], [Parentesco], [Descripción]) VALUES (25, 12, N'Laura', N'Kohen', N'Madre', N'Madre de Santiago, docente')
GO
INSERT [dbo].[DatoPersonal] ([Id], [Nombre], [Apellido], [Email], [Contraseña], [FechaNacimiento], [Foto]) VALUES (10, N'Uriel', N'Suti', N'uriel.suti@mail.com', N'uriel123', CAST(N'2002-05-15' AS Date), N'uriel.jpg')
INSERT [dbo].[DatoPersonal] ([Id], [Nombre], [Apellido], [Email], [Contraseña], [FechaNacimiento], [Foto]) VALUES (11, N'Alan', N'Vitas', N'alan.vitas@mail.com', N'alan123', CAST(N'2001-09-30' AS Date), N'alan.jpg')
INSERT [dbo].[DatoPersonal] ([Id], [Nombre], [Apellido], [Email], [Contraseña], [FechaNacimiento], [Foto]) VALUES (12, N'Santiago', N'Wagmaister', N'santiago.w@mail.com', N'santi123', CAST(N'2003-01-22' AS Date), N'santiago.jpg')
GO
INSERT [dbo].[DatosInteres] ([id], [idusuario], [TipoIntereses], [Interes]) VALUES (30, 10, 1, N'Fútbol')
INSERT [dbo].[DatosInteres] ([id], [idusuario], [TipoIntereses], [Interes]) VALUES (31, 10, 2, N'Tecnología')
INSERT [dbo].[DatosInteres] ([id], [idusuario], [TipoIntereses], [Interes]) VALUES (32, 11, 1, N'Programación')
INSERT [dbo].[DatosInteres] ([id], [idusuario], [TipoIntereses], [Interes]) VALUES (33, 11, 2, N'Cine')
INSERT [dbo].[DatosInteres] ([id], [idusuario], [TipoIntereses], [Interes]) VALUES (34, 12, 1, N'Música')
INSERT [dbo].[DatosInteres] ([id], [idusuario], [TipoIntereses], [Interes]) VALUES (35, 12, 3, N'Historia')
GO
ALTER TABLE [dbo].[DatoFamiliar]  WITH CHECK ADD  CONSTRAINT [FK_DatoFamiliar_DatoPersonal1] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[DatoPersonal] ([Id])
GO
ALTER TABLE [dbo].[DatoFamiliar] CHECK CONSTRAINT [FK_DatoFamiliar_DatoPersonal1]
GO
ALTER TABLE [dbo].[DatosInteres]  WITH CHECK ADD  CONSTRAINT [FK_DatosInteres_DatoPersonal1] FOREIGN KEY([idusuario])
REFERENCES [dbo].[DatoPersonal] ([Id])
GO
ALTER TABLE [dbo].[DatosInteres] CHECK CONSTRAINT [FK_DatosInteres_DatoPersonal1]
GO
USE [master]
GO
ALTER DATABASE [TP06] SET  READ_WRITE 
GO
