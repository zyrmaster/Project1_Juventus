
create database Project1_Juventus;
use Project1_Juventus;

CREATE TABLE Accounts (
    ID INT PRIMARY KEY,
	DisplayName varchar(255) NOT NULL,
    Username VARCHAR(255) NOT NULL,
    Password VARCHAR(255) NOT NULL,
    RoleID INT,
    FOREIGN KEY (RoleID) REFERENCES Roles(ID)
);
-- Chèn dữ liệu vào bảng "Accounts"
INSERT INTO Accounts (ID, DisplayName, Username, Password, RoleID) VALUES
(1, N'Quản Trị Phần Mềm', 'quantrivien', 'admin_password', 99),
(2, N'Quản Lý Cửa Hàng', 'phamtienduc', 'employee1_password', 1),
(3, N'Nhân Viên Chính Thức', 'nhanvien2', 'nhanvien2', 2),
(4, N'Nhân Viên Chính Thức', 'nhanvien3', 'nhanvien3', 2),
(5, N'Nhân Viên Học Việc', 'nhanvien4', 'nhanvien4', 2);

CREATE TABLE Roles (
	ID INT PRIMARY KEY,
	RoleName VARCHAR(255) NOT NULL
);
INSERT INTO Roles (ID, RoleName) VALUES
(99, N'Quản Trị Viên'),
(1, N'Quản Lý'),
(2, N'Nhân Viên');

CREATE TABLE Employees (
	ID INT PRIMARY KEY,
	EmployeeName VARCHAR(255) NOT NULL,
	Potision VARCHAR(255) NOT NULL,
	Salary VARCHAR(255) NOT NULL,
	AccountID INT,
	FOREIGN KEY (AccountID) REFERENCES Accounts(ID)
);
INSERT INTO Employees (ID, EmployeeName, Potision, Salary, AccountID) VALUES
(1, N'Phạm Tiến Đức', 'Quản Lý Cửa Hàng', '1000000', 2),
(2, N'Nguyễn Quang Long', 'Nhân Viên', '500000', 3),
(3, N'Phạm Tiến Đạt', 'Nhân Viên', '500000', 4),
(4, N'Vũ Yến Ngọc', 'Nhân Viên', '600000', 5);

CREATE TABLE Customers (
	ID INT PRIMARY KEY,
	CustomerName VARCHAR(255) NOT NULL,
	Phone VARCHAR(255) NOT NULL,
	Address VARCHAR(255) NOT NULL,
	Point int NOT NULL
);
INSERT INTO Customers (ID, CustomerName, Phone, Address, Point) VALUES
(1, N'Nguyễn Văn Lâm', '0912345678', N'123 Đường ABC, Quận 1, TP.HCM', 120),
(2, N'Trần Thị Thu', '0923456789', N'456 Đường XYZ, Quận 2, TP.HCM', 90),
(3, N'Lê Văn Hoàng', '0934567890', N'789 Đường LMN, Quận 3, TP.HCM', 150),
(4, N'Phạm Thị Thảo', '0945678901', N'456 Đường DEF, Quận 4, TP.HCM', 110),
(5, N'Hoàng Văn Đức', '0956789012', N'789 Đường GHI, Quận 5, TP.HCM', 80),
(6, N'Hà Khắc Xí', '03641826734', N'123 Đường ABC, Quận Hoàn Kiếm, Hà Nội', 120),
(7, N'Lê Thành Sau', '06513881509', N'456 Đường XYZ, Quận Hoàng Mai , Hà Nội', 90),
(8, N'Tạ Khắc Diệt', '05103863484', N'789 Đường LMN, Quận Nam Từ Liêm,Hà Nội', 150),
(9, N'Trần Thanh Thái', '05103863584', N'456 Đường DEF, Quận 4, TP.HCM', 110),
(10, N'Huỳnh Thắng Vang', '05103843484', N'789 Đường GHI, Quận 5, TP.HCM', 80);
CREATE TABLE Tables (
	ID INT PRIMARY KEY,
	Name VARCHAR(255) NOT NULL DEFAULT N'Chưa đặt tên',
	Slot INT NOT NULL,
	Status VARCHAR(255) NOT NULL
);
-- INSERT statements for the "Tables" table
INSERT INTO Tables (ID, Name, Slot, Status) VALUES
(1, N'Bàn 1', 4, N'Trống'),
(2, N'Bàn 2', 2, N'Trống'),
(3, N'Bàn 3', 6, N'Trống'),
(4, N'Bàn 4', 3, N'Trống'),
(5, N'Bàn 5', 5, N'Trống'),
(6, N'Bàn 6', 2, N'Trống'),
(7, N'Bàn 7', 4, N'Trống'),
(8, N'Bàn 8', 6, N'Trống'),
(9, N'Bàn 9', 3, N'Trống'),
(10, N'Bàn 10', 5, N'Trống');

