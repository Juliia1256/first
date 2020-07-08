select t.[YEAR], SUM(t.SUMM_With_discount) as total
from
(
SELECT year(ord.orderDate) as YEAR,
(1- isnull(ord.Discount, 0)) * sum(P.Price*ol.[Count]) as SUMM_With_discount
from [Order] as ord
    join OrderLine as ol on ord.Id = ol.OrderId
    join Product as p on p.Id = ol.ProductId
    group by ord.Discount, Year(ord.OrderDate) 
) as t
GROUP by t.[YEAR]
ORDER by total DESC
OFFSET 1 ROWS
fetch next 1 ROWS only