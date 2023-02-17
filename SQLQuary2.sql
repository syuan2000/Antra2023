-- 1. How many products can you find in the Production.Product table?
SELECT COUNT(ProductID) as TotalProduct
FROM Production.Product
-- 2. Write a query that retrieves the number of products in the Production.Product table that are included in a subcategory. 
-- The rows that have NULL in column ProductSubcategoryID are considered to not be a part of any subcategory.

SELECT COUNT(p.ProductID) as TotalProductWithSub
FROM Production.Product p
INNER JOIN Production.ProductSubcategory ps ON p.ProductSubcategoryID = ps.ProductSubcategoryID

-- 3. How many Products reside in each SubCategory? Write a query to display the results with the following titles.
SELECT ps.ProductSubcategoryID, COUNT(p.ProductID) AS CountedProducts
FROM Production.Product p
INNER JOIN Production.ProductSubcategory ps ON p.ProductSubcategoryID = ps.ProductSubcategoryID
GROUP BY ps.ProductSubcategoryID

-- 4. How many products that do not have a product subcategory.
SELECT COUNT(p.ProductID) as TotalProductWithSub
FROM Production.Product p
LEFT JOIN Production.ProductSubcategory ps ON p.ProductSubcategoryID = ps.ProductSubcategoryID
WHERE p.ProductSubcategoryID is null

-- 5. Write a query to list the sum of products quantity in the Production.ProductInventory table.
SELECT SUM(Quantity) AS SumQuantity
FROM Production.ProductInventory

-- 6. Write a query to list the sum of products in the Production.ProductInventory table and LocationID set to 40 
-- and limit the result to include just summarized quantities less than 100.
SELECT ProductID, COUNT(ProductID) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40 and Quantity<100

-- 7. Write a query to list the sum of products with the shelf information in the Production.ProductInventory table 
-- and LocationID set to 40 and limit the result to include just summarized quantities less than 100
SELECT ProductID, Shelf, COUNT(ProductID) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40 and Quantity<100 and Shelf != 'N/A'
GROUP BY ProductID, Shelf

-- 8. Write the query to list the average quantity for products where column LocationID has the value of 10 from the table Production.ProductInventory table.
SELECT AVG(Quantity) AS avgQuantity
FROM Production.ProductInventory
WHERE LocationID = 10

-- 9. Write query to see the average quantity of products by shelf from the table Production.ProductInventory
SELECT ProductID, Shelf, AVG(Quantity) as avgQuantity
FROM Production.ProductInventory
GROUP BY ProductID, Shelf

-- 10.Write query to see the average quantity of products by shelf excluding rows that has the value of N/A in the column Shelf from the table Production.ProductInventory
SELECT ProductID, Shelf, AVG(Quantity) as TheAvg
FROM Production.ProductInventory
WHERE SHelf !='N/A'
GROUP BY ProductID, Shelf

-- 11. List the members (rows) and average list price in the Production.Product table. 
-- This should be grouped independently over the Color and the Class column. Exclude the rows where Color or Class are null.
SELECT Color, Class,  COUNT(ProductID) as TheCount, AVG(ListPrice) as AvgPrice
FROM Production.Product 
WHERE Color is not null and Class is not null
GROUP BY Color, Class

-- 12. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables. 
-- Join them and produce a result set similar to the following.
SELECT cr.Name as Country, sp.Name as Province
FROM Person.CountryRegion cr
JOIN Person.StateProvince sp ON cr.CountryRegionCode = sp.CountryRegionCode

-- 13. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables 
-- and list the countries filter them by Germany and Canada. Join them and produce a result set similar to the following.
SELECT cr.Name as Country, sp.Name as Province
FROM Person.CountryRegion cr
JOIN Person.StateProvince sp ON cr.CountryRegionCode = sp.CountryRegionCode
WHERE cr.Name in ('Canada', 'Germany')

-- 14.  List all Products that has been sold at least once in last 25 years.
SELECT DISTINCT p.ProductName
FROM dbo.Products p
JOIN dbo.[Order Details] od on p.ProductID = od.ProductID
JOIN dbo.Orders o on o.OrderID = od.OrderID
WHERE o.OrderDate >= DATEADD(YEAR, -25, GETDATE())

