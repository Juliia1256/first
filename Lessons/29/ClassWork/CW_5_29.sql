Select Sum(SUMM_With_discount) as SUMM_With_Discount from (
SELECT (1- isnull(ord.Discount, 0)) * sum(P.Price*ordL.[Count]) as SUMM_With_discount
from OrderLine as ordL
join [u_sheykina_schema].[Order] as ord
on ord.Id = ordL.OrderId
join Product as P
on P.Id = ordL.ProductId
JOIN Customer AS C
on C.Id= ord.CustomerId
WHERE C.Name = 'Мария'
GROUP by ord.Discount) as t;

