USE [master]
GO
/****** Object:  Database [Cars]    Script Date: 5/28/2023 5:48:44 PM ******/
CREATE DATABASE [Cars]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Cars', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Cars.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Cars_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Cars_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Cars] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Cars].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Cars] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Cars] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Cars] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Cars] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Cars] SET ARITHABORT OFF 
GO
ALTER DATABASE [Cars] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Cars] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Cars] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Cars] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Cars] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Cars] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Cars] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Cars] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Cars] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Cars] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Cars] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Cars] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Cars] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Cars] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Cars] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Cars] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Cars] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Cars] SET RECOVERY FULL 
GO
ALTER DATABASE [Cars] SET  MULTI_USER 
GO
ALTER DATABASE [Cars] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Cars] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Cars] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Cars] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Cars] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Cars] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Cars', N'ON'
GO
ALTER DATABASE [Cars] SET QUERY_STORE = ON
GO
ALTER DATABASE [Cars] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Cars]
GO
/****** Object:  Table [dbo].[Car]    Script Date: 5/28/2023 5:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Car](
	[RegNo] [int] NOT NULL,
	[Type] [varchar](50) NULL,
	[Model] [varchar](50) NULL,
	[Available] [varchar](50) NULL,
	[fee] [int] NULL,
 CONSTRAINT [PK_Car] PRIMARY KEY CLUSTERED 
(
	[RegNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 5/28/2023 5:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[cid] [int] NOT NULL,
	[cusname] [varchar](50) NULL,
	[address] [varchar](50) NULL,
	[mobile] [int] NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[cid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rental]    Script Date: 5/28/2023 5:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rental](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[car_id] [int] NULL,
	[cus_id] [int] NULL,
	[cusname] [varchar](50) NULL,
	[fee] [int] NULL,
	[date] [varchar](50) NULL,
	[duedate] [varchar](50) NULL,
 CONSTRAINT [PK_Rental] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReturnCAr]    Script Date: 5/28/2023 5:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReturnCAr](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[car_id] [int] NULL,
	[cus_id] [int] NULL,
	[date] [varchar](50) NULL,
	[elp] [varchar](50) NULL,
	[fine] [varchar](50) NULL,
 CONSTRAINT [PK_Return] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Cars] SET  READ_WRITE 
GO
