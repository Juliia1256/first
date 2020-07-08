SELECT P.Name, P.Price, ordL.Count, P.Price*ordL.[Count] as SUMM_WithoutDiscount, 
ord.Discount, P.Price*ordL.[Count]*ord.Discount as SUMM_Discount, 
P.Price*ordL.Count-P.Price*ordL.[Count]*ord.Discount as SUMM_With_Discount 
from OrderLine as ordL
join [u_sheykina_schema].[Order] as ord
on ord.Id = ordL.OrderId
join Product as P
on P.Id = ordL.ProductId
WHERE ord.Id = '22';
