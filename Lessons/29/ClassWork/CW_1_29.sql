Select COUNT(*) as AllCount from OrderLine;
Select COUNT(DISTINCT OrderId) as CountDistinctOders from OrderLine;
SELECT MAX(id) as MaxOrderNumber FROM [u_sheykina_schema].[Order];
SELECT Avg(Discount) as AVGDiscount FROM [u_sheykina_schema].[Order];
SELECT Max(OrderDate) as MaxOrderDate, Min(OrderDate) as MinOrderDate FROM [u_sheykina_schema].[Order];
SELECT Max(OrderDate) as LastOrderDate_2018 FROM [u_sheykina_schema].[Order] Where YEAR(OrderDate) = 2018;
select Max(LEN([Name])) as MaxLenthOfName FROM Product;