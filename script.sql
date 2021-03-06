USE [master]
GO
/****** Object:  Database [CarpetCleaning]    Script Date: 8/14/2019 1:55:28 PM ******/
CREATE DATABASE [CarpetCleaning]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CarpetCleaning', FILENAME = N'C:\Users\asadnezhad\CarpetCleaning.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CarpetCleaning_log', FILENAME = N'C:\Users\asadnezhad\CarpetCleaning_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CarpetCleaning] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CarpetCleaning].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CarpetCleaning] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CarpetCleaning] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CarpetCleaning] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CarpetCleaning] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CarpetCleaning] SET ARITHABORT OFF 
GO
ALTER DATABASE [CarpetCleaning] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CarpetCleaning] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CarpetCleaning] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CarpetCleaning] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CarpetCleaning] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CarpetCleaning] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CarpetCleaning] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CarpetCleaning] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CarpetCleaning] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CarpetCleaning] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CarpetCleaning] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CarpetCleaning] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CarpetCleaning] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CarpetCleaning] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CarpetCleaning] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CarpetCleaning] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CarpetCleaning] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CarpetCleaning] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CarpetCleaning] SET  MULTI_USER 
GO
ALTER DATABASE [CarpetCleaning] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CarpetCleaning] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CarpetCleaning] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CarpetCleaning] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CarpetCleaning] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CarpetCleaning] SET QUERY_STORE = OFF
GO
USE [CarpetCleaning]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [CarpetCleaning]
GO
/****** Object:  Table [dbo].[tblCarpetPrice]    Script Date: 8/14/2019 1:55:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCarpetPrice](
	[CarpetPriceID] [int] NOT NULL,
	[Year] [int] NOT NULL,
	[Shur] [decimal](18, 0) NOT NULL,
	[Darkesh] [decimal](18, 0) NOT NULL,
	[Gayegh] [decimal](18, 0) NOT NULL,
	[Shiraze] [decimal](18, 0) NOT NULL,
	[Charm] [decimal](18, 0) NOT NULL,
	[Hasiri] [decimal](18, 0) NOT NULL,
	[Geytani] [decimal](18, 0) NOT NULL,
	[Pardakht] [decimal](18, 0) NOT NULL,
	[Description] [ntext] NOT NULL,
	[RegisterDate] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_tblCarpetPrice] PRIMARY KEY CLUSTERED 
(
	[CarpetPriceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCarpets]    Script Date: 8/14/2019 1:55:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCarpets](
	[CarpetID] [int] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Width] [float] NOT NULL,
	[Hight] [float] NOT NULL,
	[Area] [float] NOT NULL,
	[Shur] [float] NOT NULL,
	[Darkesh] [float] NOT NULL,
	[Gayegh] [float] NOT NULL,
	[Shiraze] [float] NOT NULL,
	[Charm] [float] NOT NULL,
	[Hasiri] [float] NOT NULL,
	[Geytani] [float] NOT NULL,
	[Pardakht] [float] NOT NULL,
	[Description] [ntext] NOT NULL,
	[RegisterDate] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_tblCarpets] PRIMARY KEY CLUSTERED 
(
	[CarpetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChecks]    Script Date: 8/14/2019 1:55:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChecks](
	[CheckID] [decimal](18, 0) NOT NULL,
	[CheckTypeID] [smallint] NOT NULL,
	[CheckSerial] [nvarchar](50) NOT NULL,
	[CheckDate] [nvarchar](10) NOT NULL,
	[CheckDueDate] [nvarchar](10) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[BankName] [nvarchar](50) NOT NULL,
	[Reminder] [bit] NOT NULL,
	[ReminderDay] [int] NOT NULL,
	[ReminderDate] [nvarchar](10) NOT NULL,
	[Description] [ntext] NOT NULL,
	[RegisterDate] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_tblCheck] PRIMARY KEY CLUSTERED 
(
	[CheckID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCustomerBuy]    Script Date: 8/14/2019 1:55:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCustomerBuy](
	[CustomerBuyID] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[Description] [ntext] NOT NULL,
	[RegisterDate] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_tblCostumerBuy] PRIMARY KEY CLUSTERED 
(
	[CustomerBuyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCustomerBuyList]    Script Date: 8/14/2019 1:55:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCustomerBuyList](
	[CustomerBuyListID] [decimal](18, 0) NOT NULL,
	[CustomerBuyID] [int] NOT NULL,
	[CarpetID] [int] NOT NULL,
	[Count] [int] NOT NULL,
	[Shur] [float] NOT NULL,
	[Darkesh] [float] NOT NULL,
	[Gayegh] [float] NOT NULL,
	[Shiraze] [float] NOT NULL,
	[Charm] [float] NOT NULL,
	[Hasiri] [float] NOT NULL,
	[Geytani] [float] NOT NULL,
	[Pardakht] [float] NOT NULL,
	[ShurPrice] [decimal](18, 0) NOT NULL,
	[DarkeshPrice] [decimal](18, 0) NOT NULL,
	[GayeghPrice] [decimal](18, 0) NOT NULL,
	[ShirazePrice] [decimal](18, 0) NOT NULL,
	[CharmPrice] [decimal](18, 0) NOT NULL,
	[HasiriPrice] [decimal](18, 0) NOT NULL,
	[GeytaniPrice] [decimal](18, 0) NOT NULL,
	[PardakhtPrice] [decimal](18, 0) NOT NULL,
	[SumPrice] [decimal](18, 0) NOT NULL,
	[Discount] [decimal](18, 0) NOT NULL,
	[FactorStatus] [smallint] NOT NULL,
	[FactorDate] [nvarchar](10) NOT NULL,
	[Description] [ntext] NOT NULL,
	[RegisterDate] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_tblCostumerBuyList] PRIMARY KEY CLUSTERED 
(
	[CustomerBuyListID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCustomers]    Script Date: 8/14/2019 1:55:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCustomers](
	[CustomerID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](100) NOT NULL,
	[CustomerTypeID] [smallint] NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](250) NOT NULL,
	[Tell] [nvarchar](13) NOT NULL,
	[Mobile] [nvarchar](13) NOT NULL,
	[Description] [ntext] NOT NULL,
	[Active] [smallint] NOT NULL,
	[RegisterDate] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_tblCustomer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDocuments]    Script Date: 8/14/2019 1:55:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDocuments](
	[DocumentID] [decimal](18, 0) NOT NULL,
	[DocumetnTypeID] [smallint] NOT NULL,
	[DocumentDate] [nvarchar](10) NOT NULL,
	[Title] [nvarchar](100) NOT NULL,
	[PriceTypeID] [smallint] NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[Discount] [decimal](18, 0) NOT NULL,
	[CheckID] [decimal](18, 0) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[Description] [ntext] NOT NULL,
	[RegisterDate] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_tblDocuments] PRIMARY KEY CLUSTERED 
(
	[DocumentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblFactors]    Script Date: 8/14/2019 1:55:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblFactors](
	[FactorID] [decimal](18, 0) NOT NULL,
	[FactorTypeID] [smallint] NOT NULL,
	[FactorDate] [nvarchar](10) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[CustomerName] [nvarchar](50) NOT NULL,
	[CustomerMobile] [nvarchar](11) NOT NULL,
	[Description] [ntext] NOT NULL,
	[RegisterDate] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_tblFactor] PRIMARY KEY CLUSTERED 
(
	[FactorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblFactorsList]    Script Date: 8/14/2019 1:55:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblFactorsList](
	[FactorListID] [decimal](18, 0) NOT NULL,
	[FactorID] [decimal](18, 0) NOT NULL,
	[CustomerBuyListID] [decimal](18, 0) NOT NULL,
	[CarpetID] [int] NOT NULL,
	[Count] [int] NOT NULL,
	[Shur] [float] NOT NULL,
	[Darkesh] [float] NOT NULL,
	[Gayegh] [float] NOT NULL,
	[Shiraze] [float] NOT NULL,
	[Charm] [float] NOT NULL,
	[Hasiri] [float] NOT NULL,
	[Geytani] [float] NOT NULL,
	[Pardakht] [float] NOT NULL,
	[ShurPrice] [decimal](18, 0) NOT NULL,
	[DarkeshPrice] [decimal](18, 0) NOT NULL,
	[GayeghPrice] [decimal](18, 0) NOT NULL,
	[ShirazePrice] [decimal](18, 0) NOT NULL,
	[CharmPrice] [decimal](18, 0) NOT NULL,
	[HasiriPrice] [decimal](18, 0) NOT NULL,
	[GeytaniPrice] [decimal](18, 0) NOT NULL,
	[PardakhtPrice] [decimal](18, 0) NOT NULL,
	[SumPrice] [decimal](18, 0) NOT NULL,
	[Discount] [decimal](18, 0) NOT NULL,
	[Description] [ntext] NOT NULL,
	[RegisterDate] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_tblFactorList] PRIMARY KEY CLUSTERED 
(
	[FactorListID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLog]    Script Date: 8/14/2019 1:55:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLog](
	[LogID] [decimal](18, 0) NOT NULL,
	[LogTypeID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[LogContent] [ntext] NOT NULL,
	[TableName] [nvarchar](50) NOT NULL,
	[TableKeyID] [decimal](18, 0) NOT NULL,
	[LogDate] [nvarchar](10) NOT NULL,
	[LogTime] [nvarchar](8) NOT NULL,
 CONSTRAINT [PK_tblLog] PRIMARY KEY CLUSTERED 
(
	[LogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLogType]    Script Date: 8/14/2019 1:55:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLogType](
	[LogTypeID] [int] NOT NULL,
	[LogTypeName] [nvarchar](100) NOT NULL,
	[RegTypeID] [smallint] NOT NULL,
 CONSTRAINT [PK_tblLogType] PRIMARY KEY CLUSTERED 
(
	[LogTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNotes]    Script Date: 8/14/2019 1:55:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNotes](
	[NoteID] [decimal](18, 0) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Note] [ntext] NOT NULL,
	[StartDate] [nvarchar](10) NOT NULL,
	[EndDate] [nvarchar](10) NOT NULL,
	[Description] [ntext] NOT NULL,
	[RegisterDate] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_tblNote] PRIMARY KEY CLUSTERED 
(
	[NoteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPersonnelFunction]    Script Date: 8/14/2019 1:55:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPersonnelFunction](
	[PersonnelFunctionID] [decimal](18, 0) NOT NULL,
	[PersonnelID] [int] NOT NULL,
	[Year] [int] NOT NULL,
	[Month] [int] NOT NULL,
	[CarpetID] [int] NOT NULL,
	[Meters] [float] NOT NULL,
	[Count] [float] NOT NULL,
	[WorkDay] [float] NOT NULL,
	[Description] [ntext] NOT NULL,
	[Active] [smallint] NOT NULL,
	[RegisterDate] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_tblPersonnelFunction] PRIMARY KEY CLUSTERED 
(
	[PersonnelFunctionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPersonnels]    Script Date: 8/14/2019 1:55:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPersonnels](
	[PersonnelID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](100) NOT NULL,
	[Image] [nvarchar](200) NOT NULL,
	[NationCode] [nvarchar](10) NOT NULL,
	[Id] [nvarchar](10) NOT NULL,
	[SexType] [bit] NOT NULL,
	[MaritalStatus] [smallint] NOT NULL,
	[FatherName] [nvarchar](50) NOT NULL,
	[BithayDay] [nvarchar](10) NOT NULL,
	[CityOfBirth] [nvarchar](50) NOT NULL,
	[CityOfLife] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](250) NOT NULL,
	[Mobile] [nvarchar](13) NOT NULL,
	[Description] [ntext] NOT NULL,
	[Active] [smallint] NOT NULL,
	[RegisterDate] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_tblPersonel] PRIMARY KEY CLUSTERED 
(
	[PersonnelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUsers]    Script Date: 8/14/2019 1:55:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUsers](
	[UserID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](100) NOT NULL,
	[Image] [nvarchar](200) NOT NULL,
	[UserName] [nvarchar](10) NOT NULL,
	[PassWord] [nvarchar](100) NOT NULL,
	[Mobile] [nvarchar](13) NOT NULL,
	[BackGroundImage] [nvarchar](200) NOT NULL,
	[Description] [ntext] NOT NULL,
	[Active] [smallint] NOT NULL,
	[RegisterDate] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_tblUsers] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblCarpetPrice] ADD  CONSTRAINT [DF_tblCarpetPrice_Shur]  DEFAULT ((0)) FOR [Shur]
GO
ALTER TABLE [dbo].[tblCarpetPrice] ADD  CONSTRAINT [DF_tblCarpetPrice_Darkesh]  DEFAULT ((0)) FOR [Darkesh]
GO
ALTER TABLE [dbo].[tblCarpetPrice] ADD  CONSTRAINT [DF_tblCarpetPrice_Gayegh]  DEFAULT ((0)) FOR [Gayegh]
GO
ALTER TABLE [dbo].[tblCarpetPrice] ADD  CONSTRAINT [DF_tblCarpetPrice_Shiraze]  DEFAULT ((0)) FOR [Shiraze]
GO
ALTER TABLE [dbo].[tblCarpetPrice] ADD  CONSTRAINT [DF_tblCarpetPrice_Charm]  DEFAULT ((0)) FOR [Charm]
GO
ALTER TABLE [dbo].[tblCarpetPrice] ADD  CONSTRAINT [DF_tblCarpetPrice_Hasiri]  DEFAULT ((0)) FOR [Hasiri]
GO
ALTER TABLE [dbo].[tblCarpetPrice] ADD  CONSTRAINT [DF_tblCarpetPrice_Geytani]  DEFAULT ((0)) FOR [Geytani]
GO
ALTER TABLE [dbo].[tblCarpetPrice] ADD  CONSTRAINT [DF_tblCarpetPrice_Pardakht]  DEFAULT ((0)) FOR [Pardakht]
GO
ALTER TABLE [dbo].[tblCarpetPrice] ADD  CONSTRAINT [DF_tblCarpetPrice_Description]  DEFAULT ('') FOR [Description]
GO
ALTER TABLE [dbo].[tblCarpets] ADD  CONSTRAINT [DF_tblCarpets_Title]  DEFAULT ('') FOR [Title]
GO
ALTER TABLE [dbo].[tblCarpets] ADD  CONSTRAINT [DF_tblCarpets_Width]  DEFAULT ((0)) FOR [Width]
GO
ALTER TABLE [dbo].[tblCarpets] ADD  CONSTRAINT [DF_tblCarpets_Hight]  DEFAULT ((0)) FOR [Hight]
GO
ALTER TABLE [dbo].[tblCarpets] ADD  CONSTRAINT [DF_tblCarpets_Area]  DEFAULT ((0)) FOR [Area]
GO
ALTER TABLE [dbo].[tblCarpets] ADD  CONSTRAINT [DF_tblCarpets_Shur]  DEFAULT ((0)) FOR [Shur]
GO
ALTER TABLE [dbo].[tblCarpets] ADD  CONSTRAINT [DF_tblCarpets_Darkesh]  DEFAULT ((0)) FOR [Darkesh]
GO
ALTER TABLE [dbo].[tblCarpets] ADD  CONSTRAINT [DF_tblCarpets_Gayegh]  DEFAULT ((0)) FOR [Gayegh]
GO
ALTER TABLE [dbo].[tblCarpets] ADD  CONSTRAINT [DF_tblCarpets_Shiraze]  DEFAULT ((0)) FOR [Shiraze]
GO
ALTER TABLE [dbo].[tblCarpets] ADD  CONSTRAINT [DF_tblCarpets_Charm]  DEFAULT ((0)) FOR [Charm]
GO
ALTER TABLE [dbo].[tblCarpets] ADD  CONSTRAINT [DF_tblCarpets_Hasiri]  DEFAULT ((0)) FOR [Hasiri]
GO
ALTER TABLE [dbo].[tblCarpets] ADD  CONSTRAINT [DF_tblCarpets_Geytani]  DEFAULT ((0)) FOR [Geytani]
GO
ALTER TABLE [dbo].[tblCarpets] ADD  CONSTRAINT [DF_tblCarpets_Pardakht]  DEFAULT ((0)) FOR [Pardakht]
GO
ALTER TABLE [dbo].[tblCarpets] ADD  CONSTRAINT [DF_tblCarpets_Description]  DEFAULT ('') FOR [Description]
GO
ALTER TABLE [dbo].[tblChecks] ADD  CONSTRAINT [DF_tblChecks_CheckType]  DEFAULT ((0)) FOR [CheckTypeID]
GO
ALTER TABLE [dbo].[tblChecks] ADD  CONSTRAINT [DF_tblCheck_CheckSerial]  DEFAULT ('') FOR [CheckSerial]
GO
ALTER TABLE [dbo].[tblChecks] ADD  CONSTRAINT [DF_tblCheck_CheckDate]  DEFAULT ('') FOR [CheckDate]
GO
ALTER TABLE [dbo].[tblChecks] ADD  CONSTRAINT [DF_tblChecks_CheckDate1]  DEFAULT ('') FOR [CheckDueDate]
GO
ALTER TABLE [dbo].[tblChecks] ADD  CONSTRAINT [DF_tblChecks_CustomerID]  DEFAULT ((0)) FOR [CustomerID]
GO
ALTER TABLE [dbo].[tblChecks] ADD  CONSTRAINT [DF_tblChecks_Price]  DEFAULT ((0)) FOR [Price]
GO
ALTER TABLE [dbo].[tblChecks] ADD  CONSTRAINT [DF_tblChecks_BankName]  DEFAULT ((0)) FOR [BankName]
GO
ALTER TABLE [dbo].[tblChecks] ADD  CONSTRAINT [DF_tblChecks_Reminder]  DEFAULT ((0)) FOR [Reminder]
GO
ALTER TABLE [dbo].[tblChecks] ADD  CONSTRAINT [DF_tblChecks_ReminderDay]  DEFAULT ((0)) FOR [ReminderDay]
GO
ALTER TABLE [dbo].[tblChecks] ADD  CONSTRAINT [DF_tblChecks_ReminderDay1]  DEFAULT ('') FOR [ReminderDate]
GO
ALTER TABLE [dbo].[tblChecks] ADD  CONSTRAINT [DF_tblChecks_Description]  DEFAULT ('') FOR [Description]
GO
ALTER TABLE [dbo].[tblChecks] ADD  CONSTRAINT [DF_tblChecks_RegisterDate]  DEFAULT ('') FOR [RegisterDate]
GO
ALTER TABLE [dbo].[tblCustomerBuy] ADD  CONSTRAINT [DF_tblCostumerBuy_CustomerID]  DEFAULT ((0)) FOR [CustomerID]
GO
ALTER TABLE [dbo].[tblCustomerBuy] ADD  CONSTRAINT [DF_tblCostumerBuy_Description]  DEFAULT ('') FOR [Description]
GO
ALTER TABLE [dbo].[tblCustomerBuy] ADD  CONSTRAINT [DF_tblCostumerBuy_RegisterDate]  DEFAULT ('') FOR [RegisterDate]
GO
ALTER TABLE [dbo].[tblCustomerBuyList] ADD  CONSTRAINT [DF_tblCostumerBuyList_CostumerBuyListID]  DEFAULT ((0)) FOR [CustomerBuyListID]
GO
ALTER TABLE [dbo].[tblCustomerBuyList] ADD  CONSTRAINT [DF_tblCostumerBuyList_FactorDate]  DEFAULT ('') FOR [CustomerBuyID]
GO
ALTER TABLE [dbo].[tblCustomerBuyList] ADD  CONSTRAINT [DF_tblCostumerBuyList_CarpetID]  DEFAULT ((0)) FOR [CarpetID]
GO
ALTER TABLE [dbo].[tblCustomerBuyList] ADD  CONSTRAINT [DF_tblCostumerBuyList_Count]  DEFAULT ((0)) FOR [Count]
GO
ALTER TABLE [dbo].[tblCustomerBuyList] ADD  CONSTRAINT [DF_tblCustomerBuyList_Shur]  DEFAULT ((0)) FOR [Shur]
GO
ALTER TABLE [dbo].[tblCustomerBuyList] ADD  CONSTRAINT [DF_tblCustomerBuyList_Darkesh]  DEFAULT ((0)) FOR [Darkesh]
GO
ALTER TABLE [dbo].[tblCustomerBuyList] ADD  CONSTRAINT [DF_tblCustomerBuyList_Gayegh]  DEFAULT ((0)) FOR [Gayegh]
GO
ALTER TABLE [dbo].[tblCustomerBuyList] ADD  CONSTRAINT [DF_tblCustomerBuyList_Shiraze]  DEFAULT ((0)) FOR [Shiraze]
GO
ALTER TABLE [dbo].[tblCustomerBuyList] ADD  CONSTRAINT [DF_tblCustomerBuyList_Charm]  DEFAULT ((0)) FOR [Charm]
GO
ALTER TABLE [dbo].[tblCustomerBuyList] ADD  CONSTRAINT [DF_tblCustomerBuyList_Hasiri]  DEFAULT ((0)) FOR [Hasiri]
GO
ALTER TABLE [dbo].[tblCustomerBuyList] ADD  CONSTRAINT [DF_tblCustomerBuyList_Geytani]  DEFAULT ((0)) FOR [Geytani]
GO
ALTER TABLE [dbo].[tblCustomerBuyList] ADD  CONSTRAINT [DF_tblCustomerBuyList_Pardakht]  DEFAULT ((0)) FOR [Pardakht]
GO
ALTER TABLE [dbo].[tblCustomerBuyList] ADD  CONSTRAINT [DF_tblCostumerBuyList_Shur]  DEFAULT ((0)) FOR [ShurPrice]
GO
ALTER TABLE [dbo].[tblCustomerBuyList] ADD  CONSTRAINT [DF_tblCostumerBuyList_Darkesh]  DEFAULT ((0)) FOR [DarkeshPrice]
GO
ALTER TABLE [dbo].[tblCustomerBuyList] ADD  CONSTRAINT [DF_tblCostumerBuyList_Gayegh]  DEFAULT ((0)) FOR [GayeghPrice]
GO
ALTER TABLE [dbo].[tblCustomerBuyList] ADD  CONSTRAINT [DF_tblCostumerBuyList_Shiraze]  DEFAULT ((0)) FOR [ShirazePrice]
GO
ALTER TABLE [dbo].[tblCustomerBuyList] ADD  CONSTRAINT [DF_tblCostumerBuyList_Charm]  DEFAULT ((0)) FOR [CharmPrice]
GO
ALTER TABLE [dbo].[tblCustomerBuyList] ADD  CONSTRAINT [DF_tblCostumerBuyList_Hasiri]  DEFAULT ((0)) FOR [HasiriPrice]
GO
ALTER TABLE [dbo].[tblCustomerBuyList] ADD  CONSTRAINT [DF_tblCostumerBuyList_Geytani]  DEFAULT ((0)) FOR [GeytaniPrice]
GO
ALTER TABLE [dbo].[tblCustomerBuyList] ADD  CONSTRAINT [DF_tblCostumerBuyList_Pardakht]  DEFAULT ((0)) FOR [PardakhtPrice]
GO
ALTER TABLE [dbo].[tblCustomerBuyList] ADD  CONSTRAINT [DF_tblCostumerBuyList_SumPrice]  DEFAULT ((0)) FOR [SumPrice]
GO
ALTER TABLE [dbo].[tblCustomerBuyList] ADD  CONSTRAINT [DF_tblCostumerBuyList_Discount]  DEFAULT ((0)) FOR [Discount]
GO
ALTER TABLE [dbo].[tblCustomerBuyList] ADD  CONSTRAINT [DF_tblCostumerBuyList_FactorStatus]  DEFAULT ((0)) FOR [FactorStatus]
GO
ALTER TABLE [dbo].[tblCustomerBuyList] ADD  CONSTRAINT [DF_tblCustomerBuyList_FactorDate]  DEFAULT ('') FOR [FactorDate]
GO
ALTER TABLE [dbo].[tblCustomerBuyList] ADD  CONSTRAINT [DF_tblCostumerBuyList_Description]  DEFAULT ('') FOR [Description]
GO
ALTER TABLE [dbo].[tblCustomerBuyList] ADD  CONSTRAINT [DF_tblCostumerBuyList_RegisterDate]  DEFAULT ('') FOR [RegisterDate]
GO
ALTER TABLE [dbo].[tblCustomers] ADD  CONSTRAINT [DF_tblCustomers_CustomerID]  DEFAULT ((0)) FOR [CustomerID]
GO
ALTER TABLE [dbo].[tblCustomers] ADD  CONSTRAINT [DF_tblCustomers_Name]  DEFAULT ('') FOR [Name]
GO
ALTER TABLE [dbo].[tblCustomers] ADD  CONSTRAINT [DF_tblCustomers_LastName]  DEFAULT ('') FOR [LastName]
GO
ALTER TABLE [dbo].[tblCustomers] ADD  CONSTRAINT [DF_tblCustomers_CustomerTypeID]  DEFAULT ((0)) FOR [CustomerTypeID]
GO
ALTER TABLE [dbo].[tblCustomers] ADD  CONSTRAINT [DF_tblCustomers_City]  DEFAULT ('') FOR [City]
GO
ALTER TABLE [dbo].[tblCustomers] ADD  CONSTRAINT [DF_tblCustomers_Address]  DEFAULT ('') FOR [Address]
GO
ALTER TABLE [dbo].[tblCustomers] ADD  CONSTRAINT [DF_tblCustomers_Tell]  DEFAULT ('') FOR [Tell]
GO
ALTER TABLE [dbo].[tblCustomers] ADD  CONSTRAINT [DF_tblCustomers_Mobile]  DEFAULT ('') FOR [Mobile]
GO
ALTER TABLE [dbo].[tblCustomers] ADD  CONSTRAINT [DF_tblCustomers_Description]  DEFAULT ('') FOR [Description]
GO
ALTER TABLE [dbo].[tblCustomers] ADD  CONSTRAINT [DF_tblCustomers_Active]  DEFAULT ((0)) FOR [Active]
GO
ALTER TABLE [dbo].[tblCustomers] ADD  CONSTRAINT [DF_tblCustomers_RegisterDate]  DEFAULT ('') FOR [RegisterDate]
GO
ALTER TABLE [dbo].[tblDocuments] ADD  CONSTRAINT [DF_tblDocuments_DocumentID]  DEFAULT ((0)) FOR [DocumentID]
GO
ALTER TABLE [dbo].[tblDocuments] ADD  CONSTRAINT [DF_tblDocuments_DocumetnTypeID]  DEFAULT ((0)) FOR [DocumetnTypeID]
GO
ALTER TABLE [dbo].[tblDocuments] ADD  CONSTRAINT [DF_tblDocuments_DocumentDate]  DEFAULT ('') FOR [DocumentDate]
GO
ALTER TABLE [dbo].[tblDocuments] ADD  CONSTRAINT [DF_tblDocuments_Title]  DEFAULT ('') FOR [Title]
GO
ALTER TABLE [dbo].[tblDocuments] ADD  CONSTRAINT [DF_tblDocuments_PriceTypeID]  DEFAULT ((0)) FOR [PriceTypeID]
GO
ALTER TABLE [dbo].[tblDocuments] ADD  CONSTRAINT [DF_tblDocuments_Price]  DEFAULT ((0)) FOR [Price]
GO
ALTER TABLE [dbo].[tblDocuments] ADD  CONSTRAINT [DF_tblDocuments_Price1]  DEFAULT ((0)) FOR [Discount]
GO
ALTER TABLE [dbo].[tblDocuments] ADD  CONSTRAINT [DF_tblDocuments_CheckID]  DEFAULT ((0)) FOR [CheckID]
GO
ALTER TABLE [dbo].[tblDocuments] ADD  CONSTRAINT [DF_tblDocuments_CustomerID]  DEFAULT ((0)) FOR [CustomerID]
GO
ALTER TABLE [dbo].[tblDocuments] ADD  CONSTRAINT [DF_tblDocuments_Description]  DEFAULT ('') FOR [Description]
GO
ALTER TABLE [dbo].[tblDocuments] ADD  CONSTRAINT [DF_tblDocuments_RegisterDate]  DEFAULT ('') FOR [RegisterDate]
GO
ALTER TABLE [dbo].[tblFactors] ADD  CONSTRAINT [DF_tblFactors_FactorID]  DEFAULT ((0)) FOR [FactorID]
GO
ALTER TABLE [dbo].[tblFactors] ADD  CONSTRAINT [DF_tblFactors_FactorTypeID]  DEFAULT ((0)) FOR [FactorTypeID]
GO
ALTER TABLE [dbo].[tblFactors] ADD  CONSTRAINT [DF_tblFactors_FactorDate]  DEFAULT ('') FOR [FactorDate]
GO
ALTER TABLE [dbo].[tblFactors] ADD  CONSTRAINT [DF_tblFactor_CustomerID]  DEFAULT ((0)) FOR [CustomerID]
GO
ALTER TABLE [dbo].[tblFactors] ADD  CONSTRAINT [DF_tblFactors_CustomerName]  DEFAULT ('') FOR [CustomerName]
GO
ALTER TABLE [dbo].[tblFactors] ADD  CONSTRAINT [DF_tblFactors_CustomerMobile]  DEFAULT ('') FOR [CustomerMobile]
GO
ALTER TABLE [dbo].[tblFactors] ADD  CONSTRAINT [DF_tblFactors_Description]  DEFAULT ('') FOR [Description]
GO
ALTER TABLE [dbo].[tblFactors] ADD  CONSTRAINT [DF_tblFactors_RegisterDate]  DEFAULT ('') FOR [RegisterDate]
GO
ALTER TABLE [dbo].[tblFactorsList] ADD  CONSTRAINT [DF_tblFactorsList_FactorListID]  DEFAULT ((0)) FOR [FactorListID]
GO
ALTER TABLE [dbo].[tblFactorsList] ADD  CONSTRAINT [DF_tblFactorsList_FactorID]  DEFAULT ((0)) FOR [FactorID]
GO
ALTER TABLE [dbo].[tblFactorsList] ADD  CONSTRAINT [DF_tblFactorsList_CostumerBuyListID]  DEFAULT ((0)) FOR [CustomerBuyListID]
GO
ALTER TABLE [dbo].[tblFactorsList] ADD  CONSTRAINT [DF_tblFactorsList_CarpetID]  DEFAULT ((0)) FOR [CarpetID]
GO
ALTER TABLE [dbo].[tblFactorsList] ADD  CONSTRAINT [DF_tblFactorsList_Count]  DEFAULT ((0)) FOR [Count]
GO
ALTER TABLE [dbo].[tblFactorsList] ADD  CONSTRAINT [DF_tblFactorsList_Shur_1]  DEFAULT ((0)) FOR [Shur]
GO
ALTER TABLE [dbo].[tblFactorsList] ADD  CONSTRAINT [DF_tblFactorsList_Darkesh_1]  DEFAULT ((0)) FOR [Darkesh]
GO
ALTER TABLE [dbo].[tblFactorsList] ADD  CONSTRAINT [DF_tblFactorsList_Gayegh_1]  DEFAULT ((0)) FOR [Gayegh]
GO
ALTER TABLE [dbo].[tblFactorsList] ADD  CONSTRAINT [DF_tblFactorsList_Shiraze_1]  DEFAULT ((0)) FOR [Shiraze]
GO
ALTER TABLE [dbo].[tblFactorsList] ADD  CONSTRAINT [DF_tblFactorsList_Charm_1]  DEFAULT ((0)) FOR [Charm]
GO
ALTER TABLE [dbo].[tblFactorsList] ADD  CONSTRAINT [DF_tblFactorsList_Hasiri_1]  DEFAULT ((0)) FOR [Hasiri]
GO
ALTER TABLE [dbo].[tblFactorsList] ADD  CONSTRAINT [DF_tblFactorsList_Geytani_1]  DEFAULT ((0)) FOR [Geytani]
GO
ALTER TABLE [dbo].[tblFactorsList] ADD  CONSTRAINT [DF_tblFactorsList_Pardakht_1]  DEFAULT ((0)) FOR [Pardakht]
GO
ALTER TABLE [dbo].[tblFactorsList] ADD  CONSTRAINT [DF_tblFactorsList_Shur]  DEFAULT ((0)) FOR [ShurPrice]
GO
ALTER TABLE [dbo].[tblFactorsList] ADD  CONSTRAINT [DF_tblFactorsList_Darkesh]  DEFAULT ((0)) FOR [DarkeshPrice]
GO
ALTER TABLE [dbo].[tblFactorsList] ADD  CONSTRAINT [DF_tblFactorsList_Gayegh]  DEFAULT ((0)) FOR [GayeghPrice]
GO
ALTER TABLE [dbo].[tblFactorsList] ADD  CONSTRAINT [DF_tblFactorsList_Shiraze]  DEFAULT ((0)) FOR [ShirazePrice]
GO
ALTER TABLE [dbo].[tblFactorsList] ADD  CONSTRAINT [DF_tblFactorsList_Charm]  DEFAULT ((0)) FOR [CharmPrice]
GO
ALTER TABLE [dbo].[tblFactorsList] ADD  CONSTRAINT [DF_tblFactorsList_Hasiri]  DEFAULT ((0)) FOR [HasiriPrice]
GO
ALTER TABLE [dbo].[tblFactorsList] ADD  CONSTRAINT [DF_tblFactorsList_Geytani]  DEFAULT ((0)) FOR [GeytaniPrice]
GO
ALTER TABLE [dbo].[tblFactorsList] ADD  CONSTRAINT [DF_tblFactorsList_Pardakht]  DEFAULT ((0)) FOR [PardakhtPrice]
GO
ALTER TABLE [dbo].[tblFactorsList] ADD  CONSTRAINT [DF_tblFactorsList_SumPrice]  DEFAULT ((0)) FOR [SumPrice]
GO
ALTER TABLE [dbo].[tblFactorsList] ADD  CONSTRAINT [DF_tblFactorsList_Discount]  DEFAULT ((0)) FOR [Discount]
GO
ALTER TABLE [dbo].[tblFactorsList] ADD  CONSTRAINT [DF_tblFactorsList_Description]  DEFAULT ('') FOR [Description]
GO
ALTER TABLE [dbo].[tblFactorsList] ADD  CONSTRAINT [DF_tblFactorsList_RegisterDate]  DEFAULT ('') FOR [RegisterDate]
GO
ALTER TABLE [dbo].[tblLog] ADD  CONSTRAINT [DF_tblLog_LogID]  DEFAULT ((0)) FOR [LogID]
GO
ALTER TABLE [dbo].[tblLog] ADD  CONSTRAINT [DF_tblLog_LogTypeID]  DEFAULT ((0)) FOR [LogTypeID]
GO
ALTER TABLE [dbo].[tblLog] ADD  CONSTRAINT [DF_tblLog_UserID]  DEFAULT ((0)) FOR [UserID]
GO
ALTER TABLE [dbo].[tblLog] ADD  CONSTRAINT [DF_tblLog_LogContent]  DEFAULT ('') FOR [LogContent]
GO
ALTER TABLE [dbo].[tblLog] ADD  CONSTRAINT [DF_tblLog_TableName]  DEFAULT ('') FOR [TableName]
GO
ALTER TABLE [dbo].[tblLog] ADD  CONSTRAINT [DF_tblLog_TableKeyID]  DEFAULT ((0)) FOR [TableKeyID]
GO
ALTER TABLE [dbo].[tblLog] ADD  CONSTRAINT [DF_tblLog_LogDate]  DEFAULT ('') FOR [LogDate]
GO
ALTER TABLE [dbo].[tblLog] ADD  CONSTRAINT [DF_tblLog_LogTime]  DEFAULT ('') FOR [LogTime]
GO
ALTER TABLE [dbo].[tblLogType] ADD  CONSTRAINT [DF_tblLogType_LogTypeID]  DEFAULT ((0)) FOR [LogTypeID]
GO
ALTER TABLE [dbo].[tblLogType] ADD  CONSTRAINT [DF_tblLogType_LogTypeName]  DEFAULT ('') FOR [LogTypeName]
GO
ALTER TABLE [dbo].[tblLogType] ADD  CONSTRAINT [DF_tblLogType_RegTypeID]  DEFAULT ((0)) FOR [RegTypeID]
GO
ALTER TABLE [dbo].[tblNotes] ADD  CONSTRAINT [DF_tblNotes_NoteID]  DEFAULT ((0)) FOR [NoteID]
GO
ALTER TABLE [dbo].[tblNotes] ADD  CONSTRAINT [DF_tblNotes_Title]  DEFAULT ('') FOR [Title]
GO
ALTER TABLE [dbo].[tblNotes] ADD  CONSTRAINT [DF_tblNotes_Note]  DEFAULT ('') FOR [Note]
GO
ALTER TABLE [dbo].[tblNotes] ADD  CONSTRAINT [DF_tblNotes_StartDate]  DEFAULT ('') FOR [StartDate]
GO
ALTER TABLE [dbo].[tblNotes] ADD  CONSTRAINT [DF_tblNotes_EndDate]  DEFAULT ('') FOR [EndDate]
GO
ALTER TABLE [dbo].[tblNotes] ADD  CONSTRAINT [DF_tblNotes_Description]  DEFAULT ('') FOR [Description]
GO
ALTER TABLE [dbo].[tblNotes] ADD  CONSTRAINT [DF_tblNotes_RegisterDate]  DEFAULT ('') FOR [RegisterDate]
GO
ALTER TABLE [dbo].[tblPersonnelFunction] ADD  CONSTRAINT [DF_tblPersonnelFunction_PersonnelFunctionID]  DEFAULT ((0)) FOR [PersonnelFunctionID]
GO
ALTER TABLE [dbo].[tblPersonnelFunction] ADD  CONSTRAINT [DF_tblPersonnelFunction_PersonnelID]  DEFAULT ((0)) FOR [PersonnelID]
GO
ALTER TABLE [dbo].[tblPersonnelFunction] ADD  CONSTRAINT [DF_tblPersonnelFunction_Year]  DEFAULT ((0)) FOR [Year]
GO
ALTER TABLE [dbo].[tblPersonnelFunction] ADD  CONSTRAINT [DF_tblPersonnelFunction_Month]  DEFAULT ((0)) FOR [Month]
GO
ALTER TABLE [dbo].[tblPersonnelFunction] ADD  CONSTRAINT [DF_tblPersonnelFunction_CarpetID]  DEFAULT ((0)) FOR [CarpetID]
GO
ALTER TABLE [dbo].[tblPersonnelFunction] ADD  CONSTRAINT [DF_tblPersonnelFunction_Meters]  DEFAULT ((0)) FOR [Meters]
GO
ALTER TABLE [dbo].[tblPersonnelFunction] ADD  CONSTRAINT [DF_tblPersonnelFunction_Count]  DEFAULT ((0)) FOR [Count]
GO
ALTER TABLE [dbo].[tblPersonnelFunction] ADD  CONSTRAINT [DF_tblPersonnelFunction_WorkDay]  DEFAULT ((0)) FOR [WorkDay]
GO
ALTER TABLE [dbo].[tblPersonnelFunction] ADD  CONSTRAINT [DF_tblPersonnelFunction_Description]  DEFAULT ('') FOR [Description]
GO
ALTER TABLE [dbo].[tblPersonnelFunction] ADD  CONSTRAINT [DF_tblPersonnelFunction_Active]  DEFAULT ((0)) FOR [Active]
GO
ALTER TABLE [dbo].[tblPersonnelFunction] ADD  CONSTRAINT [DF_tblPersonnelFunction_RegisterDate]  DEFAULT ('') FOR [RegisterDate]
GO
ALTER TABLE [dbo].[tblPersonnels] ADD  CONSTRAINT [DF_tblPersonnels_PersonnelID]  DEFAULT ((0)) FOR [PersonnelID]
GO
ALTER TABLE [dbo].[tblPersonnels] ADD  CONSTRAINT [DF_tblPersonnels_Name]  DEFAULT ('') FOR [Name]
GO
ALTER TABLE [dbo].[tblPersonnels] ADD  CONSTRAINT [DF_tblPersonnels_LastName]  DEFAULT ('') FOR [LastName]
GO
ALTER TABLE [dbo].[tblPersonnels] ADD  CONSTRAINT [DF_tblPersonnels_Image]  DEFAULT ('') FOR [Image]
GO
ALTER TABLE [dbo].[tblPersonnels] ADD  CONSTRAINT [DF_tblPersonnels_NationCode]  DEFAULT ('') FOR [NationCode]
GO
ALTER TABLE [dbo].[tblPersonnels] ADD  CONSTRAINT [DF_tblPersonnels_Id]  DEFAULT ('') FOR [Id]
GO
ALTER TABLE [dbo].[tblPersonnels] ADD  CONSTRAINT [DF_tblPersonnels_SexType]  DEFAULT ((0)) FOR [SexType]
GO
ALTER TABLE [dbo].[tblPersonnels] ADD  CONSTRAINT [DF_tblPersonnel_MaritalStatus]  DEFAULT ((0)) FOR [MaritalStatus]
GO
ALTER TABLE [dbo].[tblPersonnels] ADD  CONSTRAINT [DF_tblPersonnels_FatherName]  DEFAULT ('') FOR [FatherName]
GO
ALTER TABLE [dbo].[tblPersonnels] ADD  CONSTRAINT [DF_tblPersonnels_BithayDay]  DEFAULT ('') FOR [BithayDay]
GO
ALTER TABLE [dbo].[tblPersonnels] ADD  CONSTRAINT [DF_tblPersonnels_CityOfBirth]  DEFAULT ('') FOR [CityOfBirth]
GO
ALTER TABLE [dbo].[tblPersonnels] ADD  CONSTRAINT [DF_tblPersonnels_CityOfLife]  DEFAULT ('') FOR [CityOfLife]
GO
ALTER TABLE [dbo].[tblPersonnels] ADD  CONSTRAINT [DF_tblPersonnels_Address]  DEFAULT ('') FOR [Address]
GO
ALTER TABLE [dbo].[tblPersonnels] ADD  CONSTRAINT [DF_tblPersonnels_Mobile]  DEFAULT ('') FOR [Mobile]
GO
ALTER TABLE [dbo].[tblPersonnels] ADD  CONSTRAINT [DF_tblPersonnels_Description]  DEFAULT ('') FOR [Description]
GO
ALTER TABLE [dbo].[tblPersonnels] ADD  CONSTRAINT [DF_tblPersonnels_Active]  DEFAULT ((0)) FOR [Active]
GO
ALTER TABLE [dbo].[tblPersonnels] ADD  CONSTRAINT [DF_tblPersonnels_RegisterDate]  DEFAULT ('') FOR [RegisterDate]
GO
ALTER TABLE [dbo].[tblChecks]  WITH CHECK ADD  CONSTRAINT [FK_tblChecks_tblChecks] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[tblCustomers] ([CustomerID])
GO
ALTER TABLE [dbo].[tblChecks] CHECK CONSTRAINT [FK_tblChecks_tblChecks]
GO
ALTER TABLE [dbo].[tblCustomerBuy]  WITH CHECK ADD  CONSTRAINT [FK_tblCostumerBuy_tblCustomers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[tblCustomers] ([CustomerID])
GO
ALTER TABLE [dbo].[tblCustomerBuy] CHECK CONSTRAINT [FK_tblCostumerBuy_tblCustomers]
GO
ALTER TABLE [dbo].[tblCustomerBuyList]  WITH CHECK ADD  CONSTRAINT [FK_tblCostumerBuyList_tblCostumerBuy] FOREIGN KEY([CustomerBuyID])
REFERENCES [dbo].[tblCustomerBuy] ([CustomerBuyID])
GO
ALTER TABLE [dbo].[tblCustomerBuyList] CHECK CONSTRAINT [FK_tblCostumerBuyList_tblCostumerBuy]
GO
ALTER TABLE [dbo].[tblDocuments]  WITH CHECK ADD  CONSTRAINT [FK_tblDocuments_tblCustomers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[tblCustomers] ([CustomerID])
GO
ALTER TABLE [dbo].[tblDocuments] CHECK CONSTRAINT [FK_tblDocuments_tblCustomers]
GO
ALTER TABLE [dbo].[tblFactorsList]  WITH CHECK ADD  CONSTRAINT [FK_tblFactorList_tblCarpets] FOREIGN KEY([CarpetID])
REFERENCES [dbo].[tblCarpets] ([CarpetID])
GO
ALTER TABLE [dbo].[tblFactorsList] CHECK CONSTRAINT [FK_tblFactorList_tblCarpets]
GO
ALTER TABLE [dbo].[tblFactorsList]  WITH CHECK ADD  CONSTRAINT [FK_tblFactorList_tblFactor] FOREIGN KEY([FactorID])
REFERENCES [dbo].[tblFactors] ([FactorID])
GO
ALTER TABLE [dbo].[tblFactorsList] CHECK CONSTRAINT [FK_tblFactorList_tblFactor]
GO
ALTER TABLE [dbo].[tblLog]  WITH CHECK ADD  CONSTRAINT [FK_tblLog_tblLogType] FOREIGN KEY([LogTypeID])
REFERENCES [dbo].[tblLogType] ([LogTypeID])
GO
ALTER TABLE [dbo].[tblLog] CHECK CONSTRAINT [FK_tblLog_tblLogType]
GO
ALTER TABLE [dbo].[tblPersonnelFunction]  WITH CHECK ADD  CONSTRAINT [FK_tblPersonnelFunction_tblCarpets] FOREIGN KEY([CarpetID])
REFERENCES [dbo].[tblCarpets] ([CarpetID])
GO
ALTER TABLE [dbo].[tblPersonnelFunction] CHECK CONSTRAINT [FK_tblPersonnelFunction_tblCarpets]
GO
ALTER TABLE [dbo].[tblPersonnelFunction]  WITH CHECK ADD  CONSTRAINT [FK_tblPersonnelFunction_tblPersonnels] FOREIGN KEY([PersonnelID])
REFERENCES [dbo].[tblPersonnels] ([PersonnelID])
GO
ALTER TABLE [dbo].[tblPersonnelFunction] CHECK CONSTRAINT [FK_tblPersonnelFunction_tblPersonnels]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1 فروشنده مواد اولیه
2 خانگی' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblCustomers', @level2type=N'COLUMN',@level2name=N'CustomerTypeID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1 دریافتی
2 پرداختی' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblDocuments', @level2type=N'COLUMN',@level2name=N'DocumetnTypeID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'۱ ثبت
۲ ویرایش
۳ حذف
۴ تغییر وضعیت' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblLogType', @level2type=N'COLUMN',@level2name=N'RegTypeID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 مرد
۱ زن' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblPersonnels', @level2type=N'COLUMN',@level2name=N'SexType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'۱ مجرد
۲ متاهل' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblPersonnels', @level2type=N'COLUMN',@level2name=N'MaritalStatus'
GO
USE [master]
GO
ALTER DATABASE [CarpetCleaning] SET  READ_WRITE 
GO
