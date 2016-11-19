--switches the database to be Northwind
USE Northwind
GO

----Show me the customers
--SELECT *
--FROM [Customers]

--SELECT *
--FROM Customers
--WHERE Country = 'USA'

--SELECT *
--FROM Customers
--WHERE Country != 'USA'

--SELECT *
--FROM Customers
--WHERE Country = 'USA' AND Region = 'OR'

--SELECT * 
--FROM Customers
--WHERE Country IN ('USA', 'UK')

SELECT *
FROM Customers
WHERE CompanyName LIKE 'A%'