


INSERT INTO Products (Name, Price)
VALUES ('Pixel', 250.00);

INSERT INTO Products (Name, Price)
VALUES ('iPhone', 200.00);

INSERT INTO Products (Name, Price)
VALUES ('Samsung', 140.00);

INSERT INTO Customers (Firstname, Lastname, CardNumber)
VALUES ('Tina', 'Smith', 123456);

INSERT INTO Customers (Firstname, Lastname, CardNumber)
VALUES ('John', 'Smith', 987654);

INSERT INTO Customers (Firstname, Lastname, CardNumber)
VALUES ('Jane', 'Doe', 1928374);

INSERT INTO Orders (CustomerID, ProductID) 
VALUES( 
	(select ID from Customers where FirstName = 'Tina' and LastName = 'Smith'), 
	(select ID from Products where Name = 'iPhone')
);

INSERT INTO Orders (CustomerID, ProductID) 
VALUES( 
	(select ID from Customers where FirstName = 'John' and LastName = 'Smith'), 
	(select ID from Products where Name = 'iPhone')
);

INSERT INTO Orders (CustomerID, ProductID) 
VALUES( 
	(select ID from Customers where FirstName = 'Jane' and LastName = 'Doe'), 
	(select ID from Products where Name = 'Samsung')
);

Select * From Orders
Where Orders.CustomerID = 1;

SELECT SUM(P.Price) as 'Total Revenue'
From Orders as O
Left Join Products as P
ON  O.ProductID = P.ID
WHERE P.ID = 1;

UPDATE Products
SET Price = 250.00
WHERE Name = 'iPhone";