CREATE DATABASE QLNV;
GO
USE QLNV;
GO
CREATE TABLE PhongBan (
  MaPB CHAR(2) NOT NULL PRIMARY KEY,
  TenPB NVARCHAR(30)
)
GO
CREATE TABLE NhanVien (
  MaNV CHAR(6) NOT NULL PRIMARY KEY,
  TenNV NVARCHAR(20),
  NgaySinh VARCHAR(10),
  MaPB CHAR(2) NOT NULL FOREIGN KEY REFERENCES PhongBan(MaPB)
)
GO
ALTER TABLE NhanVien
ADD CONSTRAINT FK_NhanVien_PhongBan
FOREIGN KEY (MaPB) REFERENCES PhongBan (MaPB);
GO
INSERT INTO PhongBan (MaPB, TenPB) VALUES ('P1', N'Kế toán')
GO
INSERT INTO PhongBan (MaPB, TenPB) VALUES ('P2', N'Kinh doanh')
GO
INSERT INTO PhongBan (MaPB, TenPB) VALUES ('P3', N'Tuyển dụng')
GO
INSERT INTO PhongBan (MaPB, TenPB) VALUES ('P4', N'Điều hành')
GO
INSERT INTO PhongBan (MaPB, TenPB) VALUES ('P5', N'Kỹ thuật')
GO
INSERT INTO PhongBan (MaPB, TenPB) VALUES ('P6', N'Chăm sóc khách hàng')
GO
INSERT INTO NhanVien (MaNV, TenNV, NgaySinh, MaPB) VALUES ('NV01', N'Dương Khoa Nam', '11/11/2003', 'P1')
GO
INSERT INTO NhanVien (MaNV, TenNV, NgaySinh, MaPB) VALUES ('NV02', N'Trần Văn Toàn', '23/12/2003', 'P2')
GO
INSERT INTO NhanVien (MaNV, TenNV, NgaySinh, MaPB) VALUES ('NV03', N'Ngô Thái Hoàn', '11/11/2003', 'P3')
GO
INSERT INTO NhanVien (MaNV, TenNV, NgaySinh, MaPB) VALUES ('NV04', N'Phạm Huỳnh Ngọc Hiếu', '10/09/2003', 'P4')