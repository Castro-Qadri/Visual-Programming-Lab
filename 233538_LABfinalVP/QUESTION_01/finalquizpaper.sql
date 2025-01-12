USE [master]
GO

/****** Object:  Database [quizfinal]    Script Date: 07/01/2025 3:55:15 pm ******/
CREATE DATABASE [quizfinal]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'quizfinal', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\quizfinal.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'quizfinal_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\quizfinal_log.ldf' , SIZE = 560KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [quizfinal] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [quizfinal].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [quizfinal] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [quizfinal] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [quizfinal] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [quizfinal] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [quizfinal] SET ARITHABORT OFF 
GO

ALTER DATABASE [quizfinal] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [quizfinal] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [quizfinal] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [quizfinal] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [quizfinal] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [quizfinal] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [quizfinal] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [quizfinal] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [quizfinal] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [quizfinal] SET  ENABLE_BROKER 
GO

ALTER DATABASE [quizfinal] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [quizfinal] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [quizfinal] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [quizfinal] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [quizfinal] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [quizfinal] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [quizfinal] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [quizfinal] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [quizfinal] SET  MULTI_USER 
GO

ALTER DATABASE [quizfinal] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [quizfinal] SET DB_CHAINING OFF 
GO

ALTER DATABASE [quizfinal] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [quizfinal] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [quizfinal] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [quizfinal] SET  READ_WRITE 
GO

