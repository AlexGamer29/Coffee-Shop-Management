﻿CREATE DATABASE CoffeeShop
GO

USE CoffeeShop
GO

-- Menu = danh sách món ăn
-- Table = thông tin bàn
-- Categories = danh mục của các món ăn
-- Account = thông tin tài khoản
-- Receipt = thông tin hóa đơn
-- ReceiptInfo = thông tin chi tiết của hóa đơn

CREATE TABLE CoffeeTable
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'No named',
	tablesStatus NVARCHAR(100) DEFAULT N'Trống' NOT NULL -- Trống = 0 || Có người = 1
)
GO

CREATE TABLE Account
(
	userName NVARCHAR(100) PRIMARY KEY,
	displayName NVARCHAR(100) NOT NULL DEFAULT N'No named',
	password NVARCHAR(1000) NOT NULL DEFAULT 0,
	accountType INT NOT NULL DEFAULT 0 -- Staff = 0, Admin = 1
)
GO

CREATE TABLE Categories
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'No named',
)
GO

CREATE TABLE Menu
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'No named',
	idCategories INT NOT NULL,
	price INT NOT NULL DEFAULT 0,

	FOREIGN KEY (idCategories) REFERENCES dbo.Categories(id)
)
GO

CREATE TABLE Receipt
(
	id INT IDENTITY PRIMARY KEY,
	arrivalDate DATETIME NOT NULL DEFAULT GETDATE(),
	departDate DATETIME,
	idTable INT NOT NULL,
	STATUS INT NOT NULL DEFAULT 0, -- Chưa thanh toán = 0, Đã thanh toán = 1

	FOREIGN KEY (idTable) REFERENCES dbo.CoffeeTable(id)
)
GO

CREATE TABLE ReceiptInfo
(
	id INT IDENTITY PRIMARY KEY,
	idReceipt INT NOT NULL,
	idMenu INT NOT NULL,
	numberOfFood INT NOT NULL DEFAULT 0,

	FOREIGN KEY (idReceipt) REFERENCES dbo.Receipt(id),
	FOREIGN KEY (idMenu) REFERENCES dbo.Menu(id)
)
GO