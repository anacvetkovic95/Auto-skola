USE [master]
GO
/****** Object:  Database [AutoSkola]    Script Date: 04-Nov-19 00:15:28 ******/
CREATE DATABASE [AutoSkola]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AutoSkola', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\AutoSkola.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AutoSkola_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\AutoSkola_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [AutoSkola] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AutoSkola].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AutoSkola] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AutoSkola] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AutoSkola] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AutoSkola] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AutoSkola] SET ARITHABORT OFF 
GO
ALTER DATABASE [AutoSkola] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AutoSkola] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AutoSkola] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AutoSkola] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AutoSkola] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AutoSkola] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AutoSkola] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AutoSkola] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AutoSkola] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AutoSkola] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AutoSkola] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AutoSkola] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AutoSkola] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AutoSkola] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AutoSkola] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AutoSkola] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AutoSkola] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AutoSkola] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AutoSkola] SET  MULTI_USER 
GO
ALTER DATABASE [AutoSkola] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AutoSkola] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AutoSkola] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AutoSkola] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AutoSkola] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AutoSkola] SET QUERY_STORE = OFF
GO
USE [AutoSkola]
GO
/****** Object:  Table [dbo].[Instruktor]    Script Date: 04-Nov-19 00:15:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Instruktor](
	[InstruktorID] [int] NOT NULL,
	[Ime] [varchar](50) NULL,
	[Prezime] [varchar](50) NULL,
	[DatumRodjenja] [date] NULL,
	[Kontakt] [varchar](50) NULL,
 CONSTRAINT [PK_Instruktor] PRIMARY KEY CLUSTERED 
(
	[InstruktorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Korisnik]    Script Date: 04-Nov-19 00:15:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Korisnik](
	[KorisnikID] [int] NOT NULL,
	[Ime] [varchar](50) NULL,
	[Prezime] [varchar](50) NULL,
	[KorisnickoIme] [varchar](50) NULL,
	[Lozinka] [varchar](50) NULL,
 CONSTRAINT [PK_Korisnik] PRIMARY KEY CLUSTERED 
(
	[KorisnikID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Obuka]    Script Date: 04-Nov-19 00:15:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Obuka](
	[SifraObuke] [int] NOT NULL,
	[DatumOd] [date] NULL,
	[DatumDo] [date] NULL,
 CONSTRAINT [PK_Obuka] PRIMARY KEY CLUSTERED 
(
	[SifraObuke] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SpisakUcenika]    Script Date: 04-Nov-19 00:15:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SpisakUcenika](
	[SifraUgovora] [int] NOT NULL,
	[RedniBr] [int] NOT NULL,
	[UcenikID] [int] NULL,
 CONSTRAINT [PK_SpisakUcenika] PRIMARY KEY CLUSTERED 
(
	[SifraUgovora] ASC,
	[RedniBr] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ucenik]    Script Date: 04-Nov-19 00:15:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ucenik](
	[ID] [int] NOT NULL,
	[Ime] [varchar](50) NULL,
	[Prezime] [varchar](50) NULL,
	[DatumRodjenja] [date] NULL,
	[Kontakt] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
 CONSTRAINT [PK_Ucenik] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ugovor]    Script Date: 04-Nov-19 00:15:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ugovor](
	[SifraUgovora] [int] NOT NULL,
	[Naziv] [varchar](50) NULL,
	[InstruktorID] [int] NULL,
	[ObukaID] [int] NULL,
	[KorisnikID] [int] NULL,
 CONSTRAINT [PK_Ugovor] PRIMARY KEY CLUSTERED 
(
	[SifraUgovora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Instruktor] ([InstruktorID], [Ime], [Prezime], [DatumRodjenja], [Kontakt]) VALUES (1, N'Zoran', N'Cvetkovic', CAST(N'1961-07-06' AS Date), N'0641388111')
INSERT [dbo].[Instruktor] ([InstruktorID], [Ime], [Prezime], [DatumRodjenja], [Kontakt]) VALUES (2, N'Dragoljub', N'Draskovic', CAST(N'1975-10-11' AS Date), N'0632637744')
INSERT [dbo].[Instruktor] ([InstruktorID], [Ime], [Prezime], [DatumRodjenja], [Kontakt]) VALUES (3, N'Zlatko', N'Sreckovic', CAST(N'1964-10-12' AS Date), N'0652127888')
INSERT [dbo].[Korisnik] ([KorisnikID], [Ime], [Prezime], [KorisnickoIme], [Lozinka]) VALUES (1, N'Zoran', N'Cvetkovic', N'cvele', N'cvele')
INSERT [dbo].[Korisnik] ([KorisnikID], [Ime], [Prezime], [KorisnickoIme], [Lozinka]) VALUES (2, N'Biljana', N'Draskovic', N'bilja', N'bilja')
INSERT [dbo].[Korisnik] ([KorisnikID], [Ime], [Prezime], [KorisnickoIme], [Lozinka]) VALUES (3, N'Drasko', N'Draskovic', N'drago', N'drago')
INSERT [dbo].[Obuka] ([SifraObuke], [DatumOd], [DatumDo]) VALUES (1, CAST(N'2019-01-01' AS Date), CAST(N'2019-01-03' AS Date))
INSERT [dbo].[Obuka] ([SifraObuke], [DatumOd], [DatumDo]) VALUES (2, CAST(N'2019-10-01' AS Date), CAST(N'2019-10-02' AS Date))
INSERT [dbo].[Obuka] ([SifraObuke], [DatumOd], [DatumDo]) VALUES (3, CAST(N'2019-02-02' AS Date), CAST(N'2019-03-02' AS Date))
INSERT [dbo].[SpisakUcenika] ([SifraUgovora], [RedniBr], [UcenikID]) VALUES (3, 3, 3)
INSERT [dbo].[SpisakUcenika] ([SifraUgovora], [RedniBr], [UcenikID]) VALUES (6, 1, 3)
INSERT [dbo].[SpisakUcenika] ([SifraUgovora], [RedniBr], [UcenikID]) VALUES (7, 1, 1)
INSERT [dbo].[SpisakUcenika] ([SifraUgovora], [RedniBr], [UcenikID]) VALUES (8, 1, 1)
INSERT [dbo].[SpisakUcenika] ([SifraUgovora], [RedniBr], [UcenikID]) VALUES (8, 2, 2)
INSERT [dbo].[SpisakUcenika] ([SifraUgovora], [RedniBr], [UcenikID]) VALUES (8, 3, 3)
INSERT [dbo].[SpisakUcenika] ([SifraUgovora], [RedniBr], [UcenikID]) VALUES (10, 1, 1)
INSERT [dbo].[SpisakUcenika] ([SifraUgovora], [RedniBr], [UcenikID]) VALUES (10, 2, 2)
INSERT [dbo].[SpisakUcenika] ([SifraUgovora], [RedniBr], [UcenikID]) VALUES (10, 3, 3)
INSERT [dbo].[SpisakUcenika] ([SifraUgovora], [RedniBr], [UcenikID]) VALUES (13, 1, 1)
INSERT [dbo].[SpisakUcenika] ([SifraUgovora], [RedniBr], [UcenikID]) VALUES (13, 2, 3)
INSERT [dbo].[SpisakUcenika] ([SifraUgovora], [RedniBr], [UcenikID]) VALUES (16, 1, 1)
INSERT [dbo].[SpisakUcenika] ([SifraUgovora], [RedniBr], [UcenikID]) VALUES (16, 2, 3)
INSERT [dbo].[SpisakUcenika] ([SifraUgovora], [RedniBr], [UcenikID]) VALUES (16, 3, 9)
INSERT [dbo].[SpisakUcenika] ([SifraUgovora], [RedniBr], [UcenikID]) VALUES (20, 1, 8)
INSERT [dbo].[SpisakUcenika] ([SifraUgovora], [RedniBr], [UcenikID]) VALUES (20, 2, 9)
INSERT [dbo].[SpisakUcenika] ([SifraUgovora], [RedniBr], [UcenikID]) VALUES (21, 1, 2)
INSERT [dbo].[SpisakUcenika] ([SifraUgovora], [RedniBr], [UcenikID]) VALUES (21, 2, 4)
INSERT [dbo].[SpisakUcenika] ([SifraUgovora], [RedniBr], [UcenikID]) VALUES (22, 1, 3)
INSERT [dbo].[SpisakUcenika] ([SifraUgovora], [RedniBr], [UcenikID]) VALUES (22, 2, 8)
INSERT [dbo].[SpisakUcenika] ([SifraUgovora], [RedniBr], [UcenikID]) VALUES (23, 1, 2)
INSERT [dbo].[SpisakUcenika] ([SifraUgovora], [RedniBr], [UcenikID]) VALUES (23, 2, 3)
INSERT [dbo].[Ucenik] ([ID], [Ime], [Prezime], [DatumRodjenja], [Kontakt], [Email]) VALUES (1, N'Ana', N'Cvetkovic', CAST(N'1995-02-13' AS Date), N'0652199513', N'ana.cvetkovic@gmail.com')
INSERT [dbo].[Ucenik] ([ID], [Ime], [Prezime], [DatumRodjenja], [Kontakt], [Email]) VALUES (2, N'Tamara', N'Rakovic', CAST(N'1995-09-20' AS Date), N'0632188575', N'tamara.rakovic@gamil.com')
INSERT [dbo].[Ucenik] ([ID], [Ime], [Prezime], [DatumRodjenja], [Kontakt], [Email]) VALUES (3, N'Andjela', N'Cvetojevic', CAST(N'1995-08-20' AS Date), N'0627777777', N'andjela.cvetojevic@gmail.com')
INSERT [dbo].[Ucenik] ([ID], [Ime], [Prezime], [DatumRodjenja], [Kontakt], [Email]) VALUES (4, N'Nikola', N'Jeremic', CAST(N'1996-10-17' AS Date), N'062372734', N'jeremic.nikola@gmail.com')
INSERT [dbo].[Ucenik] ([ID], [Ime], [Prezime], [DatumRodjenja], [Kontakt], [Email]) VALUES (8, N'Marijana', N'Micic', CAST(N'1987-05-05' AS Date), N'063333333', N'mivcic@gmail.com')
INSERT [dbo].[Ucenik] ([ID], [Ime], [Prezime], [DatumRodjenja], [Kontakt], [Email]) VALUES (9, N'Gvozden', N'Vukojevic', CAST(N'1990-05-05' AS Date), N'06577777', N'gvoki@gmail.com')
INSERT [dbo].[Ucenik] ([ID], [Ime], [Prezime], [DatumRodjenja], [Kontakt], [Email]) VALUES (10, N'Sandra', N'Statkic', CAST(N'1991-10-10' AS Date), N'064234542', N'sandra@gmail.com')
INSERT [dbo].[Ucenik] ([ID], [Ime], [Prezime], [DatumRodjenja], [Kontakt], [Email]) VALUES (11, N'Ivan ', N'Jovkovic', CAST(N'1988-09-02' AS Date), N'0691975777', N'ivan.jovkovic@gmail.com')
INSERT [dbo].[Ucenik] ([ID], [Ime], [Prezime], [DatumRodjenja], [Kontakt], [Email]) VALUES (12, N'Nikola', N'Cvetkovic', CAST(N'1991-07-25' AS Date), N'062247697', N'cvele91@gmail.com')
INSERT [dbo].[Ugovor] ([SifraUgovora], [Naziv], [InstruktorID], [ObukaID], [KorisnikID]) VALUES (3, N'Prva pomoc', 3, 2, 3)
INSERT [dbo].[Ugovor] ([SifraUgovora], [Naziv], [InstruktorID], [ObukaID], [KorisnikID]) VALUES (6, N'Prva pomoc', 1, 3, 1)
INSERT [dbo].[Ugovor] ([SifraUgovora], [Naziv], [InstruktorID], [ObukaID], [KorisnikID]) VALUES (7, N'Teorijska nastava', 1, 3, 1)
INSERT [dbo].[Ugovor] ([SifraUgovora], [Naziv], [InstruktorID], [ObukaID], [KorisnikID]) VALUES (8, N'Dodatni casovi', 2, 3, 1)
INSERT [dbo].[Ugovor] ([SifraUgovora], [Naziv], [InstruktorID], [ObukaID], [KorisnikID]) VALUES (9, N'Prakticna nastava', 1, 1, 2)
INSERT [dbo].[Ugovor] ([SifraUgovora], [Naziv], [InstruktorID], [ObukaID], [KorisnikID]) VALUES (10, N'Dodatni casovi', 1, 2, 1)
INSERT [dbo].[Ugovor] ([SifraUgovora], [Naziv], [InstruktorID], [ObukaID], [KorisnikID]) VALUES (11, N'Teorijska nastava', 3, 1, 1)
INSERT [dbo].[Ugovor] ([SifraUgovora], [Naziv], [InstruktorID], [ObukaID], [KorisnikID]) VALUES (12, N'Prakticna nastava', 2, 2, 1)
INSERT [dbo].[Ugovor] ([SifraUgovora], [Naziv], [InstruktorID], [ObukaID], [KorisnikID]) VALUES (13, N'Prva pomoc', 3, 3, 1)
INSERT [dbo].[Ugovor] ([SifraUgovora], [Naziv], [InstruktorID], [ObukaID], [KorisnikID]) VALUES (16, N'Torijska nastava', 1, 2, 1)
INSERT [dbo].[Ugovor] ([SifraUgovora], [Naziv], [InstruktorID], [ObukaID], [KorisnikID]) VALUES (17, N'Dodatni casovi', 2, 2, 2)
INSERT [dbo].[Ugovor] ([SifraUgovora], [Naziv], [InstruktorID], [ObukaID], [KorisnikID]) VALUES (18, N'Prva pomoc', 3, 1, 3)
INSERT [dbo].[Ugovor] ([SifraUgovora], [Naziv], [InstruktorID], [ObukaID], [KorisnikID]) VALUES (19, N'Teorijska nastava', 1, 1, 3)
INSERT [dbo].[Ugovor] ([SifraUgovora], [Naziv], [InstruktorID], [ObukaID], [KorisnikID]) VALUES (20, N'Prakticna nastava', 3, 2, 1)
INSERT [dbo].[Ugovor] ([SifraUgovora], [Naziv], [InstruktorID], [ObukaID], [KorisnikID]) VALUES (21, N'Teorijska nastava', 2, 1, 1)
INSERT [dbo].[Ugovor] ([SifraUgovora], [Naziv], [InstruktorID], [ObukaID], [KorisnikID]) VALUES (22, N'Dodatni casovi', 3, 3, 1)
INSERT [dbo].[Ugovor] ([SifraUgovora], [Naziv], [InstruktorID], [ObukaID], [KorisnikID]) VALUES (23, N'Oktobarski rok', 1, 2, 1)
ALTER TABLE [dbo].[SpisakUcenika]  WITH CHECK ADD  CONSTRAINT [FK_SpisakUcenika_Ucenik] FOREIGN KEY([UcenikID])
REFERENCES [dbo].[Ucenik] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SpisakUcenika] CHECK CONSTRAINT [FK_SpisakUcenika_Ucenik]
GO
ALTER TABLE [dbo].[SpisakUcenika]  WITH CHECK ADD  CONSTRAINT [FK_SpisakUcenika_Ugovor] FOREIGN KEY([SifraUgovora])
REFERENCES [dbo].[Ugovor] ([SifraUgovora])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SpisakUcenika] CHECK CONSTRAINT [FK_SpisakUcenika_Ugovor]
GO
ALTER TABLE [dbo].[Ugovor]  WITH CHECK ADD  CONSTRAINT [FK_Ugovor_Instruktor] FOREIGN KEY([InstruktorID])
REFERENCES [dbo].[Instruktor] ([InstruktorID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Ugovor] CHECK CONSTRAINT [FK_Ugovor_Instruktor]
GO
ALTER TABLE [dbo].[Ugovor]  WITH CHECK ADD  CONSTRAINT [FK_Ugovor_Korisnik] FOREIGN KEY([KorisnikID])
REFERENCES [dbo].[Korisnik] ([KorisnikID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Ugovor] CHECK CONSTRAINT [FK_Ugovor_Korisnik]
GO
ALTER TABLE [dbo].[Ugovor]  WITH CHECK ADD  CONSTRAINT [FK_Ugovor_Obuka] FOREIGN KEY([ObukaID])
REFERENCES [dbo].[Obuka] ([SifraObuke])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Ugovor] CHECK CONSTRAINT [FK_Ugovor_Obuka]
GO
USE [master]
GO
ALTER DATABASE [AutoSkola] SET  READ_WRITE 
GO
