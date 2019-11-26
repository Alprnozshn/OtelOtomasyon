USE [DbOtel]
GO
ALTER TABLE [dbo].[tblPersonel] DROP CONSTRAINT [FK_tblPersonel_tblDepartman]
GO
ALTER TABLE [dbo].[tblMusteriAdisyon] DROP CONSTRAINT [FK_tblMusteriAdisyon_tblMusteri]
GO
ALTER TABLE [dbo].[tblMusteriAdisyon] DROP CONSTRAINT [FK_tblMusteriAdisyon_tblAdisyon]
GO
ALTER TABLE [dbo].[tblMusteri] DROP CONSTRAINT [FK_tblMusteri_tblOda]
GO
/****** Object:  Table [dbo].[tblPersonel]    Script Date: 27.11.2019 00:50:07 ******/
DROP TABLE [dbo].[tblPersonel]
GO
/****** Object:  Table [dbo].[tblOda]    Script Date: 27.11.2019 00:50:07 ******/
DROP TABLE [dbo].[tblOda]
GO
/****** Object:  Table [dbo].[tblMusteriAdisyon]    Script Date: 27.11.2019 00:50:07 ******/
DROP TABLE [dbo].[tblMusteriAdisyon]
GO
/****** Object:  Table [dbo].[tblMusteri]    Script Date: 27.11.2019 00:50:07 ******/
DROP TABLE [dbo].[tblMusteri]
GO
/****** Object:  Table [dbo].[tblKullanici]    Script Date: 27.11.2019 00:50:07 ******/
DROP TABLE [dbo].[tblKullanici]
GO
/****** Object:  Table [dbo].[tblDepartman]    Script Date: 27.11.2019 00:50:07 ******/
DROP TABLE [dbo].[tblDepartman]
GO
/****** Object:  Table [dbo].[tblAdisyon]    Script Date: 27.11.2019 00:50:07 ******/
DROP TABLE [dbo].[tblAdisyon]
GO
USE [master]
GO
/****** Object:  Database [DbOtel]    Script Date: 27.11.2019 00:50:07 ******/
DROP DATABASE [DbOtel]
GO
/****** Object:  Database [DbOtel]    Script Date: 27.11.2019 00:50:07 ******/
CREATE DATABASE [DbOtel] ON  PRIMARY 
( NAME = N'DbOtel', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\DbOtel.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DbOtel_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\DbOtel_log.LDF' , SIZE = 576KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DbOtel] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DbOtel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DbOtel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DbOtel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DbOtel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DbOtel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DbOtel] SET ARITHABORT OFF 
GO
ALTER DATABASE [DbOtel] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DbOtel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DbOtel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DbOtel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DbOtel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DbOtel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DbOtel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DbOtel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DbOtel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DbOtel] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DbOtel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DbOtel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DbOtel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DbOtel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DbOtel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DbOtel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DbOtel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DbOtel] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DbOtel] SET  MULTI_USER 
GO
ALTER DATABASE [DbOtel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DbOtel] SET DB_CHAINING OFF 
GO
USE [DbOtel]
GO
/****** Object:  Table [dbo].[tblAdisyon]    Script Date: 27.11.2019 00:50:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAdisyon](
	[AdisyonID] [int] NOT NULL,
	[AdisyonAd] [nvarchar](150) NOT NULL,
	[AdisyonAdet] [smallint] NOT NULL,
	[AdisyonFiyat] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AdisyonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDepartman]    Script Date: 27.11.2019 00:50:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDepartman](
	[DepartmanID] [int] NOT NULL,
	[DepartmanAd] [nvarchar](50) NOT NULL,
	[Maas] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DepartmanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKullanici]    Script Date: 27.11.2019 00:50:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKullanici](
	[KullaniciID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [nvarchar](25) NOT NULL,
	[KullaniciSifre] [nvarchar](25) NOT NULL,
	[KullaniciTip] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[KullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblMusteri]    Script Date: 27.11.2019 00:50:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMusteri](
	[MusteriKayitID] [int] IDENTITY(1,1) NOT NULL,
	[MusteriTcKNo] [char](11) NOT NULL,
	[MusteriAd] [nvarchar](50) NOT NULL,
	[MusteriSoyad] [nvarchar](50) NOT NULL,
	[MusteriGirisTarih] [date] NOT NULL,
	[MusteriCikisTarih] [date] NOT NULL,
	[MusteriOdaNo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MusteriKayitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblMusteriAdisyon]    Script Date: 27.11.2019 00:50:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMusteriAdisyon](
	[MusteriID] [int] NOT NULL,
	[AdisyonID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblOda]    Script Date: 27.11.2019 00:50:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblOda](
	[OdaNo] [int] NOT NULL,
	[OdaTip] [nvarchar](50) NOT NULL,
	[OdaYatakSayisi] [int] NOT NULL,
	[OdaBosmu] [bit] NOT NULL,
	[OdaGunlukFiyat] [int] NOT NULL,
 CONSTRAINT [PK__tblOda__1909DEB907F6335A] PRIMARY KEY CLUSTERED 
(
	[OdaNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPersonel]    Script Date: 27.11.2019 00:50:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPersonel](
	[PersonelID] [int] IDENTITY(1,1) NOT NULL,
	[PersonelTcKNo] [char](11) NOT NULL,
	[PersonelAd] [nvarchar](50) NOT NULL,
	[PersonelSoyad] [nvarchar](50) NOT NULL,
	[PersonelAdres] [nvarchar](1000) NOT NULL,
	[PersonelTelNo] [char](11) NOT NULL,
	[PersonelDepartmanID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PersonelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblKullanici] ON 

INSERT [dbo].[tblKullanici] ([KullaniciID], [KullaniciAdi], [KullaniciSifre], [KullaniciTip]) VALUES (1, N'Alperen', N'1234', N'Yönetici')
INSERT [dbo].[tblKullanici] ([KullaniciID], [KullaniciAdi], [KullaniciSifre], [KullaniciTip]) VALUES (2, N'Ahmet', N'4321', N'Resepsiyon')
SET IDENTITY_INSERT [dbo].[tblKullanici] OFF
SET IDENTITY_INSERT [dbo].[tblMusteri] ON 

INSERT [dbo].[tblMusteri] ([MusteriKayitID], [MusteriTcKNo], [MusteriAd], [MusteriSoyad], [MusteriGirisTarih], [MusteriCikisTarih], [MusteriOdaNo]) VALUES (7, N'42061638280', N'Alperen', N'Özşahin', CAST(N'2019-10-31' AS Date), CAST(N'2019-11-30' AS Date), 202)
INSERT [dbo].[tblMusteri] ([MusteriKayitID], [MusteriTcKNo], [MusteriAd], [MusteriSoyad], [MusteriGirisTarih], [MusteriCikisTarih], [MusteriOdaNo]) VALUES (12, N'42424242421', N'Ahmet', N'KATIR', CAST(N'2019-11-08' AS Date), CAST(N'2019-11-08' AS Date), 101)
INSERT [dbo].[tblMusteri] ([MusteriKayitID], [MusteriTcKNo], [MusteriAd], [MusteriSoyad], [MusteriGirisTarih], [MusteriCikisTarih], [MusteriOdaNo]) VALUES (13, N'42061638282', N'Ahmet', N'HAYDAR', CAST(N'2019-11-24' AS Date), CAST(N'2019-11-30' AS Date), 201)
SET IDENTITY_INSERT [dbo].[tblMusteri] OFF
INSERT [dbo].[tblOda] ([OdaNo], [OdaTip], [OdaYatakSayisi], [OdaBosmu], [OdaGunlukFiyat]) VALUES (101, N'Suit', 2, 0, 100)
INSERT [dbo].[tblOda] ([OdaNo], [OdaTip], [OdaYatakSayisi], [OdaBosmu], [OdaGunlukFiyat]) VALUES (102, N'Suit', 2, 1, 100)
INSERT [dbo].[tblOda] ([OdaNo], [OdaTip], [OdaYatakSayisi], [OdaBosmu], [OdaGunlukFiyat]) VALUES (201, N'Villa', 4, 0, 300)
INSERT [dbo].[tblOda] ([OdaNo], [OdaTip], [OdaYatakSayisi], [OdaBosmu], [OdaGunlukFiyat]) VALUES (202, N'Villa', 4, 0, 300)
ALTER TABLE [dbo].[tblMusteri]  WITH CHECK ADD  CONSTRAINT [FK_tblMusteri_tblOda] FOREIGN KEY([MusteriOdaNo])
REFERENCES [dbo].[tblOda] ([OdaNo])
GO
ALTER TABLE [dbo].[tblMusteri] CHECK CONSTRAINT [FK_tblMusteri_tblOda]
GO
ALTER TABLE [dbo].[tblMusteriAdisyon]  WITH CHECK ADD  CONSTRAINT [FK_tblMusteriAdisyon_tblAdisyon] FOREIGN KEY([AdisyonID])
REFERENCES [dbo].[tblAdisyon] ([AdisyonID])
GO
ALTER TABLE [dbo].[tblMusteriAdisyon] CHECK CONSTRAINT [FK_tblMusteriAdisyon_tblAdisyon]
GO
ALTER TABLE [dbo].[tblMusteriAdisyon]  WITH CHECK ADD  CONSTRAINT [FK_tblMusteriAdisyon_tblMusteri] FOREIGN KEY([MusteriID])
REFERENCES [dbo].[tblMusteri] ([MusteriKayitID])
GO
ALTER TABLE [dbo].[tblMusteriAdisyon] CHECK CONSTRAINT [FK_tblMusteriAdisyon_tblMusteri]
GO
ALTER TABLE [dbo].[tblPersonel]  WITH CHECK ADD  CONSTRAINT [FK_tblPersonel_tblDepartman] FOREIGN KEY([PersonelDepartmanID])
REFERENCES [dbo].[tblDepartman] ([DepartmanID])
GO
ALTER TABLE [dbo].[tblPersonel] CHECK CONSTRAINT [FK_tblPersonel_tblDepartman]
GO
USE [master]
GO
ALTER DATABASE [DbOtel] SET  READ_WRITE 
GO
