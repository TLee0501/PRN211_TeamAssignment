USE [master]
GO
/****** Object:  Database [PRN211_IT_HR_Management_System]    Script Date: 22-Jul-23 3:36:27 PM ******/
CREATE DATABASE [PRN211_IT_HR_Management_System]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PRN211_IT_HR_Management_System', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\PRN211_IT_HR_Management_System.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PRN211_IT_HR_Management_System_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\PRN211_IT_HR_Management_System_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PRN211_IT_HR_Management_System].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET ARITHABORT OFF 
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET RECOVERY FULL 
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET  MULTI_USER 
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'PRN211_IT_HR_Management_System', N'ON'
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET QUERY_STORE = ON
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [PRN211_IT_HR_Management_System]
GO
/****** Object:  Table [dbo].[Attendance]    Script Date: 22-Jul-23 3:36:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attendance](
	[AttendanceID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NULL,
	[isAttend] [bit] NULL,
	[EmployeeID] [int] NULL,
 CONSTRAINT [PK_Attendance] PRIMARY KEY CLUSTERED 
(
	[AttendanceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Candidate]    Script Date: 22-Jul-23 3:36:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Candidate](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Description] [varchar](500) NULL,
 CONSTRAINT [PK_Candidate] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 22-Jul-23 3:36:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Name] [varchar](50) NULL,
	[RoleName] [varchar](50) NULL,
	[Status] [varchar](50) NULL,
	[PhoneNumber] [int] NULL,
	[Email] [varchar](max) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Overtime]    Script Date: 22-Jul-23 3:36:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Overtime](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NULL,
	[Time] [int] NULL,
	[EmployeeID] [int] NULL,
 CONSTRAINT [PK_Overtime_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payslip]    Script Date: 22-Jul-23 3:36:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payslip](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BasicSalary] [int] NULL,
	[Allowance] [int] NULL,
	[BonusOT] [int] NULL,
	[NetSalary] [int] NULL,
	[EmployeeID] [int] NULL,
	[Month] [int] NULL,
	[Year] [int] NULL,
 CONSTRAINT [PK_Payslip_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salary]    Script Date: 22-Jul-23 3:36:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salary](
	[ID] [int] NOT NULL,
	[Amount] [int] NULL,
	[EmployeeID] [int] NULL,
 CONSTRAINT [PK_Salary] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TakeLeave]    Script Date: 22-Jul-23 3:36:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TakeLeave](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NULL,
	[isAccept] [bit] NULL,
	[Description] [varchar](500) NULL,
 CONSTRAINT [PK_TakeLeave] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TakeLeaveCount]    Script Date: 22-Jul-23 3:36:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TakeLeaveCount](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Month] [int] NULL,
	[Year] [int] NULL,
	[Count] [int] NULL,
	[EmployeeID] [int] NULL,
 CONSTRAINT [PK_TakeLeaveCount] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Attendance]  WITH CHECK ADD  CONSTRAINT [FK_Attendance_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([ID])
GO
ALTER TABLE [dbo].[Attendance] CHECK CONSTRAINT [FK_Attendance_Employee]
GO
ALTER TABLE [dbo].[Overtime]  WITH CHECK ADD  CONSTRAINT [FK_Overtime_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([ID])
GO
ALTER TABLE [dbo].[Overtime] CHECK CONSTRAINT [FK_Overtime_Employee]
GO
ALTER TABLE [dbo].[Payslip]  WITH CHECK ADD  CONSTRAINT [FK_Payslip_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([ID])
GO
ALTER TABLE [dbo].[Payslip] CHECK CONSTRAINT [FK_Payslip_Employee]
GO
ALTER TABLE [dbo].[Salary]  WITH CHECK ADD  CONSTRAINT [FK_Salary_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([ID])
GO
ALTER TABLE [dbo].[Salary] CHECK CONSTRAINT [FK_Salary_Employee]
GO
ALTER TABLE [dbo].[TakeLeave]  WITH CHECK ADD  CONSTRAINT [FK_TakeLeave_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([ID])
GO
ALTER TABLE [dbo].[TakeLeave] CHECK CONSTRAINT [FK_TakeLeave_Employee]
GO
ALTER TABLE [dbo].[TakeLeaveCount]  WITH CHECK ADD  CONSTRAINT [FK_TakeLeaveCount_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([ID])
GO
ALTER TABLE [dbo].[TakeLeaveCount] CHECK CONSTRAINT [FK_TakeLeaveCount_Employee]
GO
USE [master]
GO
ALTER DATABASE [PRN211_IT_HR_Management_System] SET  READ_WRITE 
GO
