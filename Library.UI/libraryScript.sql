USE [LibraryDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 9/22/2023 4:27:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 9/22/2023 4:27:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[BooksId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[ISBN] [nvarchar](13) NOT NULL,
	[Image] [nvarchar](max) NOT NULL,
	[Author] [nvarchar](max) NOT NULL,
	[BookStatus] [bit] NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[CurrentLoanId] [int] NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[BooksId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 9/22/2023 4:27:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loan]    Script Date: 9/22/2023 4:27:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loan](
	[LoanId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[SurName] [nvarchar](max) NOT NULL,
	[ReturnDate] [datetime2](7) NOT NULL,
	[DeliveryDate] [datetime2](7) NOT NULL,
	[BooksId] [int] NOT NULL,
 CONSTRAINT [PK_Loan] PRIMARY KEY CLUSTERED 
(
	[LoanId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230920134801_initial', N'8.0.0-preview.1.23111.4')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230920135851_01', N'8.0.0-preview.1.23111.4')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230920193955_addCurrentLondI', N'8.0.0-preview.1.23111.4')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230920194404_UpdateCurrentLoanId', N'8.0.0-preview.1.23111.4')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230920200216_removeLoanStatus', N'8.0.0-preview.1.23111.4')
GO
SET IDENTITY_INSERT [dbo].[Books] ON 

INSERT [dbo].[Books] ([BooksId], [Name], [ISBN], [Image], [Author], [BookStatus], [Description], [CategoryId], [CurrentLoanId]) VALUES (16, N'Suç ve Ceza', N'1213214324123', N'3ffd9634-b8fe-4e77-bf75-992cf335d0ea.jpg', N'Dostoyevski', 0, N'0', 1, NULL)
INSERT [dbo].[Books] ([BooksId], [Name], [ISBN], [Image], [Author], [BookStatus], [Description], [CategoryId], [CurrentLoanId]) VALUES (17, N'Pinokyo', N'1213214324124', N'5e953fc9-92ed-4c1a-adf3-3b4cc6e2ce54.jpg', N'Sylvia Nasar', 1, N'0', 2, 36)
INSERT [dbo].[Books] ([BooksId], [Name], [ISBN], [Image], [Author], [BookStatus], [Description], [CategoryId], [CurrentLoanId]) VALUES (18, N'Akıl Oyunları', N'1213214324121', N'71159f31-db19-40de-9782-ac52583d08cc.jpg', N'Daniel Pamer', 1, N'0', 7, 35)
INSERT [dbo].[Books] ([BooksId], [Name], [ISBN], [Image], [Author], [BookStatus], [Description], [CategoryId], [CurrentLoanId]) VALUES (19, N'Beyaz Zambaklar Ülkesinde', N'1213214324123', N'3261454a-ef65-46da-850c-15bff7c3e5d6.jpg', N'Sylvia Nasar', 0, N'0', 5, NULL)
SET IDENTITY_INSERT [dbo].[Books] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CategoryId], [Name]) VALUES (1, N'Roman')
INSERT [dbo].[Category] ([CategoryId], [Name]) VALUES (2, N'Hikaye')
INSERT [dbo].[Category] ([CategoryId], [Name]) VALUES (3, N'Gezi')
INSERT [dbo].[Category] ([CategoryId], [Name]) VALUES (4, N'Şiir')
INSERT [dbo].[Category] ([CategoryId], [Name]) VALUES (5, N'Edebiyat')
INSERT [dbo].[Category] ([CategoryId], [Name]) VALUES (6, N'Kişisel Gelişim')
INSERT [dbo].[Category] ([CategoryId], [Name]) VALUES (7, N'Bilim Kurgu')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Loan] ON 

INSERT [dbo].[Loan] ([LoanId], [Name], [SurName], [ReturnDate], [DeliveryDate], [BooksId]) VALUES (35, N'Sümeyye ', N'Yerli', CAST(N'2023-09-30T00:00:00.0000000' AS DateTime2), CAST(N'2023-09-22T00:00:00.0000000' AS DateTime2), 18)
INSERT [dbo].[Loan] ([LoanId], [Name], [SurName], [ReturnDate], [DeliveryDate], [BooksId]) VALUES (36, N'Bahar Cemre', N'Çelik', CAST(N'2023-10-07T00:00:00.0000000' AS DateTime2), CAST(N'2023-09-22T00:00:00.0000000' AS DateTime2), 17)
SET IDENTITY_INSERT [dbo].[Loan] OFF
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Category_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Category_CategoryId]
GO
ALTER TABLE [dbo].[Loan]  WITH CHECK ADD  CONSTRAINT [FK_Loan_Books_BooksId] FOREIGN KEY([BooksId])
REFERENCES [dbo].[Books] ([BooksId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Loan] CHECK CONSTRAINT [FK_Loan_Books_BooksId]
GO
