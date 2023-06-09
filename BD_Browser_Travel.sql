USE [master]
GO
/****** Object:  Database [BD_Browser_Travel]    Script Date: 18/03/2023 9:46:05 p. m. ******/
CREATE DATABASE [BD_Browser_Travel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BD_Browser_Travel', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BD_Browser_Travel.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BD_Browser_Travel_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BD_Browser_Travel_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BD_Browser_Travel] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BD_Browser_Travel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BD_Browser_Travel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BD_Browser_Travel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BD_Browser_Travel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BD_Browser_Travel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BD_Browser_Travel] SET ARITHABORT OFF 
GO
ALTER DATABASE [BD_Browser_Travel] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BD_Browser_Travel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BD_Browser_Travel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BD_Browser_Travel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BD_Browser_Travel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BD_Browser_Travel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BD_Browser_Travel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BD_Browser_Travel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BD_Browser_Travel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BD_Browser_Travel] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BD_Browser_Travel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BD_Browser_Travel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BD_Browser_Travel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BD_Browser_Travel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BD_Browser_Travel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BD_Browser_Travel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BD_Browser_Travel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BD_Browser_Travel] SET RECOVERY FULL 
GO
ALTER DATABASE [BD_Browser_Travel] SET  MULTI_USER 
GO
ALTER DATABASE [BD_Browser_Travel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BD_Browser_Travel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BD_Browser_Travel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BD_Browser_Travel] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BD_Browser_Travel] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BD_Browser_Travel] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'BD_Browser_Travel', N'ON'
GO
ALTER DATABASE [BD_Browser_Travel] SET QUERY_STORE = OFF
GO
USE [BD_Browser_Travel]
GO
/****** Object:  Table [dbo].[autores]    Script Date: 18/03/2023 9:46:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[autores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](45) NULL,
	[Apellidos] [varchar](45) NULL,
 CONSTRAINT [PK_autores] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[autores_has_libros]    Script Date: 18/03/2023 9:46:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[autores_has_libros](
	[Autores_id] [int] NULL,
	[Libros_ISBN] [bigint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[editoriales]    Script Date: 18/03/2023 9:46:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[editoriales](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](45) NULL,
	[Sede] [varchar](45) NULL,
 CONSTRAINT [PK_editoriales] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[libros]    Script Date: 18/03/2023 9:46:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[libros](
	[ISBN] [bigint] NOT NULL,
	[Editoriales_id] [int] NULL,
	[Titulo] [varchar](45) NULL,
	[Sinopsis] [text] NULL,
	[N_paginas] [varchar](45) NULL,
 CONSTRAINT [PK_libros] PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[autores] ON 

INSERT [dbo].[autores] ([Id], [Nombre], [Apellidos]) VALUES (1, N'Gabriel', N'Garcia Marquez')
INSERT [dbo].[autores] ([Id], [Nombre], [Apellidos]) VALUES (2, N'Paulo', N'Coelho')
SET IDENTITY_INSERT [dbo].[autores] OFF
GO
INSERT [dbo].[autores_has_libros] ([Autores_id], [Libros_ISBN]) VALUES (1, 9780060114183)
INSERT [dbo].[autores_has_libros] ([Autores_id], [Libros_ISBN]) VALUES (2, 9783257063738)
GO
SET IDENTITY_INSERT [dbo].[editoriales] ON 

INSERT [dbo].[editoriales] ([Id], [Nombre], [Sede]) VALUES (1, N'Editorial Sudamericana', N'Colombia')
INSERT [dbo].[editoriales] ([Id], [Nombre], [Sede]) VALUES (2, N'Editorial Planeta', N'Brazil')
SET IDENTITY_INSERT [dbo].[editoriales] OFF
GO
INSERT [dbo].[libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (9780060114183, 1, N'Cien años de soledad', N'Sinopsis: Entre la boda de José Arcadio Buendía con Amelia Iguarán hasta la maldición de Aureliano Babilonia transcurre todo un siglo. Cien años de soledad para una estirpe única, fantástica, capaz de fundar una ciudad tan especial como Macondo y de engendrar niños con cola de cerdo.', N'471')
INSERT [dbo].[libros] ([ISBN], [Editoriales_id], [Titulo], [Sinopsis], [N_paginas]) VALUES (9783257063738, 2, N'Onze Minutos', N'Maria es de un pueblo situado al norte de Brasil. Todavía adolescente, viaja a Río de Janeiro, donde conoce a un empresario que le ofrece un buen trabajo en Ginebra. Allí, Maria sueña con encontrar fama y fortuna, pero  acabará ejerciendo la prostitución. El aprendizaje que extraerá de sus duras experiencias modificará para siempre su actitud ante sí misma y ante la vida.Como un cuento de hadas para adultos, Once minutos es una novela que explora la naturaleza del sexo y del amor, la intensa y difícil relación entre cuerpo y alma, y cómo alcanzar la perfecta unión entre ambos. Once minutos ofrece al lector una experiencia inigualable de lectura y reflexión.', N'304')
GO
ALTER TABLE [dbo].[autores_has_libros]  WITH CHECK ADD  CONSTRAINT [FK_autores_has_libros_autores] FOREIGN KEY([Autores_id])
REFERENCES [dbo].[autores] ([Id])
GO
ALTER TABLE [dbo].[autores_has_libros] CHECK CONSTRAINT [FK_autores_has_libros_autores]
GO
ALTER TABLE [dbo].[autores_has_libros]  WITH CHECK ADD  CONSTRAINT [FK_autores_has_libros_libros] FOREIGN KEY([Libros_ISBN])
REFERENCES [dbo].[libros] ([ISBN])
GO
ALTER TABLE [dbo].[autores_has_libros] CHECK CONSTRAINT [FK_autores_has_libros_libros]
GO
ALTER TABLE [dbo].[libros]  WITH CHECK ADD  CONSTRAINT [FK_libros_editoriales] FOREIGN KEY([Editoriales_id])
REFERENCES [dbo].[editoriales] ([Id])
GO
ALTER TABLE [dbo].[libros] CHECK CONSTRAINT [FK_libros_editoriales]
GO
USE [master]
GO
ALTER DATABASE [BD_Browser_Travel] SET  READ_WRITE 
GO
