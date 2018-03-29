/*
Navicat SQL Server Data Transfer

Source Server         : sql
Source Server Version : 140000
Source Host           : :1433
Source Database       : 150603047
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 140000
File Encoding         : 65001

Date: 2018-03-29 22:31:18
*/


-- ----------------------------
-- Table structure for courseinfo
-- ----------------------------
DROP TABLE [dbo].[courseinfo]
GO
CREATE TABLE [dbo].[courseinfo] (
[CID] int NOT NULL IDENTITY(1,1) ,
[CName] nvarchar(50) NOT NULL ,
[CDate] nvarchar(50) NOT NULL ,
[CNum] nvarchar(50) NOT NULL ,
[MName] nvarchar(50) NOT NULL ,
[CRemark] nvarchar(50) NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[courseinfo]', RESEED, 13)
GO

-- ----------------------------
-- Records of courseinfo
-- ----------------------------
SET IDENTITY_INSERT [dbo].[courseinfo] ON
GO
INSERT INTO [dbo].[courseinfo] ([CID], [CName], [CDate], [CNum], [MName], [CRemark]) VALUES (N'2', N'网络基础', N'40', N'2', N'计算机网络', N'阶梯教室')
GO
GO
INSERT INTO [dbo].[courseinfo] ([CID], [CName], [CDate], [CNum], [MName], [CRemark]) VALUES (N'5', N'网页设计', N'54', N'3', N'计算机网络', N'')
GO
GO
INSERT INTO [dbo].[courseinfo] ([CID], [CName], [CDate], [CNum], [MName], [CRemark]) VALUES (N'6', N'程序设计', N'64', N'3', N'游戏软件', N'')
GO
GO
INSERT INTO [dbo].[courseinfo] ([CID], [CName], [CDate], [CNum], [MName], [CRemark]) VALUES (N'8', N'数据库管理', N'60', N'2', N'游戏软件', N'')
GO
GO
INSERT INTO [dbo].[courseinfo] ([CID], [CName], [CDate], [CNum], [MName], [CRemark]) VALUES (N'12', N'电路设计', N'60', N'2', N'物联网', null)
GO
GO
INSERT INTO [dbo].[courseinfo] ([CID], [CName], [CDate], [CNum], [MName], [CRemark]) VALUES (N'13', N'单片机开发', N'60', N'2', N'物联网', null)
GO
GO
SET IDENTITY_INSERT [dbo].[courseinfo] OFF
GO

-- ----------------------------
-- Table structure for majorinfo
-- ----------------------------
DROP TABLE [dbo].[majorinfo]
GO
CREATE TABLE [dbo].[majorinfo] (
[MName] nvarchar(50) NOT NULL ,
[MRemark] nvarchar(50) NULL ,
[MID] int NOT NULL IDENTITY(1,1) 
)


GO
DBCC CHECKIDENT(N'[dbo].[majorinfo]', RESEED, 14)
GO

-- ----------------------------
-- Records of majorinfo
-- ----------------------------
SET IDENTITY_INSERT [dbo].[majorinfo] ON
GO
INSERT INTO [dbo].[majorinfo] ([MName], [MRemark], [MID]) VALUES (N'计算机网络', N'计算机网络', N'1')
GO
GO
INSERT INTO [dbo].[majorinfo] ([MName], [MRemark], [MID]) VALUES (N'游戏软件', N'游戏软件', N'3')
GO
GO
INSERT INTO [dbo].[majorinfo] ([MName], [MRemark], [MID]) VALUES (N'物联网', N'物联网', N'14')
GO
GO
SET IDENTITY_INSERT [dbo].[majorinfo] OFF
GO

-- ----------------------------
-- Table structure for roles
-- ----------------------------
DROP TABLE [dbo].[roles]
GO
CREATE TABLE [dbo].[roles] (
[rid] int NOT NULL IDENTITY(1,1) ,
[RoleName] nvarchar(50) NOT NULL ,
[SystemManage] bit NOT NULL ,
[MajorManage] bit NOT NULL ,
[CourseManage] bit NOT NULL ,
[ScoreManage] bit NOT NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[roles]', RESEED, 4)
GO

-- ----------------------------
-- Records of roles
-- ----------------------------
SET IDENTITY_INSERT [dbo].[roles] ON
GO
INSERT INTO [dbo].[roles] ([rid], [RoleName], [SystemManage], [MajorManage], [CourseManage], [ScoreManage]) VALUES (N'1', N'教师', N'0', N'0', N'1', N'1')
GO
GO
INSERT INTO [dbo].[roles] ([rid], [RoleName], [SystemManage], [MajorManage], [CourseManage], [ScoreManage]) VALUES (N'2', N'普通管理员', N'0', N'1', N'1', N'1')
GO
GO
INSERT INTO [dbo].[roles] ([rid], [RoleName], [SystemManage], [MajorManage], [CourseManage], [ScoreManage]) VALUES (N'3', N'系统管理员', N'1', N'1', N'1', N'1')
GO
GO
INSERT INTO [dbo].[roles] ([rid], [RoleName], [SystemManage], [MajorManage], [CourseManage], [ScoreManage]) VALUES (N'4', N'学生', N'0', N'0', N'0', N'0')
GO
GO
SET IDENTITY_INSERT [dbo].[roles] OFF
GO

-- ----------------------------
-- Table structure for scoreinfo
-- ----------------------------
DROP TABLE [dbo].[scoreinfo]
GO
CREATE TABLE [dbo].[scoreinfo] (
[RID] int NOT NULL IDENTITY(1,1) ,
[SID] int NOT NULL ,
[CName] nvarchar(50) NOT NULL ,
[Score] nvarchar(50) NOT NULL 
)


GO

-- ----------------------------
-- Records of scoreinfo
-- ----------------------------
SET IDENTITY_INSERT [dbo].[scoreinfo] ON
GO
SET IDENTITY_INSERT [dbo].[scoreinfo] OFF
GO

-- ----------------------------
-- Table structure for studentinfo
-- ----------------------------
DROP TABLE [dbo].[studentinfo]
GO
CREATE TABLE [dbo].[studentinfo] (
[SID] int NOT NULL ,
[SName] nvarchar(50) NOT NULL ,
[SSex] nvarchar(50) NOT NULL ,
[SNum] nvarchar(50) NOT NULL ,
[SBirth] datetime NOT NULL ,
[TID] int NOT NULL ,
[MName] nvarchar(50) NOT NULL ,
[SRemark] nvarchar(50) NULL 
)


GO

-- ----------------------------
-- Records of studentinfo
-- ----------------------------
INSERT INTO [dbo].[studentinfo] ([SID], [SName], [SSex], [SNum], [SBirth], [TID], [MName], [SRemark]) VALUES (N'222', N'李四', N'女', N'3333', N'1995-04-03 00:00:00.000', N'1001', N'计算机网络', null)
GO
GO
INSERT INTO [dbo].[studentinfo] ([SID], [SName], [SSex], [SNum], [SBirth], [TID], [MName], [SRemark]) VALUES (N'1111', N'张三', N'女', N'3505', N'2015-05-05 00:00:00.000', N'1001', N'计算机网络', N'学生备注')
GO
GO
INSERT INTO [dbo].[studentinfo] ([SID], [SName], [SSex], [SNum], [SBirth], [TID], [MName], [SRemark]) VALUES (N'1223', N'罗峰', N'男', N'13562', N'2016-04-21 00:00:00.000', N'1001', N'游戏软件', N'')
GO
GO
INSERT INTO [dbo].[studentinfo] ([SID], [SName], [SSex], [SNum], [SBirth], [TID], [MName], [SRemark]) VALUES (N'1234', N'王五', N'男', N'12345', N'2016-04-04 00:00:00.000', N'1001', N'游戏软件', N'')
GO
GO
INSERT INTO [dbo].[studentinfo] ([SID], [SName], [SSex], [SNum], [SBirth], [TID], [MName], [SRemark]) VALUES (N'2001', N'董海', N'女', N'3713', N'2007-08-20 00:00:00.000', N'1002', N'物联网', N'')
GO
GO
INSERT INTO [dbo].[studentinfo] ([SID], [SName], [SSex], [SNum], [SBirth], [TID], [MName], [SRemark]) VALUES (N'2002', N'陈亘', N'女', N'371322', N'1983-08-20 00:00:00.000', N'1002', N'物联网', N'')
GO
GO

-- ----------------------------
-- Table structure for teacherinfo
-- ----------------------------
DROP TABLE [dbo].[teacherinfo]
GO
CREATE TABLE [dbo].[teacherinfo] (
[TID] int NOT NULL IDENTITY(1,1) ,
[TName] nvarchar(50) NOT NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[teacherinfo]', RESEED, 1002)
GO

-- ----------------------------
-- Records of teacherinfo
-- ----------------------------
SET IDENTITY_INSERT [dbo].[teacherinfo] ON
GO
INSERT INTO [dbo].[teacherinfo] ([TID], [TName]) VALUES (N'1001', N'陈坤')
GO
GO
INSERT INTO [dbo].[teacherinfo] ([TID], [TName]) VALUES (N'1002', N'浩明')
GO
GO
SET IDENTITY_INSERT [dbo].[teacherinfo] OFF
GO

-- ----------------------------
-- Table structure for userinfo
-- ----------------------------
DROP TABLE [dbo].[userinfo]
GO
CREATE TABLE [dbo].[userinfo] (
[UName] nvarchar(50) NOT NULL ,
[PWD] nvarchar(50) NOT NULL ,
[RoleName] nvarchar(50) NOT NULL 
)


GO

-- ----------------------------
-- Records of userinfo
-- ----------------------------
INSERT INTO [dbo].[userinfo] ([UName], [PWD], [RoleName]) VALUES (N'admin', N'admin', N'普通管理员')
GO
GO
INSERT INTO [dbo].[userinfo] ([UName], [PWD], [RoleName]) VALUES (N'qq330362495', N'330362495', N'系统管理员')
GO
GO
INSERT INTO [dbo].[userinfo] ([UName], [PWD], [RoleName]) VALUES (N's1111', N'1', N'学生')
GO
GO
INSERT INTO [dbo].[userinfo] ([UName], [PWD], [RoleName]) VALUES (N's2001', N'1', N'学生')
GO
GO
INSERT INTO [dbo].[userinfo] ([UName], [PWD], [RoleName]) VALUES (N's222', N'1', N'学生')
GO
GO
INSERT INTO [dbo].[userinfo] ([UName], [PWD], [RoleName]) VALUES (N't1001', N'1', N'教师')
GO
GO
INSERT INTO [dbo].[userinfo] ([UName], [PWD], [RoleName]) VALUES (N't1002', N'1', N'教师')
GO
GO
INSERT INTO [dbo].[userinfo] ([UName], [PWD], [RoleName]) VALUES (N'teacher', N'1', N'教师')
GO
GO

-- ----------------------------
-- Indexes structure for table courseinfo
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table courseinfo
-- ----------------------------
ALTER TABLE [dbo].[courseinfo] ADD PRIMARY KEY ([CID])
GO

-- ----------------------------
-- Indexes structure for table majorinfo
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table majorinfo
-- ----------------------------
ALTER TABLE [dbo].[majorinfo] ADD PRIMARY KEY ([MID])
GO

-- ----------------------------
-- Indexes structure for table roles
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table roles
-- ----------------------------
ALTER TABLE [dbo].[roles] ADD PRIMARY KEY ([rid])
GO

-- ----------------------------
-- Indexes structure for table scoreinfo
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table scoreinfo
-- ----------------------------
ALTER TABLE [dbo].[scoreinfo] ADD PRIMARY KEY ([RID])
GO

-- ----------------------------
-- Indexes structure for table studentinfo
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table studentinfo
-- ----------------------------
ALTER TABLE [dbo].[studentinfo] ADD PRIMARY KEY ([SID])
GO

-- ----------------------------
-- Indexes structure for table teacherinfo
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table teacherinfo
-- ----------------------------
ALTER TABLE [dbo].[teacherinfo] ADD PRIMARY KEY ([TID])
GO

-- ----------------------------
-- Indexes structure for table userinfo
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table userinfo
-- ----------------------------
ALTER TABLE [dbo].[userinfo] ADD PRIMARY KEY ([UName])
GO
