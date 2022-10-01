USE [dbLibraryManagement]
GO
/****** Object:  Table [dbo].[tblAuthors]    Script Date: 1.10.2022 17:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAuthors](
	[a_id] [int] NOT NULL,
	[fullname] [varchar](50) NOT NULL,
	[birthdate] [date] NOT NULL,
	[country] [varchar](50) NOT NULL,
	[image] [varchar](200) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBooks]    Script Date: 1.10.2022 17:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBooks](
	[b_id] [int] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[pageCount] [smallint] NOT NULL,
	[releaseDate] [date] NOT NULL,
	[dateOfAddition] [date] NOT NULL,
	[stock] [int] NOT NULL,
	[image] [varchar](200) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBooksAuthors]    Script Date: 1.10.2022 17:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBooksAuthors](
	[book_id] [int] NOT NULL,
	[author_id] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBooksCategories]    Script Date: 1.10.2022 17:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBooksCategories](
	[book_id] [varchar](10) NOT NULL,
	[category_id] [varchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBooksUsers]    Script Date: 1.10.2022 17:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBooksUsers](
	[book_id] [int] NOT NULL,
	[user_id] [int] NOT NULL,
	[borrowDate] [date] NOT NULL,
	[returnDate] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCategories]    Script Date: 1.10.2022 17:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCategories](
	[c_id] [int] NOT NULL,
	[name] [varchar](20) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSettings]    Script Date: 1.10.2022 17:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSettings](
	[numberOfBorrowingBooks] [int] NOT NULL,
	[waitingTime] [int] NOT NULL,
	[returnBookDays] [int] NOT NULL,
	[maxWrongAttempts] [tinyint] NOT NULL,
	[resetWrongAttempts] [tinyint] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTryToLogin]    Script Date: 1.10.2022 17:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTryToLogin](
	[CPUid] [varchar](50) NOT NULL,
	[dateOfTry] [datetime] NOT NULL,
	[waitingTimeByHours] [tinyint] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUsers]    Script Date: 1.10.2022 17:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUsers](
	[u_id] [int] NOT NULL,
	[name] [varchar](25) NOT NULL,
	[surname] [varchar](25) NOT NULL,
	[phone] [varchar](20) NOT NULL,
	[mail] [varchar](40) NOT NULL,
	[birthDate] [date] NOT NULL,
	[gender] [bit] NOT NULL,
	[u_level] [tinyint] NOT NULL,
	[username] [varchar](25) NOT NULL,
	[password] [varchar](64) NOT NULL,
	[saltPassword] [varchar](36) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[tblCategories] ([c_id], [name]) VALUES (1, N'Unknown')
GO
INSERT [dbo].[tblSettings] ([numberOfBorrowingBooks], [waitingTime], [returnBookDays], [maxWrongAttempts], [resetWrongAttempts]) VALUES (5, 24, 7, 4, 3)
GO
INSERT [dbo].[tblUsers] ([u_id], [name], [surname], [phone], [mail], [birthDate], [gender], [u_level], [username], [password], [saltPassword]) VALUES (1, N'Admin', N'Admin', N'(012) 345-6789', N'admin@gmail.com', CAST(N'1900-01-01' AS Date), 0, 1, N'admin', N'b9732f25efa383876f8cf7282f780f9a1961275f19d097b601e785d05ad7c752', N'ae2235cc-bada-4ffd-8f07-a004b1ff6f97')
GO
ALTER TABLE [dbo].[tblAuthors] ADD  CONSTRAINT [DF_tblAuthors_image]  DEFAULT ('https://secure.webtoolhub.com/static/resources/icons/set112/261419af.png') FOR [image]
GO
ALTER TABLE [dbo].[tblBooks] ADD  CONSTRAINT [DF_tblBooks_image]  DEFAULT ('https://www.iconpacks.net/icons/2/free-opened-book-icon-3163-thumb.png') FOR [image]
GO
