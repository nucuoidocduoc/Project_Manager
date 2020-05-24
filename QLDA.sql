-------------------------
--Author: Đinh Thị Như Ngọc
--Create Date: 20/05/2020
--Description: SQL truy xuất báo cáo phần mềm quản lý dự án
-------------------------

USE QLDA
GO
-------------

--DANH SÁCH DỰ ÁN ĐANG THỰC HIỆN 
IF OBJECT_ID('Tempdb..##BangDA') IS NOT NULL DROP TABLE ##BangDA
CREATE TABLE ##BangDA
(
	STT INT,
	Ma_DA NVARCHAR(10),
	Dien_Giai NVARCHAR(1000),
	Dia_Diem NVARCHAR(100),
	Thoi_Gian_BD DATETIME,
	Thoi_Gian_KT DATETIME,
	Thoi_Gian_KT_TT DATETIME,
	Ma_KH INT,
	Trang_Thai NVARCHAR(50)
)
-- Thêm dữ liệu đã lọc theo ngày tháng
DECLARE @_TuNgay DATETIME, @_DenNgay DATETIME
SET @_TuNgay = '01/01/2019'
SET	@_DenNgay = '05/20/2020'
INSERT INTO ##BangDA(STT, Ma_DA, Dien_Giai, Dia_Diem, Thoi_Gian_BD, Thoi_Gian_KT, Thoi_Gian_KT_TT, Ma_KH, Trang_Thai)
SELECT	1 AS STT, N'DA-' + CAST(Ma_DA AS NVARCHAR), Du_An.Ten,
			Dia_Diem, Thoi_Gian_BD,Thoi_Gian_KT, Thoi_Gian_KT_TT, Ma_KH, Trang_Thai
FROM Du_An 
WHERE ((Thoi_Gian_BD < @_TuNgay AND Thoi_Gian_KT_TT >= @_TuNgay AND Thoi_Gian_KT_TT <= @_DenNgay) 
    OR (Thoi_Gian_BD >= @_TuNgay AND Thoi_Gian_KT > @_TuNgay))
	AND (Trang_Thai = N'Đang thực hiện' OR Trang_Thai = N'Đã hoàn thành')
--select * from #BangDA

--Tạo bảng tạm báo cáo dự án đang thực hiện
IF OBJECT_ID('Tempdb..##ReportDA') IS NOT NULL DROP TABLE ##ReportDA
SELECT  ROW_NUMBER() OVER( PARTITION BY Ma_KH ORDER BY Thoi_Gian_BD) as STT, Ma_DA, Dien_Giai, 
		Dia_Diem, Thoi_Gian_BD, Thoi_Gian_KT, Thoi_Gian_KT_TT, Ma_KH
INTO ##ReportDA
FROM ##BangDA
UNION ALL
SELECT NULL, NULL, N'CDT-' + CAST(t1.Ma_KH AS NVARCHAR) + ': ' + Khach_Hang.Ten, NULL, NULL, NULL, NULL, t1.Ma_KH
FROM Khach_Hang INNER JOIN ##BangDA t1 ON Khach_Hang.Ma_KH = t1.Ma_KH
GROUP BY t1.Ma_KH, Khach_Hang.Ten
ORDER BY Ma_KH, STT
--select * from #ReportDA

--Xuất dữ liệu
SELECT  STT, Ma_DA AS N'Mã dự án', Dien_Giai AS N'Diễn giải', 
		Dia_Diem AS N'Địa điểm', Thoi_Gian_BD AS N'Thời gian bắt đầu', 
		Thoi_Gian_KT AS N'Thời gian kết thúc'--, Thoi_Gian_KT_TT AS N'Thời gian kết thúc thực tế'
FROM ##ReportDA
GO
--------------------------------------------------------------------------------------------------------------

