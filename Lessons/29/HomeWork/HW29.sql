  --Написать запрос, в котором вывести все года, в которых были заказы и рядом id и имена клиентов с самым большим заказом по данному году.

  select max(SUMM_With_discount) as Max_Order_in_Year, year
 from(

                select ord.Id as Order_Id,
                       c.Id as id, 
                       c.Name as nam, 
                       (1- isnull(ord.Discount, 0)) * sum(P.Price*ol.[Count]) as SUMM_With_discount, 
                       YEAR(ord.OrderDate) as year
                from  OrderLine as ol
                JOIN [u_sheykina_schema].[Order] as ord  on ord.Id = ol.OrderId
                join Product as p on p.Id = ol.ProductId
                JOIN Customer as c on c.Id = ord.CustomerId
                group by ord.Id, YEAR(OrderDate), c.Id, c.Name, 1- isnull(ord.Discount, 0)
    ) t
 group by t.[year]
