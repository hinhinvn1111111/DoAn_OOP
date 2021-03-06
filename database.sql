USE [hihi]
GO
/****** Object:  UserDefinedFunction [dbo].[isExist]    Script Date: 12/23/2018 10:43:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[isExist](@SBD nvarchar(8))
RETURNS int
AS
BEGIN
	if exists (select * from ThiSinh where ThiSinh.SBD = @SBD)
	BEGIN
		return 1
	END
	else
	BEGIN
		return 0
	END
	return -1
END
GO
/****** Object:  Table [dbo].[Checked]    Script Date: 12/23/2018 10:43:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Checked](
	[checked] [nvarchar](100) NULL,
	[usn] [nvarchar](100) NULL,
	[pw] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DiemChuan]    Script Date: 12/23/2018 10:43:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiemChuan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Truong] [int] NOT NULL,
	[ID_Nam] [int] NOT NULL,
	[ID_Nganh] [int] NOT NULL,
	[Khoi] [nvarchar](100) NULL,
	[Diem] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DiemSan]    Script Date: 12/23/2018 10:43:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiemSan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Truong] [int] NOT NULL,
	[ID_Nam] [int] NOT NULL,
	[Diem] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DiemThi]    Script Date: 12/23/2018 10:43:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiemThi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SBD] [nvarchar](8) NOT NULL,
	[ID_Mon] [int] NOT NULL,
	[Diem] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 12/23/2018 10:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[usn] [nvarchar](100) NULL,
	[pw] [nvarchar](100) NULL,
	[ID_Role] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonThi]    Script Date: 12/23/2018 10:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonThi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenMon] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NamTuyenSinh]    Script Date: 12/23/2018 10:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NamTuyenSinh](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nam] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nganh]    Script Date: 12/23/2018 10:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nganh](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenNganh] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 12/23/2018 10:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Role_Name] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThiSinh]    Script Date: 12/23/2018 10:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThiSinh](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[SBD] [nvarchar](8) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SBD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Truong]    Script Date: 12/23/2018 10:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Truong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenTruong] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DiemChuan]  WITH CHECK ADD FOREIGN KEY([ID_Nam])
REFERENCES [dbo].[NamTuyenSinh] ([ID])
GO
ALTER TABLE [dbo].[DiemChuan]  WITH CHECK ADD FOREIGN KEY([ID_Nganh])
REFERENCES [dbo].[Nganh] ([ID])
GO
ALTER TABLE [dbo].[DiemChuan]  WITH CHECK ADD FOREIGN KEY([ID_Truong])
REFERENCES [dbo].[Truong] ([ID])
GO
ALTER TABLE [dbo].[DiemSan]  WITH CHECK ADD FOREIGN KEY([ID_Nam])
REFERENCES [dbo].[NamTuyenSinh] ([ID])
GO
ALTER TABLE [dbo].[DiemSan]  WITH CHECK ADD FOREIGN KEY([ID_Truong])
REFERENCES [dbo].[Truong] ([ID])
GO
ALTER TABLE [dbo].[DiemThi]  WITH CHECK ADD FOREIGN KEY([ID_Mon])
REFERENCES [dbo].[MonThi] ([ID])
GO
ALTER TABLE [dbo].[DiemThi]  WITH CHECK ADD  CONSTRAINT [FK__DiemThi__SBD__403A8C7D] FOREIGN KEY([SBD])
REFERENCES [dbo].[ThiSinh] ([SBD])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DiemThi] CHECK CONSTRAINT [FK__DiemThi__SBD__403A8C7D]
GO
ALTER TABLE [dbo].[Login]  WITH CHECK ADD FOREIGN KEY([ID_Role])
REFERENCES [dbo].[Role] ([ID])
GO
/****** Object:  StoredProcedure [dbo].[diemthiall]    Script Date: 12/23/2018 10:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[diemthiall]
as
begin
	select * from DiemThi
end
GO
/****** Object:  StoredProcedure [dbo].[TraDiemChuan]    Script Date: 12/23/2018 10:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TraDiemChuan]
@ID_Truong int
AS
BEGIN
	if exists (select * from Truong where Truong.ID = @ID_Truong)
	BEGIN
		select TenNganh, DiemChuan.Diem
		from Truong inner join DiemChuan on Truong.ID = DiemChuan.ID_Truong inner join Nganh on DiemChuan.ID_Nganh = Nganh.ID
		where Truong.ID = @ID_Truong
	END
END
GO
/****** Object:  StoredProcedure [dbo].[TraDiemDia]    Script Date: 12/23/2018 10:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TraDiemDia]
@SBD nvarchar(8)
AS
BEGIN
	if exists (select * from ThiSinh where ThiSinh.SBD = @SBD)
	Begin
		select DiemThi.Diem
		from DiemThi inner join MonThi on DiemThi.ID_Mon = MonThi.ID
		where DiemThi.SBD = @SBD and DiemThi.ID_Mon = 6
	end
END
GO
/****** Object:  StoredProcedure [dbo].[TraDiemGDCD]    Script Date: 12/23/2018 10:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TraDiemGDCD]
@SBD nvarchar(8)
AS
BEGIN
	if exists (select * from ThiSinh where ThiSinh.SBD = @SBD)
	Begin
		select DiemThi.Diem
		from DiemThi inner join MonThi on DiemThi.ID_Mon = MonThi.ID
		where DiemThi.SBD = @SBD and DiemThi.ID_Mon = 9
	end
END
GO
/****** Object:  StoredProcedure [dbo].[TraDiemHoa]    Script Date: 12/23/2018 10:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TraDiemHoa]
@SBD nvarchar(8)
AS
BEGIN
	if exists (select * from ThiSinh where ThiSinh.SBD = @SBD)
	Begin
		select DiemThi.Diem
		from DiemThi inner join MonThi on DiemThi.ID_Mon = MonThi.ID
		where DiemThi.SBD = @SBD and DiemThi.ID_Mon = 3
	end
END
GO
/****** Object:  StoredProcedure [dbo].[TraDiemLy]    Script Date: 12/23/2018 10:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TraDiemLy]
@SBD nvarchar(8)
AS
BEGIN
	if exists (select * from ThiSinh where ThiSinh.SBD = @SBD)
	Begin
		select DiemThi.Diem
		from DiemThi inner join MonThi on DiemThi.ID_Mon = MonThi.ID
		where DiemThi.SBD = @SBD and DiemThi.ID_Mon = 2
	end
END
GO
/****** Object:  StoredProcedure [dbo].[TraDiemNgoaiNgu]    Script Date: 12/23/2018 10:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TraDiemNgoaiNgu]
@SBD nvarchar(8)
AS
BEGIN
	if exists (select * from ThiSinh where ThiSinh.SBD = @SBD)
	Begin
		select DiemThi.Diem
		from DiemThi inner join MonThi on DiemThi.ID_Mon = MonThi.ID
		where DiemThi.SBD = @SBD and DiemThi.ID_Mon = 8
	end
END
GO
/****** Object:  StoredProcedure [dbo].[TraDiemNguVan]    Script Date: 12/23/2018 10:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TraDiemNguVan]
@SBD nvarchar(8)
AS
BEGIN
	if exists (select * from ThiSinh where ThiSinh.SBD = @SBD)
	Begin
		select DiemThi.Diem
		from DiemThi inner join MonThi on DiemThi.ID_Mon = MonThi.ID
		where DiemThi.SBD = @SBD and DiemThi.ID_Mon = 7
	end
END
GO
/****** Object:  StoredProcedure [dbo].[TraDiemSinh]    Script Date: 12/23/2018 10:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TraDiemSinh]
@SBD nvarchar(8)
AS
BEGIN
	if exists (select * from ThiSinh where ThiSinh.SBD = @SBD)
	Begin
		select DiemThi.Diem
		from DiemThi inner join MonThi on DiemThi.ID_Mon = MonThi.ID
		where DiemThi.SBD = @SBD and DiemThi.ID_Mon = 4
	end
END
GO
/****** Object:  StoredProcedure [dbo].[TraDiemSu]    Script Date: 12/23/2018 10:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TraDiemSu]
@SBD nvarchar(8)
AS
BEGIN
	if exists (select * from ThiSinh where ThiSinh.SBD = @SBD)
	Begin
		select DiemThi.Diem
		from DiemThi inner join MonThi on DiemThi.ID_Mon = MonThi.ID
		where DiemThi.SBD = @SBD and DiemThi.ID_Mon = 5
	end
END
GO
/****** Object:  StoredProcedure [dbo].[TraDiemThi]    Script Date: 12/23/2018 10:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TraDiemThi]
@SBD nvarchar(8)
AS
BEGIN
	if exists (select * from ThiSinh where ThiSinh.SBD = @SBD)
	Begin
		select TenMon, DiemThi.Diem
		from DiemThi inner join MonThi on DiemThi.ID_Mon = MonThi.ID
		where DiemThi.SBD = @SBD
	end
END
GO
/****** Object:  StoredProcedure [dbo].[TraDiemToan]    Script Date: 12/23/2018 10:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TraDiemToan]
@SBD nvarchar(8)
AS
BEGIN
	if exists (select * from ThiSinh where ThiSinh.SBD = @SBD)
	Begin
		select DiemThi.Diem
		from DiemThi inner join MonThi on DiemThi.ID_Mon = MonThi.ID
		where DiemThi.SBD = @SBD and DiemThi.ID_Mon = 1
	end
END
GO