--DANH SÁCH HỢP ĐỒNG ĐANG THỰC HIỆN
IF OBJECT_ID('Tempdb..#BangHD') IS NOT NULL DROP TABLE #BangHD
CREATE TABLE #BangHD
(
	STT INT,
	Ngay DATETIME,
	Ma_HD NVARCHAR(10),
	Dien_Giai NVARCHAR(1000),
	Gia_Tri NUMERIC(18,0),
	Da_Thanh_Toan NUMERIC(18,0),
    Con_No NUMERIC(18,0),
	Ma_DA INT,
	Thoi_Gian_KT DATETIME,
	Trang_Thai NVARCHAR(70),
	Ma_KH INT
)
-- Thêm dữ liệu đã lọc theo ngày tháng
DECLARE @_TuNgay1 DATETIME, @_DenNgay1 DATETIME
SET @_TuNgay1 = '01/01/2020'
SET	@_DenNgay1 = '05/20/2020'
INSERT INTO #BangHD(STT, Ngay, Ma_HD, Dien_Giai, Gia_Tri, Da_Thanh_Toan, Con_No, Ma_DA, Thoi_Gian_KT, Trang_Thai, Ma_KH)
SELECT	1 AS STT, t1.Thoi_Diem_Ky, N'HD-' + CAST(t1.Ma_HD AS NVARCHAR), t1.Ten, SUM(CAST(t1.Tong_Gia_Tri AS NUMERIC(18,0))),
		SUM(CAST(t2.So_Tien AS NUMERIC(18,0))), SUM(CAST(t1.Tong_Gia_Tri AS NUMERIC(18,0))) - SUM(CAST(t2.So_Tien AS NUMERIC(18,0))),
		t1.Ma_DA, t1.Thoi_Gian_KT, t1.Trang_Thai, Du_An.Ma_KH
FROM Hop_Dong t1 INNER JOIN TT_Thanh_Toan t2 ON t1.Ma_HD = t2.Ma_HD
                 INNER JOIN Du_An ON t1.Ma_DA = Du_An.Ma_DA
WHERE ((t1.Thoi_Diem_Ky < @_TuNgay1 AND Thoi_Gian_TT >= @_TuNgay1 AND Thoi_Gian_TT <= @_DenNgay1) 
   OR (t1.Thoi_Diem_Ky >= @_TuNgay1 AND t1.Thoi_Gian_KT > @_TuNgay1))
   AND (t1.Trang_Thai IN (N'Đang thực hiện', N'Đã hoàn thành'))
GROUP BY t1.Ma_HD, t1.Ma_DA, t1.Ten, t1.Trang_Thai, t1.Thoi_Diem_Ky, t1.Thoi_Gian_KT, Du_An.Ma_KH
--select * from #BangHD

--Tạo bảng tạm báo cáo hợp đồng đang thực hiện
IF OBJECT_ID('Tempdb..#ReportDA') IS NOT NULL DROP TABLE #ReportHD
SELECT  ROW_NUMBER() OVER( PARTITION BY Ma_KH ORDER BY Ngay) as STT, Ngay, Ma_HD, Dien_Giai, 
		Gia_Tri, Da_Thanh_Toan, Con_No, Thoi_Gian_KT, Trang_Thai, Ma_KH
INTO #ReportHD
FROM #BangHD
UNION ALL
SELECT NULL, NULL, NULL, N'CDT-' + CAST(t1.Ma_KH AS NVARCHAR) + ': ' + Khach_Hang.Ten,
		SUM(t1.Gia_Tri), SUM(t1.Da_Thanh_Toan), SUM(t1.Con_No), NULL, NULL, T1.Ma_KH
FROM #BangHD t1 INNER JOIN Khach_Hang ON t1.Ma_KH = Khach_Hang.Ma_KH		
GROUP BY t1.Ma_KH, Khach_Hang.Ten
ORDER BY Ma_KH, STT
--select * from #ReportHD

--Xuất dữ liệu
SELECT STT, Ngay AS N'Ngày', Ma_HD AS N'Mã hợp đồng', Dien_Giai AS N'Diễn giải', Gia_Tri AS N'Giá trị',
		Da_Thanh_Toan AS N'Đã thanh toán', Con_No AS N'Còn nợ'
From #ReportHD	
GO

-----------------------------------------------------------------------------------------------------
--BÁO CÁO DOANH THU
--Bảng liệt kê tất cả thanh toán- k tính tổng
IF OBJECT_ID('Tempdb..#BangDT') IS NOT NULL DROP TABLE #BangDT
CREATE TABLE #BangDT
(
	STT INT,
	Nguon_DT NVARCHAR(1000),
	Gia_Tri NUMERIC(18,0),
	Ma_KH INT
)
DECLARE @_TuNgay2 DATETIME, @_DenNgay2 DATETIME
SET @_TuNgay2 = '01/01/2020'
SET	@_DenNgay2= '05/20/2020'
INSERT INTO #BangDT(STT, Nguon_DT, Gia_Tri, Ma_KH)
SELECT	NULL, Khach_Hang.Ten, SUM(CAST(TT_Thanh_Toan.So_Tien AS NUMERIC(18,0))), Khach_Hang.Ma_KH
FROM Khach_Hang INNER JOIN Du_An ON Khach_Hang.Ma_KH = Du_An.Ma_KH
				INNER JOIN Hop_Dong ON Du_An.Ma_DA = Hop_Dong.Ma_DA
				INNER JOIN TT_Thanh_Toan ON Hop_Dong.Ma_HD = TT_Thanh_Toan.Ma_HD
