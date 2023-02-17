-- 1.  List all cities that have both Employees and Customers.
SELECT DISTINCT City
FROM Customers
WHERE City in (SELECT City From Employees)

-- 2.  List all cities that have Customers but no Employee.
-- a.      Use sub-query
SELECT DISTINCT City
FROM Customers
WHERE City not in (SELECT City From Employees)
-- b.      Do not use sub-query
SELECT DISTINCT c.City
FROM Customers c
LEFT JOIN Employees e ON c.City = e.City
WHERE e.City IS NULL;

-- 3.      List all products and their total order quantities throughout all orders.
SELECT p.ProductName, SUM(od.Quantity) as TotalOrderQuantity
FROM Products p
INNER JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductName;

-- 4.      List all Customer Cities and total products ordered by that city.
SELECT c.City, SUM(od.Quantity) as TotalProductsOrdered
FROM Customers c
INNER JOIN Orders o ON c.CustomerID = o.CustomerID
INNER JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City;

-- 5.      List all Customer Cities that have at least two customers
-- a.      Use union
SELECT City 
FROM Customers
GROUP BY City
HAVING COUNT(*) >= 2

UNION

SELECT City 
FROM Suppliers
GROUP BY City
HAVING COUNT(*) >= 2;

-- b.      Use sub-query and no union
SELECT DISTINCT City
FROM Customers
WHERE City IN (
    SELECT City
    FROM Customers
    GROUP BY City
    HAVING COUNT(*) >= 2
);

-- 6.      List all Customer Cities that have ordered at least two different kinds of products.
SELECT c.City
FROM Customers c
INNER JOIN Orders o ON c.CustomerID = o.CustomerID
INNER JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City, od.ProductID
HAVING COUNT(DISTINCT od.ProductID) >= 2;

-- 7.      List all Customers who have ordered products, but have the ‘ship city’ on the order different from their own customer cities.
SELECT DISTINCT c.ContactName
FROM Customers c
INNER JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE c.City!= o.ShipCity
-- 8.      List 5 most popular products, their average price, and the customer city that ordered most quantity of it.

SELECT TOP 5 
    p.ProductName, 
    -- NOT SURE ABOUT THE Average Price
    AVG(od.UnitPrice * od.Quantity) as AveragePrice, 
    (SELECT TOP 1 c.City
     FROM Customers c
     INNER JOIN Orders o ON c.CustomerID = o.CustomerID
     INNER JOIN [Order Details] od ON o.OrderID = od.OrderID
     WHERE od.ProductID = p.ProductID
     GROUP BY c.City
     ORDER BY SUM(od.Quantity) DESC) AS MostOrderingCity
FROM Products p
INNER JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductID, p.ProductName
ORDER BY SUM(od.Quantity) DESC;

-- 9.      List all cities that have never ordered something but we have employees there.
-- a.      Use sub-query
SELECT City
FROM Employees 
WHERE City  not in (
    SELECT ShipCity
    FROM Orders o )
-- b.   Do not use sub-query
SELECT e.City
FROM Orders o 
RIGHT JOIN Employees e ON e.City = o.ShipCity
WHERE o.ShipCity is null

-- 10.  List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, 
-- and also the city of most total quantity of products ordered from. (tip: join  sub-query)
SELECT 
    (SELECT TOP 1 c.City
     FROM Customers c
     INNER JOIN Orders o ON c.CustomerID = o.CustomerID
     GROUP BY c.City, o.EmployeeID
     ORDER BY COUNT(*) DESC) AS CitywMostOrders,
    (SELECT TOP 1 c.City
     FROM Customers c
     INNER JOIN Orders o ON c.CustomerID = o.CustomerID
     INNER JOIN [Order Details] od ON o.OrderID = od.OrderID
     GROUP BY c.City
     ORDER BY SUM(od.Quantity) DESC) AS CitywMostTotalQuantity 

-- 11. How do you remove the duplicates record of a table?
-- To remove duplicate records from a table, we use the DISTINCT keyword in a SELECT 

