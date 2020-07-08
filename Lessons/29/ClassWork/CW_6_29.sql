Select Id, name, sum(SUMM_With_discount) as SummTotal, YEAR
From (
Select C.Id, C.Name, (1- isnull(ord.Discount, 0)) * sum(P.Price*ol.[Count]) SUMM_With_discount, Year(ord.OrderDate) [YEAR]
from Customer as c 
    join [u_sheykina_schema].[Order] as ord on ord.CustomerId = c.Id
    join [OrderLine] as ol on ol.OrderId = ord.Id
    join Product as P on P.Id = ol.ProductId
GROUP by c.Id, c.Name, isnull(Discount, 0), YEAR(ord.OrderDate)
) t
GROUP by Id, [Name], YEAR
Order by [Name], YEAR


