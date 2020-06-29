
select count (*) from orderline;
select count (DISTINCT orderId) from orderline;
select MAX(id) from [u_sheykina_schema].[Order];
select AVG(discount) from [u_sheykina_schema].[Order];
select Min(orderdate) from [u_sheykina_schema].[Order];
select Max(orderdate) from [u_sheykina_schema].[Order];
select MAX(LEN([Name])) from product;