-- 15.  List top 5 locations (Zip Code) where the products sold most.
SELECT top 5 o.ShipPostalCode, COUNT(p.ProductID)
FROM dbo.Products p
JOIN dbo.[Order Details] od on p.ProductID = od.ProductID
JOIN dbo.Orders o on o.OrderID = od.OrderID
WHERE o.ShipPostalCode is not null
GROUP BY o.ShipPostalCode
ORDER BY  COUNT(p.ProductID) DESC

-- 16.  List top 5 locations (Zip Code) where the products sold most in last 25 years.
SELECT top 5 o.ShipPostalCode
FROM dbo.Products p
JOIN dbo.[Order Details] od on p.ProductID = od.ProductID
JOIN dbo.Orders o on o.OrderID = od.OrderID
WHERE o.OrderDate >= DATEADD(YEAR, -25, GETDATE())
GROUP BY o.ShipPostalCode
ORDER BY  COUNT(p.ProductID) DESC

-- 17.   List all city names and number of customers in that city.   
SELECT City, Count(CustomerID)
FROM dbo.Customers
GROUP BY City

-- 18.  List city names which have more than 2 customers, and number of customers in that city
SELECT City, Count(CustomerID)
FROM dbo.Customers
GROUP BY City
HAVING Count(CustomerID) > 2

-- 19.  List the names of customers who placed orders after 1/1/98 with order date.
SELECT DISTINCT c.ContactName
FROM dbo.Customers c
JOIN dbo.Orders o on o.CustomerID = c.CustomerID
WHERE o.OrderDate > '1998-01-01'

-- 20.  List the names of all customers with most recent order dates
SELECT c.ContactName, MAX(o.OrderDate) as mostRecentOrderDate
FROM dbo.Customers c
JOIN dbo.Orders o on o.CustomerID = c.CustomerID
GROUP BY c.ContactName
ORDER BY mostRecentOrderDate DESC

-- 21.  Display the names of all customers along with the  count of products they bought
SELECT c.ContactName, COUNT(od.ProductID)
FROM dbo.Customers c
JOIN dbo.Orders o on o.CustomerID = c.CustomerID
JOIN dbo.[Order Details] od on o.OrderID = od.OrderID
GROUP BY c.ContactName

-- 22.  Display the customer ids who bought more than 100 Products with count of products.
SELECT o.CustomerID
FROM dbo.Orders o 
JOIN dbo.[Order Details] od on o.OrderID = od.OrderID
GROUP BY o.CustomerID
HAVING SUM(od.Quantity) > 100

-- 23.  List all of the possible ways that suppliers can ship their products. Display the results as below

SELECT su.CompanyName as 'Supplier Company Name', sh.CompanyName as 'Shipping Company Name'
FROM dbo.Suppliers su
CROSS JOIN dbo.Shippers sh

-- 24.  Display the products order each day. Show Order date and Product Name.
SELECT o.OrderDate, p.ProductName
FROM dbo.Products p
JOIN dbo.[Order Details] od on p.ProductID = od.ProductID
JOIN dbo.Orders o on o.OrderID = od.OrderID
GROUP BY o.OrderDate, p.ProductName

-- 25.  Displays pairs of employees who have the same job title.
SELECT LastName + ' ' + FirstName
FROM dbo.Employees
WHERE Title = (select title from dbo.Employees group by title having count(EmployeeID) > 1)

-- 26.  Display all the Managers who have more than 2 employees reporting to them.
SELECT FirstName + ' ' + LastName 
FROM Employees
WHERE EmployeeID in (select ReportsTo from Employees Group by ReportsTo having count(EmployeeID)>2)

-- 27.  Display the customers and suppliers by city. The results should have the following columns

SELECT City, CompanyName as Name, ContactName as 'Contact Name', 'Customer' AS Type
FROM dbo.Customers
UNION
SELECT City, CompanyName as Name, ContactName as 'Contact Name', 'Supplier' AS Type
FROM dbo.Suppliers
ORDER BY City;


