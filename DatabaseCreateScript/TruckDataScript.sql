USE [master]
GO
/****** Object:  Database [TruckData]    Script Date: 30-01-2021 11:29:20 PM ******/
CREATE DATABASE [TruckData]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TruckData', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TruckData.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TruckData_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TruckData_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TruckData] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TruckData].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TruckData] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TruckData] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TruckData] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TruckData] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TruckData] SET ARITHABORT OFF 
GO
ALTER DATABASE [TruckData] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TruckData] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TruckData] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TruckData] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TruckData] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TruckData] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TruckData] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TruckData] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TruckData] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TruckData] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TruckData] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TruckData] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TruckData] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TruckData] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TruckData] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TruckData] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TruckData] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TruckData] SET RECOVERY FULL 
GO
ALTER DATABASE [TruckData] SET  MULTI_USER 
GO
ALTER DATABASE [TruckData] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TruckData] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TruckData] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TruckData] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TruckData] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TruckData] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TruckData', N'ON'
GO
ALTER DATABASE [TruckData] SET QUERY_STORE = OFF
GO
USE [TruckData]
GO
/****** Object:  Table [dbo].[Companies]    Script Date: 30-01-2021 11:29:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Companies](
	[company_id] [int] IDENTITY(1,1) NOT NULL,
	[company_name] [nvarchar](50) NOT NULL,
	[company_address] [nvarchar](50) NOT NULL,
	[company_headquaters_city] [nvarchar](50) NOT NULL,
	[company_owner] [nvarchar](50) NOT NULL,
	[company_taxIdNumber] [nvarchar](50) NOT NULL,
	[company_bank_account] [nvarchar](50) NOT NULL,
	[company_phone_number] [nvarchar](50) NOT NULL,
	[company_email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Companies] PRIMARY KEY CLUSTERED 
(
	[company_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Drivers]    Script Date: 30-01-2021 11:29:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drivers](
	[driver_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[surname] [nvarchar](50) NOT NULL,
	[living_address] [nvarchar](50) NULL,
	[living_place] [nvarchar](50) NULL,
	[id_cardnumber] [varchar](50) NOT NULL,
	[id_drivinglicense] [varchar](50) NOT NULL,
	[mobilephone] [varchar](50) NOT NULL,
	[dateofbirth] [date] NULL,
	[working_from_date] [date] NULL,
	[salary] [varchar](50) NULL,
 CONSTRAINT [PK_Drivers] PRIMARY KEY CLUSTERED 
(
	[driver_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoices]    Script Date: 30-01-2021 11:29:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoices](
	[invoice_id] [int] IDENTITY(1,1) NOT NULL,
	[company_name] [nvarchar](50) NOT NULL,
	[delivery_date] [date] NOT NULL,
	[mileage] [nvarchar](50) NOT NULL,
	[unloading_number] [nvarchar](50) NOT NULL,
	[base_value] [varchar](50) NOT NULL,
	[vat] [varchar](50) NOT NULL,
	[final_value] [varchar](50) NOT NULL,
	[truck_name] [nvarchar](50) NULL,
	[driver_name] [nvarchar](50) NULL,
	[invoice_number] [nvarchar](50) NOT NULL,
	[is_payed] [nvarchar](50) NOT NULL,
	[payment_type] [nvarchar](50) NOT NULL,
	[driver_id] [int] NOT NULL,
	[truck_id] [int] NOT NULL,
	[company_id] [int] NOT NULL,
 CONSTRAINT [PK_Invoices] PRIMARY KEY CLUSTERED 
(
	[invoice_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trucks]    Script Date: 30-01-2021 11:29:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trucks](
	[truck_id] [int] IDENTITY(1,1) NOT NULL,
	[truck_manufacturer] [nvarchar](50) NOT NULL,
	[truck_type] [nvarchar](50) NOT NULL,
	[special_truck_label] [nvarchar](50) NOT NULL,
	[license_plate] [nvarchar](50) NOT NULL,
	[buy_date] [date] NULL,
	[registration_date] [date] NOT NULL,
	[odometer_km] [nvarchar](50) NULL,
	[chassis_number] [nvarchar](50) NOT NULL,
	[load_capacity] [nvarchar](50) NOT NULL,
	[tyre_dymension] [nvarchar](50) NULL,
 CONSTRAINT [PK_Trucks] PRIMARY KEY CLUSTERED 
(
	[truck_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Invoices]  WITH CHECK ADD  CONSTRAINT [FK_Invoices_Companies] FOREIGN KEY([company_id])
REFERENCES [dbo].[Companies] ([company_id])
GO
ALTER TABLE [dbo].[Invoices] CHECK CONSTRAINT [FK_Invoices_Companies]
GO
ALTER TABLE [dbo].[Invoices]  WITH CHECK ADD  CONSTRAINT [FK_Invoices_Drivers] FOREIGN KEY([driver_id])
REFERENCES [dbo].[Drivers] ([driver_id])
GO
ALTER TABLE [dbo].[Invoices] CHECK CONSTRAINT [FK_Invoices_Drivers]
GO
ALTER TABLE [dbo].[Invoices]  WITH CHECK ADD  CONSTRAINT [FK_Invoices_Trucks] FOREIGN KEY([truck_id])
REFERENCES [dbo].[Trucks] ([truck_id])
GO
ALTER TABLE [dbo].[Invoices] CHECK CONSTRAINT [FK_Invoices_Trucks]
GO
USE [master]
GO
ALTER DATABASE [TruckData] SET  READ_WRITE 
GO
