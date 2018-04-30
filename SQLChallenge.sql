CREATE DATABASE Company
GO

USE Company
GO

CREATE SCHEMA Customer
GO

CREATE TABLE Customer.Customers
(
	[ID] INT PRIMARY KEY IDENTITY NOT NULL,
	[FirstName] NVARCHAR(50),
	[LastName] NVARCHAR(50),
	[CardNumber] BIGINT
);

CREATE TABLE Customer.Products
(
	[ID] INT PRIMARY KEY IDENTITY NOT NULL,
	[Name] NVARCHAR(50),
	[Price] FLOAT
);

CREATE TABLE Customer.Orders
(
	[ID]INT PRIMARY KEY IDENTITY NOT NULL,
	[ProductID] INT NOT NULL,
	CONSTRAINT FK_Products_Orders FOREIGN KEY (ProductID) REFERENCES Customer.Products(ID),
	[CustomerID] INT NOT NULL,
	CONSTRAINT FK_Customers_Orders FOREIGN KEY (CustomerID) REFERENCES Customer.Customers(ID)
);

SELECT * FROM Customer.Customers
SELECT * FROM Customer.Products
SELECT * FROM Customer.Orders

INSERT INTO Customer.Customers([FirstName], [LastName], [CardNumber])
VALUES ('Jane', 'Doe', 5555555555555555)

INSERT INTO Customer.Customers([FirstName], [LastName], [CardNumber])
VALUES ('John', 'Smith', 8888888888888888)

INSERT INTO Customer.Customers([FirstName], [LastName], [CardNumber])
VALUES ('Terrance', 'Volleign', 123456789012)

SELECT * FROM Customer.Customers

INSERT INTO Customer.Products([Name], [Price])
VALUES ('Widget', 3.50)

INSERT INTO Customer.Products([Name], [Price])
VALUES ('Thing', 5.10)

INSERT INTO Customer.Products([Name], [Price])
VALUES('Cog', 22.50)

SELECT * FROM Customer.Products

INSERT INTO Customer.Orders([ProductID], [CustomerID])
VALUES(1, 1)

INSERT INTO Customer.Orders([ProductID], [CustomerID])
VALUES (2, 2)

INSERT INTO Customer.Orders([ProductID], [CustomerID])
VALUES(3, 3)

SELECT * FROM Customer.Orders

INSERT INTO Customer.Products([Name], [Price])
VALUES('iPhone', 200)

INSERT INTO Customer.Customers([FirstName], [LastName], [CardNumber])
VALUES('Tina', 'Smith', 1234123412341234)

INSERT INTO Customer.Orders ([ProductID], [CustomerID])
VALUES((SELECT ID FROM Customer.Customers WHERE FirstName = 'Tina' AND LastName = 'Smith'), 
(SELECT ID FROM Customer.Products WHERE [Name] = 'iPhone'))

SELECT FirstName, LastName, [Name] AS Product_Purchased FROM Customer.Customers JOIN Customer.Orders ON Customer.Customers.ID = Customer.Orders.CustomerID 
JOIN Customer.Products ON Customer.Products.ID = Customer.Orders.ProductID
WHERE FirstName = 'Tina' AND LastName = 'Smith'

SELECT [Name], COUNT(ProductID) FROM Customer.Products JOIN Customer.Orders