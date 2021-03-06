USE [EFData]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 25.01.2022 10:48:28 ******/
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
/****** Object:  Table [dbo].[Students]    Script Date: 25.01.2022 10:48:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[StudentName] [nvarchar](50) NOT NULL,
	[StudentSurname] [nvarchar](50) NULL,
	[StudentAddress] [nvarchar](50) NULL,
	[StudentAge] [int] NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 25.01.2022 10:48:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[SubjectId] [int] IDENTITY(1,1) NOT NULL,
	[SubjectName] [nvarchar](max) NULL,
	[SubjectTerm] [nvarchar](max) NOT NULL,
	[SubjectCredets] [int] NOT NULL,
 CONSTRAINT [PK_Subjects] PRIMARY KEY CLUSTERED 
(
	[SubjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 25.01.2022 10:48:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[TeacherId] [int] IDENTITY(1,1) NOT NULL,
	[TeacherName] [nvarchar](max) NOT NULL,
	[TeacherAddress] [nvarchar](max) NOT NULL,
	[TeacherAge] [int] NOT NULL,
	[SubjectId] [int] NULL,
 CONSTRAINT [PK_Teachers] PRIMARY KEY CLUSTERED 
(
	[TeacherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220119090525_Independent', N'6.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220119091607_ManyToMany', N'6.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220119092649_ManyToOne', N'6.0.0')
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([StudentId], [StudentName], [StudentSurname], [StudentAddress], [StudentAge]) VALUES (1, N'emre', N'denli', N'asdac', 23)
INSERT [dbo].[Students] ([StudentId], [StudentName], [StudentSurname], [StudentAddress], [StudentAge]) VALUES (3, N'emre', N'denli', N'a', 3)
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
SET IDENTITY_INSERT [dbo].[Subjects] ON 

INSERT [dbo].[Subjects] ([SubjectId], [SubjectName], [SubjectTerm], [SubjectCredets]) VALUES (13, N'english', N'Fall', 6)
INSERT [dbo].[Subjects] ([SubjectId], [SubjectName], [SubjectTerm], [SubjectCredets]) VALUES (14, N'hasan', N'denli', 3)
INSERT [dbo].[Subjects] ([SubjectId], [SubjectName], [SubjectTerm], [SubjectCredets]) VALUES (15, N'eray', N'denli', 5)
SET IDENTITY_INSERT [dbo].[Subjects] OFF
GO
SET IDENTITY_INSERT [dbo].[Teachers] ON 

INSERT [dbo].[Teachers] ([TeacherId], [TeacherName], [TeacherAddress], [TeacherAge], [SubjectId]) VALUES (10, N'hasan', N'aa', 15, 14)
INSERT [dbo].[Teachers] ([TeacherId], [TeacherName], [TeacherAddress], [TeacherAge], [SubjectId]) VALUES (11, N'eray', N'asda', 18, 15)
INSERT [dbo].[Teachers] ([TeacherId], [TeacherName], [TeacherAddress], [TeacherAge], [SubjectId]) VALUES (12, N'emre', N'abc', 2, 0)
SET IDENTITY_INSERT [dbo].[Teachers] OFF
GO
