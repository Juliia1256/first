with 
CustomerTotalOrdersByYearWithDiscount as (
    SELECT
        o.CustomerId as customerId,
        YEAR(o.OrderDate) as OrderYear,
        (1-isnull(o.Discount, 0))*sum(ol.Count * p.Price) as Total
    from [order] as o
    join [orderLine] as ol on o.Id = ol.OrderId
    JOIN [product] as p on p.Id = ol.ProductId
    group by o.CustomerId, year(o.OrderDate), o.Discount
),
CustomerTotalSumByYear as (
    SELECT
    CustomerTotalOrdersByYearWithDiscount.customerId as customerId,
    CustomerTotalOrdersByYearWithDiscount.OrderYear as  OrderYear,
    SUM(CustomerTotalOrdersByYearWithDiscount.Total) as Total
    from CustomerTotalOrdersByYearWithDiscount 
    join [Customer] as c on c.Id = CustomerTotalOrdersByYearWithDiscount.customerId
    group by CustomerTotalOrdersByYearWithDiscount.customerId, CustomerTotalOrdersByYearWithDiscount.OrderYear 
),
CustomerTotalMaxByYear as (
    select 
    CustomerTotalSumByYear.OrderYear as OrderYear,
    Max(CustomerTotalSumByYear.Total) as Total
    FROM CustomerTotalSumByYear
    group by CustomerTotalSumByYear.OrderYear 

)
select 
    Customer.Id as CustomerId,
    Customer.Name as CustomerName,
    CustomerTotalMaxByYear.Total as CustomerTotal,
    CustomerTotalMaxByYear.OrderYear as OrderYear
    from  CustomerTotalMaxByYear
    join CustomerTotalSumByYear on CustomerTotalMaxByYear.Total = CustomerTotalSumByYear.Total
    join Customer on customer.Id = CustomerTotalSumByYear.customerId
    ORDER by OrderYear DESC