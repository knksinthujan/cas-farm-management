CREATE DATABASE FarmManagement;
GO
USE [FarmManagement]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 4/1/2025 1:47:34 pm ******/
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
/****** Object:  Table [dbo].[Fields]    Script Date: 4/1/2025 1:47:34 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fields](
	[Id] [uniqueidentifier] NOT NULL,
	[FieldName] [nvarchar](max) NOT NULL,
	[FieldArea] [float] NOT NULL,
	[CropName] [nvarchar](max) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[UpdatedBy] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Fields] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250104015935_Initial', N'9.0.0')
GO
INSERT [dbo].[Fields] ([Id], [FieldName], [FieldArea], [CropName], [IsDeleted], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate]) VALUES (N'b9f8ff87-1308-426f-8dca-13d34b09d727', N'Feild1', 45, N'Yams', 0, N'00000000-0000-0000-0000-000000000000', CAST(N'2025-01-04T13:33:41.4351937' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Fields] ([Id], [FieldName], [FieldArea], [CropName], [IsDeleted], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate]) VALUES (N'1f4b44c1-e61b-46f0-87ae-2152df15d0c7', N'Sinthu''s Dams', 78, N'Crop1', 0, N'00000000-0000-0000-0000-000000000000', CAST(N'2025-01-04T13:34:21.9546944' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Fields] ([Id], [FieldName], [FieldArea], [CropName], [IsDeleted], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate]) VALUES (N'72f8fa4b-4600-4f53-9e6d-2c05846e8ad0', N'Josh''s Dams', 45, N'Yams', 0, N'00000000-0000-0000-0000-000000000000', CAST(N'2025-01-04T13:31:43.1091744' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Fields] ([Id], [FieldName], [FieldArea], [CropName], [IsDeleted], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate]) VALUES (N'75759678-1727-40a4-9ffb-32feef504a26', N'Test3', 25, N'Crop name test3', 0, N'00000000-0000-0000-0000-000000000000', CAST(N'2025-01-04T12:03:33.6215234' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Fields] ([Id], [FieldName], [FieldArea], [CropName], [IsDeleted], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate]) VALUES (N'5c7ddb06-55c5-4680-aafc-3fd1276bbede', N'Test4', 15, N'Crop Test4', 0, N'00000000-0000-0000-0000-000000000000', CAST(N'2025-01-04T13:28:12.6519141' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Fields] ([Id], [FieldName], [FieldArea], [CropName], [IsDeleted], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate]) VALUES (N'f2ce9ccb-46cc-46c0-b289-7b5baa7a963d', N'Test2', 25.4554, N'Crop test2', 0, N'00000000-0000-0000-0000-000000000000', CAST(N'2025-01-04T12:00:58.4713026' AS DateTime2), NULL, NULL)
GO
INSERT [dbo].[Fields] ([Id], [FieldName], [FieldArea], [CropName], [IsDeleted], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate]) VALUES (N'800c909a-03a8-4f3a-87d0-fb2b021aea03', N'Test1', 10, N'Crop Test1', 0, N'00000000-0000-0000-0000-000000000000', CAST(N'2025-01-04T12:00:43.3804370' AS DateTime2), NULL, NULL)
GO
USE [master]
GO
ALTER DATABASE [FarmManagement] SET  READ_WRITE 
GO