CREATE TABLE Bills (
	ID INT PRIMARY KEY,
	DateIn datetime NOT NULL,
	DateOut datetime NOT NULL,
	Status VARCHAR(255) NOT NULL,
	PriceTotal float NOT NULL,
	TableID int NOT NULL,
	CustomerID INT NOT NULL,
	EmployeeID INT NOT NULL,
	FOREIGN KEY (TableID) REFERENCES Tables(ID),
	FOREIGN KEY (CustomerID) REFERENCES Customers(ID),
	FOREIGN KEY (EmployeeID) REFERENCES Employees(ID)
);
-- INSERT statements for the "Bills" table
INSERT INTO Bills (ID, DateIn, DateOut, Status, PriceTotal, TableID, CustomerID, EmployeeID) VALUES
(1, '2023-11-15 12:30:00', '2023-11-15 14:45:00', N'Đã Thanh Toán', 100000, 3, 3, 3),
(2, '2023-11-15 13:45:00', '2023-11-15 16:00:00', N'Đã Thanh Toán', 220000, 4, 4, 4);

CREATE TABLE BillInfo (
	ID int PRIMARY KEY,
	BillID int NOT NULL,
	ProductID int NOT NULL,
	CountValue int NOT NULL DEFAULT 1,
);
-- INSERT statements for the "BillInfo" table
INSERT INTO BillInfo (ID, BillID, ProductID, CountValue) VALUES
(1,1,1,4),
(2,2,2,4),
(3,2,7,2);

CREATE TABLE ProductCategory (
	ID int PRIMARY KEY,
	Name VARCHAR(255) NOT NULL
);
-- INSERT statements for the "ProductCategory" table
INSERT INTO ProductCategory (ID, Name) VALUES
(1, 'Đồ uống'),
(2, 'Đồ ăn'),
(3, 'Dịch vụ');

CREATE TABLE Product(
	ID INT PRIMARY KEY,
	Name VARCHAR(255) NOT NULL,
	Price float NOT NULL,
	CategoryID int NOT NULL,
	ProductType varchar NOT NULL,
	FOREIGN KEY (CategoryID) REFERENCES ProductCategory(ID)
);
-- INSERT statements for the "Product" table
INSERT INTO Product (ID, Name, Price, CategoryID,ProductType) VALUES
-- Đồ uống (Beverages)
(1, 'Trà xanh', 25000, 1,'M'),
(2, 'Cà phê sữa đá', 35000, 1,'M'),
(3, 'Trà chanh', 20000, 1,'M'),
(4, 'Cà phê đen', 30000, 1,'M'),
(5, 'Nước ép cam', 28000, 1,'M'),

-- Đồ ăn (Food)
(6, 'Bánh ngọt caramen', 35000, 2,'M'),
(7, 'Pudding trà xanh', 40000, 2,'M'),
(8, 'Bánh mì trứng ốp', 30000, 2,'M'),
(9, 'Xôi đậu phộng', 25000, 2,'M'),
(10, 'Bánh mì pate', 28000, 2,'M'),

-- Dịch vụ (Services)
(11, 'Khăn ướt cao cấp', 15000, 3,'M'),
(12, 'Thuốc lá Marlboro', 45000, 3,'M'),
(13, 'Thuốc lá Camel', 42000, 3,'M'),
(14, 'Khăn lau mặt', 12000, 3,'M'),
(15, 'Thuốc lá Winston', 40000, 3,'M');
