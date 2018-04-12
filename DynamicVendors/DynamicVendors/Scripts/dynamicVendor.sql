USE [master]
GO

/****** Object:  Database [dynamicVendor]    Script Date: 4/11/2018 10:04:10 PM ******/
CREATE DATABASE [dynamicVendor]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dynamicVender', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\dynamicVender.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dynamicVender_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\dynamicVender_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [dynamicVendor] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dynamicVendor].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [dynamicVendor] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [dynamicVendor] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [dynamicVendor] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [dynamicVendor] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [dynamicVendor] SET ARITHABORT OFF 
GO

ALTER DATABASE [dynamicVendor] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [dynamicVendor] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [dynamicVendor] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [dynamicVendor] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [dynamicVendor] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [dynamicVendor] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [dynamicVendor] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [dynamicVendor] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [dynamicVendor] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [dynamicVendor] SET  DISABLE_BROKER 
GO

ALTER DATABASE [dynamicVendor] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [dynamicVendor] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [dynamicVendor] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [dynamicVendor] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [dynamicVendor] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [dynamicVendor] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [dynamicVendor] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [dynamicVendor] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [dynamicVendor] SET  MULTI_USER 
GO

ALTER DATABASE [dynamicVendor] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [dynamicVendor] SET DB_CHAINING OFF 
GO

ALTER DATABASE [dynamicVendor] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [dynamicVendor] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [dynamicVendor] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [dynamicVendor] SET  READ_WRITE 
GO

