CREATE SCHEMA Store;
GO
DROP TABLE IF EXISTS Customer

-- Table for Customer
CREATE TABLE Customer(
    ID INT NOT NULL PRIMARY KEY,
    Name NVARCHAR(150) NOT NULL,

);

DROP TABLE IF EXISTS Location

--Table for Location
CREATE TABLE Location(
    LocationID INT NOT NULL PRIMARY KEY,
    ProductID NVARCHAR(150) NOT NULL,
    Quantity NVARCHAR(30) NOT NULL,
    
);

DROP TABLE IF EXISTS Product

--Table for Product
CREATE TABLE Product(
    ProductID INT NOT NULL PRIMARY KEY,
    Name NVARCHAR(150) NOT NULL,
    Price MONEY NOT NULL,
);

DROP TABLE IF EXISTS [Order]

--Order 
CREATE TABLE [Order](
    OrderID INT PRIMARY KEY,
    CustomerId INT NOT NULL,
    LocationId INT NOT NUll,
    OrderTime DATETIME NOT NULL
);

DROP TABLE IF EXISTS Sales

--Table for Sales
CREATE TABLE Sales(
    ID INT NOT NULL PRIMARY KEY,
    OrderID INT NOT NULL,
    ProductId INT NOT NULL, 
    Price INT NOT NULL,
    Quantity INT NOT NULL CHECK(Quantity > 0)
)



--TEST VALUES
INSERT INTO Customer(ID, Name) VALUES (1, 'Tenzin Wangdu')
INSERT INTO Location(LocationID, ProductID, Quantity) VALUES(1, 1, 100),(1,2,100),(1,3,100), (2,1,100),(2,2,100), (2,3,100),(3,1,100),(3,2,100),(3,3,100);
INSERT INTO Product(ProductID, Name, Price) VALUES(1, 'Water', 0.99),(2,'Soda', 1.99), (3, 'Energy Drink', 2.99);
INSERT INTO [Order] (OrderID,CustomerId,LocationId,OrderTime) VALUES (1,1,1,SYSUTCDATETIME());
INSERT INTO Sales (ID,OrderID,ProductId,Price,Quantity) VALUES (1,1,1,0.99,5),(2, 1,2,1.99,5);

