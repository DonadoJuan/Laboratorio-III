USE [master]
GO

/****** Object:  Database [AlumnosCursos-2010]    Script Date: 11/12/2010 09:52:45 ******/
CREATE DATABASE [AlumnosCursos-2010] ON  PRIMARY 
( NAME = N'AlumnosCursos-2010', FILENAME = N'D:\AlumnosCursos-2010.mdf' , SIZE =  33000KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'AlumnosCursos-2010_log', FILENAME = N'D:\AlumnosCursos-2010_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [AlumnosCursos-2010] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AlumnosCursos-2010].[dbo].[sp_fulltext_database] @action = 'enable'
end 
GO

ALTER DATABASE [AlumnosCursos-2010] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [AlumnosCursos-2010] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [AlumnosCursos-2010] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [AlumnosCursos-2010] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [AlumnosCursos-2010] SET ARITHABORT OFF 
GO

ALTER DATABASE [AlumnosCursos-2010] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [AlumnosCursos-2010] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [AlumnosCursos-2010] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [AlumnosCursos-2010] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [AlumnosCursos-2010] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [AlumnosCursos-2010] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [AlumnosCursos-2010] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [AlumnosCursos-2010] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [AlumnosCursos-2010] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [AlumnosCursos-2010] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [AlumnosCursos-2010] SET  DISABLE_BROKER 
GO

ALTER DATABASE [AlumnosCursos-2010] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [AlumnosCursos-2010] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [AlumnosCursos-2010] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [AlumnosCursos-2010] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [AlumnosCursos-2010] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [AlumnosCursos-2010] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [AlumnosCursos-2010] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [AlumnosCursos-2010] SET  READ_WRITE 
GO

ALTER DATABASE [AlumnosCursos-2010] SET RECOVERY FULL 
GO

ALTER DATABASE [AlumnosCursos-2010] SET  MULTI_USER 
GO

ALTER DATABASE [AlumnosCursos-2010] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [AlumnosCursos-2010] SET DB_CHAINING OFF 
GO

USE [AlumnosCursos-2010]
GO

/****** Object:  Table [dbo].[Alumnos]    Script Date: 11/12/2010 09:53:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Alumnos](
	[Legajo_Alumno] [int] NOT NULL,
	[Apellido_Alumno] [varchar](50) NULL,
	[Curso_Alumno] [int] NULL,
 CONSTRAINT [PK_Alumnos] PRIMARY KEY CLUSTERED 
(
	[Legajo_Alumno] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


