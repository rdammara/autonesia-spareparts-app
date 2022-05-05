CREATE DATABASE db_Autonesia

USE db_Autonesia

--CHAR can be used for Primary Keys and IDs since those are string characters, and therefore can be used (except for Item Code)--
CREATE TABLE GoodsReceived
(
	GoodsReceivedNo		CHAR(5) NOT NULL PRIMARY KEY,
	GRDate				DATE	NOT NULL,
	SupplierCode		CHAR(5) NOT NULL,
	FOREIGN KEY			(SupplierCode) REFERENCES Supplier,
	DeliveryOrderNo		CHAR(5) NOT NULL,
	PO_No				CHAR(5) NOT NULL,
	FOREIGN KEY			(PO_No) REFERENCES PurchaseOrder
)

CREATE TABLE PurchaseOrder
(
	PO_No				CHAR(5)		NOT NULL PRIMARY KEY,
	OrderType			VARCHAR(25)	NOT NULL,
	ItemCode			VARCHAR(50)		NOT NULL,
	FOREIGN KEY			(ItemCode) REFERENCES Item,
	Ordered				INT			NOT NULL,
	Received			INT			NOT NULL
)

CREATE TABLE Invoice
(
	InvoiceNo			CHAR(5)		NOT NULL PRIMARY KEY,
	InvoiceDate			DATE		NOT NULL,
	CustCode			CHAR(5)		NOT NULL,
	ItemCode			CHAR(5)		NOT NULL,
	Qty					INT			NOT NULL
)

CREATE TABLE SalesOrder 
(
	SalesOrderNo		CHAR(5)		NOT NULL PRIMARY KEY,
	SalesOrderDate		DATE		NOT NULL,
	SalesmanCode		CHAR(5)		NOT NULL,
	InvoiceNo			CHAR(5)		NOT NULL,
	PickingListNumber	CHAR(5)		NOT NULL
)
--Based on the Excel table, the Item Code uses variations of characters of more than 5, therefore VARCHAR(50) is appropriate for this case--
CREATE TABLE Item
(
	ItemCode		VARCHAR(50)		NOT NULL PRIMARY KEY,
	ItemName		VARCHAR(50)		NOT NULL,
	ItemClass		VARCHAR(50)		NOT NULL,
	SupplierPrice	DECIMAL			NOT NULL,
	UnitPrice		DECIMAL			NOT NULL,
	UOM				VARCHAR(50)		NOT NULL
)

CREATE TABLE Stock
(
	MainLocation	CHAR(5)			NOT NULL PRIMARY KEY,
	WarehouseGroup	VARCHAR(50)		NOT NULL,
	ItemCode		CHAR(5)			NOT NULL,
	Available		VARCHAR(50)		NOT NULL,
)

CREATE TABLE Supplier
(
	SupplierCode	CHAR(5)			NOT NULL PRIMARY KEY,
	SupplierName	VARCHAR(25)		NOT NULL,
	SupplierAddress VARCHAR(50)		NOT NULL,
	SupplierPhone	INT				NOT NULL,
	Email			VARCHAR(50)		NOT NULL
)

CREATE TABLE Customer
(
	CustCode		CHAR(5)			NOT NULL PRIMARY KEY,
	CustName		VARCHAR(50)		NOT NULL,
	CustPhone		INT				NOT NULL,
	CustAddress		TEXT			NOT NULL
)

CREATE TABLE Salesman
(
	SalesmanCode	CHAR(5)			NOT NULL PRIMARY KEY,
	SalesmanName	VARCHAR(50)		NOT NULL,
	SalesmanPhone	INT				NOT NULL,
	SalesmanAddress	VARCHAR(50)		NOT NULL,
	SalesmanUsername VARCHAR(20)	NOT NULL,
	SalesmanPassword VARCHAR(20)	NOT NULL
)

--DML Enquiry--
INSERT INTO GoodsReceived VALUES ('GR001','2021-05-01', 'SP001', 'DN001', 'PO001')
INSERT INTO GoodsReceived VALUES ('GR002','2021-07-01', 'SP002', 'DN002', 'PO002')
INSERT INTO GoodsReceived VALUES ('GR003','2021-07-01', 'SP003', 'DN003', 'PO003')
INSERT INTO GoodsReceived VALUES ('GR004','2021-10-01', 'SP004', 'DN004', 'PO004')
INSERT INTO GoodsReceived VALUES ('GR005','2021-11-01', 'SP005', 'DN005', 'PO005')

INSERT INTO PurchaseOrder VALUES('PO001','Regular','21710-ED000','1','1')
INSERT INTO PurchaseOrder VALUES('PO002','Regular','54560-EE500','2','2')





