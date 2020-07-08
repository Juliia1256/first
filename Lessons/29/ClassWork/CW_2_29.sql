select Id, Discount from [u_sheykina_schema].[Order]
where Discount = (
    select MAX(Discount) from [u_sheykina_schema].[Order]
    where Year(OrderDate) = 2016
);

select id, OrderDate FROM [u_sheykina_schema].[Order]
where OrderDate = (
    select Min(OrderDate) FROM [u_sheykina_schema].[Order]
    where Year(OrderDate) = 2019
);


select O.Id, O.Discount, C.Name from [u_sheykina_schema].[Order] as O
JOIN Customer as C
on C.Id = o.CustomerId
where Discount = (
    select MAX(Discount) from [u_sheykina_schema].[Order]
    where Year(OrderDate) = 2016
);

select O.Id, C.Name from [u_sheykina_schema].[Order] as O
JOIN Customer as C
on C.Id = o.CustomerId
where OrderDate = (
    select Min(OrderDate) from [u_sheykina_schema].[Order]
    where Year(OrderDate) = 2019
);

