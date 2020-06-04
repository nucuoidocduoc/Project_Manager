USE QLDA
GO

IF OBJECT_ID('Tempdb..##Temp') IS NOT NULL DROP TABLE ##Temp
CREATE TABLE ##Temp
(
	STT INT,
	Ma NVARCHAR(100),
	Ten NVARCHAR(200),
	Ngay DATE,
	Trang_Thai NVARCHAR(50)
)
INSERT INTO ##Temp(STT, Ma, Ten, Ngay, Trang_Thai)
SELECT  1 AS STT,
N'DA-' + CAST(Ma_DA AS NVARCHAR), Du_An.Ten,
		CASE WHEN Trang_Thai = N'Đang thực hiện' THEN Thoi_Gian_BD 
		 WHEN Trang_Thai = N'Đã hoàn thành' THEN Thoi_Gian_KT_TT ELSE NULL END,
				 Trang_Thai
FROM Du_An 
WHERE Trang_Thai NOT IN (N'Đang đấu thầu', N'Đang tạm hoãn')
--SELECT * FROM quy_trinh

INSERT INTO ##Temp(STT, Ma, Ten, Ngay, Trang_Thai)
SELECT  2 AS STT,
N'HD-' + CAST(Ma_HD AS NVARCHAR), Hop_Dong.Ten,
		CASE WHEN Trang_Thai = N'Đang thực hiện' THEN Thoi_Diem_Ky 
		 WHEN Trang_Thai = N'Đã hoàn thành' THEN Thoi_Gian_KT ELSE NULL END,
				 Trang_Thai
FROM Hop_Dong
WHERE Trang_Thai NOT IN ( N'Đang tạm hoãn')

INSERT INTO ##Temp(STT, Ma, Ten, Ngay, Trang_Thai)
SELECT 3 AS STT,
N'QT-' + CAST(Ma_QT AS NVARCHAR), Quy_Trinh.Ten,
		CASE WHEN Trang_Thai = N'Đang thực hiện' THEN Thoi_Gian_BD 
		WHEN Trang_Thai = N'Đã xong' THEN Thoi_Gian_KT ELSE NULL END,
				 Trang_Thai
FROM Quy_Trinh
WHERE Trang_Thai NOT IN (N'Chưa thực hiện')
--SELECT * FROM ##Temp

SELECT DISTINCT ISNULL(CASE WHEN ABS(DATEDIFF(DD, Ngay, GETDATE())) <= 7
						THEN CASE WHEN Trang_Thai = N'Đang thực hiện' THEN Ma + N': '+ Ten + N' sắp thực hiện vào ngày ' + CONVERT(NVARCHAR, Ngay, 105)
									WHEN Trang_Thai = N'Đã hoàn thành' THEN Ma + N': '+ Ten + N' sắp kết thúc vào ngày ' + CONVERT(NVARCHAR, Ngay, 105)
						ELSE Ma + N' '+ Ten + N' sắp kết thúc vào ngày ' + CONVERT(NVARCHAR, Ngay, 105) END
			END, (SELECT N'Tổng số tin: '+ CAST(COUNT(CASE WHEN ABS(DATEDIFF(DD, Ngay, GETDATE())) <= 7
					THEN CASE WHEN Trang_Thai = N'Đang thực hiện' THEN Ma + N': '+ Ten + N' sắp thực hiện vào ngày ' + CONVERT(NVARCHAR, Ngay, 105)
									WHEN Trang_Thai = N'Đã hoàn thành' THEN Ma + N': '+ Ten + N' sắp kết thúc vào ngày ' + CONVERT(NVARCHAR, Ngay, 105)
					ELSE Ma + N' '+ Ten + N' sắp kết thúc vào ngày ' + CONVERT(NVARCHAR, Ngay, 105) END
					END) AS NVARCHAR(50))  FROM ##Temp))  AS ThongTin
FROM ##Temp