WHERE (TT_Thanh_Toan.Thoi_Gian_TT BETWEEN @_TuNgay2 AND @_DenNgay2)
GROUP BY Khach_Hang.Ma_KH, Khach_Hang.Ten  
--select * from #BangDT

SELECT ROW_NUMBER() OVER( ORDER BY Gia_Tri DESC) as STT, Nguon_DT AS N'Nguồn doanh thu', Gia_Tri AS N'Giá trị'
FROM #BangDT 
GO

-----------------------------------------------------------------------------------------------------------------
--BÁO CÁO CÔNG VIỆC 

IF OBJECT_ID('Tempdb..#BangCV') IS NOT NULL DROP TABLE #BangCV
CREATE TABLE #BangCV
(
	STT INT,
	Ma_DA NVARCHAR(10),
	Dien_Giai NVARCHAR(1000),
	Nguoi_Giao NVARCHAR(100),
	Thoi_Gian_BD DATETIME,
	Thoi_Gian_KT DATETIME,
	Ma_NV INT,
	Trang_Thai NVARCHAR(50)
)
-- Thêm dữ liệu đã lọc theo ngày tháng
DECLARE @_TuNgay3 DATETIME, @_DenNgay3 DATETIME
SET @_TuNgay3 = '01/01/2020'
SET	@_DenNgay3 = '05/20/2020'
INSERT INTO #BangCV(STT, Ma_DA, Dien_Giai, Nguoi_Giao, Thoi_Gian_BD, Thoi_Gian_KT, Ma_NV, Trang_Thai)
SELECT 1 AS STT, N'DA-' + CAST(t2.Ma_DA AS NVARCHAR), t1.Ten, t2.Ten, t1.Thoi_Gian_Giao, t1.Thoi_Gian_HH, t1.Ma_NV, t1.Trang_Thai		
FROM Cong_Viec t1 INNER JOIN Quy_Trinh t2 ON t1.Ma_QT = t2.Ma_QT
				  INNER JOIN Du_An ON t2.Ma_DA = Du_An.Ma_DA
WHERE ((Thoi_Gian_Giao < @_TuNgay3 AND Thoi_Gian_HH >= @_TuNgay3 AND Thoi_Gian_HH <= @_DenNgay3) 
    OR (Thoi_Gian_Giao >= @_TuNgay3 AND Thoi_Gian_HH > @_TuNgay3))
--select * from #BangCV

--Tạo bảng tạm báo cáo công việc 
IF OBJECT_ID('Tempdb..#ReportCV') IS NOT NULL DROP TABLE #ReportCV
SELECT  ROW_NUMBER() OVER( PARTITION BY Ma_NV ORDER BY Thoi_Gian_BD) as STT, Ma_DA,
		Dien_Giai, Nguoi_Giao, Thoi_Gian_BD, Thoi_Gian_KT, Ma_NV, Trang_Thai
INTO #ReportCV
FROM #BangCV
UNION ALL
SELECT NULL, NULL, N'NV-' + CAST(t1.Ma_NV AS NVARCHAR) + ': ' + Nhan_Vien.Ten, NULL, NULL, NULL, t1.Ma_NV, NULL
FROM #BangCV t1 INNER JOIN Nhan_Vien ON t1.Ma_NV = Nhan_Vien.Ma_NV		
GROUP BY t1.Ma_NV, Nhan_Vien.Ten
ORDER BY Ma_NV, STT
--select * from #ReportCV

--Xuất dữ liệu
SELECT  STT, Ma_DA AS N'Mã dự án', Dien_Giai AS N'Diễn giải', Nguoi_Giao AS N'Người giao',
		Thoi_Gian_BD AS N'Thời gian bắt đầu', Thoi_Gian_KT AS N'Thời gian kết thúc'
FROM #ReportCV
GO
