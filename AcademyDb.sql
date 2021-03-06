USE [master]
GO
/****** Object:  Database [Academy]    Script Date: 30.09.2019 19:58:16 ******/
CREATE DATABASE [Academy]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Academy', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Academy.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Academy_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Academy_log.ldf' , SIZE = 1088KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Academy] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Academy].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Academy] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Academy] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Academy] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Academy] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Academy] SET ARITHABORT OFF 
GO
ALTER DATABASE [Academy] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Academy] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Academy] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Academy] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Academy] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Academy] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Academy] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Academy] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Academy] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Academy] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Academy] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Academy] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Academy] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Academy] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Academy] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Academy] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Academy] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Academy] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Academy] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Academy] SET  MULTI_USER 
GO
ALTER DATABASE [Academy] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Academy] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Academy] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Academy] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Academy', N'ON'
GO
USE [Academy]
GO
/****** Object:  Table [dbo].[Answers]    Script Date: 30.09.2019 19:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Answers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[QuestionId] [int] NOT NULL,
	[AnswerText] [nvarchar](255) NOT NULL,
	[Correct] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Exams]    Script Date: 30.09.2019 19:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exams](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Date] [datetime] NOT NULL,
	[SubjectId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Groups]    Script Date: 30.09.2019 19:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Groups](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Marks]    Script Date: 30.09.2019 19:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [int] NOT NULL,
	[ExamId] [int] NOT NULL,
	[SubjectId] [int] NOT NULL,
	[Mark] [int] NULL,
	[Pass] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Questions]    Script Date: 30.09.2019 19:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Questions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[SubjectId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[REQ]    Script Date: 30.09.2019 19:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[REQ](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ExamId] [int] NOT NULL,
	[QuestionId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Roles]    Script Date: 30.09.2019 19:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RSG]    Script Date: 30.09.2019 19:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RSG](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SubjectId] [int] NOT NULL,
	[GroupId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Student_Answer]    Script Date: 30.09.2019 19:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_Answer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[ExamId] [int] NOT NULL,
	[AnswerId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 30.09.2019 19:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NULL,
	[TeacherId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 30.09.2019 19:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[RoleId] [int] NOT NULL,
	[LName] [nvarchar](100) NULL,
	[FName] [nvarchar](100) NOT NULL,
	[Phone] [nvarchar](100) NOT NULL,
	[Date] [datetime] NOT NULL,
	[GroupId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Answers] ON 

INSERT [dbo].[Answers] ([Id], [QuestionId], [AnswerText], [Correct]) VALUES (1, 2, N'Мигель Сервантес', 0)
INSERT [dbo].[Answers] ([Id], [QuestionId], [AnswerText], [Correct]) VALUES (2, 2, N'Франсуа Рабле', 0)
INSERT [dbo].[Answers] ([Id], [QuestionId], [AnswerText], [Correct]) VALUES (3, 2, N'Уильям Шекспир', 1)
INSERT [dbo].[Answers] ([Id], [QuestionId], [AnswerText], [Correct]) VALUES (4, 2, N'Редьярд Киплинг', 0)
INSERT [dbo].[Answers] ([Id], [QuestionId], [AnswerText], [Correct]) VALUES (5, 3, N'Микеланджело', 0)
INSERT [dbo].[Answers] ([Id], [QuestionId], [AnswerText], [Correct]) VALUES (6, 3, N'Леонардо да Винчи', 1)
INSERT [dbo].[Answers] ([Id], [QuestionId], [AnswerText], [Correct]) VALUES (7, 3, N'Рафаэль де Санти', 0)
INSERT [dbo].[Answers] ([Id], [QuestionId], [AnswerText], [Correct]) VALUES (8, 3, N'Харменс ван Рейн Рембрандт', 0)
INSERT [dbo].[Answers] ([Id], [QuestionId], [AnswerText], [Correct]) VALUES (13, 4, N'Англия', 0)
INSERT [dbo].[Answers] ([Id], [QuestionId], [AnswerText], [Correct]) VALUES (14, 4, N'Испания', 0)
INSERT [dbo].[Answers] ([Id], [QuestionId], [AnswerText], [Correct]) VALUES (15, 4, N'Италия', 1)
INSERT [dbo].[Answers] ([Id], [QuestionId], [AnswerText], [Correct]) VALUES (16, 4, N'Германия', 0)
INSERT [dbo].[Answers] ([Id], [QuestionId], [AnswerText], [Correct]) VALUES (21, 6, N'Аид', 0)
INSERT [dbo].[Answers] ([Id], [QuestionId], [AnswerText], [Correct]) VALUES (22, 6, N'Гермес', 0)
INSERT [dbo].[Answers] ([Id], [QuestionId], [AnswerText], [Correct]) VALUES (23, 6, N'Посейдон', 1)
INSERT [dbo].[Answers] ([Id], [QuestionId], [AnswerText], [Correct]) VALUES (24, 6, N'Гефест', 0)
INSERT [dbo].[Answers] ([Id], [QuestionId], [AnswerText], [Correct]) VALUES (25, 7, N'Форум', 0)
INSERT [dbo].[Answers] ([Id], [QuestionId], [AnswerText], [Correct]) VALUES (26, 7, N'Пантеон', 1)
INSERT [dbo].[Answers] ([Id], [QuestionId], [AnswerText], [Correct]) VALUES (27, 7, N'Колизей', 0)
INSERT [dbo].[Answers] ([Id], [QuestionId], [AnswerText], [Correct]) VALUES (28, 7, N'Олимп', 0)
INSERT [dbo].[Answers] ([Id], [QuestionId], [AnswerText], [Correct]) VALUES (29, 8, N'Ясон', 0)
INSERT [dbo].[Answers] ([Id], [QuestionId], [AnswerText], [Correct]) VALUES (30, 8, N'Геракл', 0)
INSERT [dbo].[Answers] ([Id], [QuestionId], [AnswerText], [Correct]) VALUES (31, 8, N'Ахилл', 1)
INSERT [dbo].[Answers] ([Id], [QuestionId], [AnswerText], [Correct]) VALUES (32, 8, N'Одиссей', 0)
SET IDENTITY_INSERT [dbo].[Answers] OFF
SET IDENTITY_INSERT [dbo].[Exams] ON 

INSERT [dbo].[Exams] ([Id], [Name], [Date], [SubjectId]) VALUES (1, N'Art History', CAST(0x0000AADB0015A6F8 AS DateTime), 3)
INSERT [dbo].[Exams] ([Id], [Name], [Date], [SubjectId]) VALUES (8, N'Sculpture', CAST(0x0000AAE4013468BC AS DateTime), 3)
SET IDENTITY_INSERT [dbo].[Exams] OFF
SET IDENTITY_INSERT [dbo].[Groups] ON 

INSERT [dbo].[Groups] ([Id], [Name]) VALUES (4, N'Gryffindor')
INSERT [dbo].[Groups] ([Id], [Name]) VALUES (5, N'Slytherin')
SET IDENTITY_INSERT [dbo].[Groups] OFF
SET IDENTITY_INSERT [dbo].[Marks] ON 

INSERT [dbo].[Marks] ([Id], [StudentId], [ExamId], [SubjectId], [Mark], [Pass]) VALUES (1, 12, 1, 3, 100, N'Passed')
INSERT [dbo].[Marks] ([Id], [StudentId], [ExamId], [SubjectId], [Mark], [Pass]) VALUES (2, 11, 1, 3, 67, N'Passed')
SET IDENTITY_INSERT [dbo].[Marks] OFF
SET IDENTITY_INSERT [dbo].[Questions] ON 

INSERT [dbo].[Questions] ([Id], [Name], [SubjectId]) VALUES (2, N'Английский поэт и автор бессмертных творений "Ромео и Джульетта":', 3)
INSERT [dbo].[Questions] ([Id], [Name], [SubjectId]) VALUES (3, N'Автор знаменитой "Моны Лизы" ("Джоконда"):', 3)
INSERT [dbo].[Questions] ([Id], [Name], [SubjectId]) VALUES (4, N'Какая страна явилась родиной Возрождения:', 3)
INSERT [dbo].[Questions] ([Id], [Name], [SubjectId]) VALUES (6, N'Назовите имя бога – владыки морей:', 3)
INSERT [dbo].[Questions] ([Id], [Name], [SubjectId]) VALUES (7, N'Как иначе называется римский «храм всех богов»?', 3)
INSERT [dbo].[Questions] ([Id], [Name], [SubjectId]) VALUES (8, N'Герой Троянской войны, убивший Гектора из мести за своего друга Патрокла:', 3)
SET IDENTITY_INSERT [dbo].[Questions] OFF
SET IDENTITY_INSERT [dbo].[REQ] ON 

INSERT [dbo].[REQ] ([Id], [ExamId], [QuestionId]) VALUES (13, 1, 3)
INSERT [dbo].[REQ] ([Id], [ExamId], [QuestionId]) VALUES (16, 1, 4)
INSERT [dbo].[REQ] ([Id], [ExamId], [QuestionId]) VALUES (17, 1, 2)
INSERT [dbo].[REQ] ([Id], [ExamId], [QuestionId]) VALUES (18, 1, 6)
INSERT [dbo].[REQ] ([Id], [ExamId], [QuestionId]) VALUES (19, 1, 7)
INSERT [dbo].[REQ] ([Id], [ExamId], [QuestionId]) VALUES (20, 1, 8)
SET IDENTITY_INSERT [dbo].[REQ] OFF
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([Id], [Name]) VALUES (1, N'Admin')
INSERT [dbo].[Roles] ([Id], [Name]) VALUES (3, N'Student')
INSERT [dbo].[Roles] ([Id], [Name]) VALUES (2, N'Teacher')
SET IDENTITY_INSERT [dbo].[Roles] OFF
SET IDENTITY_INSERT [dbo].[RSG] ON 

INSERT [dbo].[RSG] ([Id], [SubjectId], [GroupId]) VALUES (5, 4, 5)
INSERT [dbo].[RSG] ([Id], [SubjectId], [GroupId]) VALUES (6, 3, 5)
INSERT [dbo].[RSG] ([Id], [SubjectId], [GroupId]) VALUES (7, 3, 4)
INSERT [dbo].[RSG] ([Id], [SubjectId], [GroupId]) VALUES (8, 11, 4)
SET IDENTITY_INSERT [dbo].[RSG] OFF
SET IDENTITY_INSERT [dbo].[Student_Answer] ON 

INSERT [dbo].[Student_Answer] ([Id], [UserId], [ExamId], [AnswerId]) VALUES (1, 12, 1, 6)
INSERT [dbo].[Student_Answer] ([Id], [UserId], [ExamId], [AnswerId]) VALUES (2, 12, 1, 15)
INSERT [dbo].[Student_Answer] ([Id], [UserId], [ExamId], [AnswerId]) VALUES (3, 12, 1, 3)
INSERT [dbo].[Student_Answer] ([Id], [UserId], [ExamId], [AnswerId]) VALUES (4, 12, 1, 23)
INSERT [dbo].[Student_Answer] ([Id], [UserId], [ExamId], [AnswerId]) VALUES (5, 12, 1, 26)
INSERT [dbo].[Student_Answer] ([Id], [UserId], [ExamId], [AnswerId]) VALUES (6, 12, 1, 31)
INSERT [dbo].[Student_Answer] ([Id], [UserId], [ExamId], [AnswerId]) VALUES (7, 11, 1, 6)
INSERT [dbo].[Student_Answer] ([Id], [UserId], [ExamId], [AnswerId]) VALUES (8, 11, 1, 16)
INSERT [dbo].[Student_Answer] ([Id], [UserId], [ExamId], [AnswerId]) VALUES (9, 11, 1, 3)
INSERT [dbo].[Student_Answer] ([Id], [UserId], [ExamId], [AnswerId]) VALUES (10, 11, 1, 23)
INSERT [dbo].[Student_Answer] ([Id], [UserId], [ExamId], [AnswerId]) VALUES (11, 11, 1, 26)
INSERT [dbo].[Student_Answer] ([Id], [UserId], [ExamId], [AnswerId]) VALUES (12, 11, 1, 32)
SET IDENTITY_INSERT [dbo].[Student_Answer] OFF
SET IDENTITY_INSERT [dbo].[Subjects] ON 

INSERT [dbo].[Subjects] ([Id], [Name], [TeacherId]) VALUES (3, N'Arts', 10)
INSERT [dbo].[Subjects] ([Id], [Name], [TeacherId]) VALUES (4, N'History', 9)
INSERT [dbo].[Subjects] ([Id], [Name], [TeacherId]) VALUES (11, N'Literature', 10)
SET IDENTITY_INSERT [dbo].[Subjects] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Login], [Password], [RoleId], [LName], [FName], [Phone], [Date], [GroupId]) VALUES (1, N'Admin', N'1234', 1, N'Human', N'Adam', N'+77052402589', CAST(0x0000AACE011D4B5C AS DateTime), NULL)
INSERT [dbo].[Users] ([Id], [Login], [Password], [RoleId], [LName], [FName], [Phone], [Date], [GroupId]) VALUES (2, N'Harry', N'Potter', 3, N'Potter', N'Harry', N'+7775649785', CAST(0x0000AACE01322544 AS DateTime), 4)
INSERT [dbo].[Users] ([Id], [Login], [Password], [RoleId], [LName], [FName], [Phone], [Date], [GroupId]) VALUES (9, N'Mark', N'1234', 2, N'Twain', N'Mark', N'+77054815218', CAST(0x0000AACE0150D4EA AS DateTime), NULL)
INSERT [dbo].[Users] ([Id], [Login], [Password], [RoleId], [LName], [FName], [Phone], [Date], [GroupId]) VALUES (10, N'Celine', N'1234', 2, N'Dion', N'Celine', N'+77021458563', CAST(0x0000AACE0151FAE5 AS DateTime), NULL)
INSERT [dbo].[Users] ([Id], [Login], [Password], [RoleId], [LName], [FName], [Phone], [Date], [GroupId]) VALUES (11, N'Thom', N'1234', 3, N'Yorke', N'Thom', N'+77052416359', CAST(0x0000AACE0152DDB3 AS DateTime), 5)
INSERT [dbo].[Users] ([Id], [Login], [Password], [RoleId], [LName], [FName], [Phone], [Date], [GroupId]) VALUES (12, N'Brian', N'Molko', 3, N'Molko', N'Brian', N'+7054896215', CAST(0x0000AACE01547123 AS DateTime), 5)
INSERT [dbo].[Users] ([Id], [Login], [Password], [RoleId], [LName], [FName], [Phone], [Date], [GroupId]) VALUES (15, N'Jay', N'1234', 3, N'Z', N'Jay', N'+77054895218', CAST(0x0000AAD5004D669E AS DateTime), 4)
INSERT [dbo].[Users] ([Id], [Login], [Password], [RoleId], [LName], [FName], [Phone], [Date], [GroupId]) VALUES (16, N'Rihanna', N'1234', 3, N'Riri', N'Rihanna', N'+70548156954', CAST(0x0000AAD80141159C AS DateTime), NULL)
INSERT [dbo].[Users] ([Id], [Login], [Password], [RoleId], [LName], [FName], [Phone], [Date], [GroupId]) VALUES (17, N'Hermione', N'1234', 3, N'Granger', N'Hermione', N'+77021584595', CAST(0x0000AAD80143E967 AS DateTime), 4)
SET IDENTITY_INSERT [dbo].[Users] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Groups__737584F6DB7279B7]    Script Date: 30.09.2019 19:58:16 ******/
ALTER TABLE [dbo].[Groups] ADD UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Roles__737584F6AA6686EF]    Script Date: 30.09.2019 19:58:16 ******/
ALTER TABLE [dbo].[Roles] ADD UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Users__5E55825B93FF8A69]    Script Date: 30.09.2019 19:58:16 ******/
ALTER TABLE [dbo].[Users] ADD UNIQUE NONCLUSTERED 
(
	[Login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Answers] ADD  CONSTRAINT [DF_Answers_Correct]  DEFAULT ((0)) FOR [Correct]
GO
ALTER TABLE [dbo].[Exams] ADD  CONSTRAINT [DF_Exams_Date]  DEFAULT (getdate()) FOR [Date]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (getdate()) FOR [Date]
GO
ALTER TABLE [dbo].[Answers]  WITH CHECK ADD FOREIGN KEY([QuestionId])
REFERENCES [dbo].[Questions] ([Id])
GO
ALTER TABLE [dbo].[Answers]  WITH CHECK ADD  CONSTRAINT [FK_QuestionId_Answer] FOREIGN KEY([QuestionId])
REFERENCES [dbo].[Questions] ([Id])
GO
ALTER TABLE [dbo].[Answers] CHECK CONSTRAINT [FK_QuestionId_Answer]
GO
ALTER TABLE [dbo].[Exams]  WITH CHECK ADD FOREIGN KEY([SubjectId])
REFERENCES [dbo].[Subjects] ([Id])
GO
ALTER TABLE [dbo].[Marks]  WITH CHECK ADD FOREIGN KEY([ExamId])
REFERENCES [dbo].[Exams] ([Id])
GO
ALTER TABLE [dbo].[Marks]  WITH CHECK ADD FOREIGN KEY([StudentId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Marks]  WITH CHECK ADD FOREIGN KEY([SubjectId])
REFERENCES [dbo].[Subjects] ([Id])
GO
ALTER TABLE [dbo].[Questions]  WITH CHECK ADD FOREIGN KEY([SubjectId])
REFERENCES [dbo].[Subjects] ([Id])
GO
ALTER TABLE [dbo].[REQ]  WITH CHECK ADD FOREIGN KEY([ExamId])
REFERENCES [dbo].[Exams] ([Id])
GO
ALTER TABLE [dbo].[REQ]  WITH CHECK ADD FOREIGN KEY([QuestionId])
REFERENCES [dbo].[Questions] ([Id])
GO
ALTER TABLE [dbo].[RSG]  WITH CHECK ADD FOREIGN KEY([GroupId])
REFERENCES [dbo].[Groups] ([Id])
GO
ALTER TABLE [dbo].[RSG]  WITH CHECK ADD FOREIGN KEY([SubjectId])
REFERENCES [dbo].[Subjects] ([Id])
GO
ALTER TABLE [dbo].[RSG]  WITH CHECK ADD  CONSTRAINT [FK_GROUP_RSG] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Groups] ([Id])
GO
ALTER TABLE [dbo].[RSG] CHECK CONSTRAINT [FK_GROUP_RSG]
GO
ALTER TABLE [dbo].[RSG]  WITH CHECK ADD  CONSTRAINT [FK_SUBJECT_RSG] FOREIGN KEY([SubjectId])
REFERENCES [dbo].[Subjects] ([Id])
GO
ALTER TABLE [dbo].[RSG] CHECK CONSTRAINT [FK_SUBJECT_RSG]
GO
ALTER TABLE [dbo].[Student_Answer]  WITH CHECK ADD FOREIGN KEY([AnswerId])
REFERENCES [dbo].[Answers] ([Id])
GO
ALTER TABLE [dbo].[Student_Answer]  WITH CHECK ADD FOREIGN KEY([AnswerId])
REFERENCES [dbo].[Answers] ([Id])
GO
ALTER TABLE [dbo].[Student_Answer]  WITH CHECK ADD FOREIGN KEY([ExamId])
REFERENCES [dbo].[Exams] ([Id])
GO
ALTER TABLE [dbo].[Student_Answer]  WITH CHECK ADD FOREIGN KEY([ExamId])
REFERENCES [dbo].[Exams] ([Id])
GO
ALTER TABLE [dbo].[Student_Answer]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Student_Answer]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Student_Answer]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Subjects]  WITH CHECK ADD FOREIGN KEY([TeacherId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD FOREIGN KEY([GroupId])
REFERENCES [dbo].[Groups] ([Id])
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([Id])
GO
USE [master]
GO
ALTER DATABASE [Academy] SET  READ_WRITE 
GO
