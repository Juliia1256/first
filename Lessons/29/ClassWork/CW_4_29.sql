SELECT sum(P.Price*ordL.[Count]) as SUMM_WithoutDiscount 
from OrderLine as ordL
join [u_sheykina_schema].[Order] as ord
on ord.Id = ordL.OrderId
join Product as P
on P.Id = ordL.ProductId
JOIN Customer AS C
on C.Id= ord.CustomerId
WHERE C.Name = 'Мария';

