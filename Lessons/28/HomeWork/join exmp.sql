
select d.Name, d.Pages, emps.Fullname, ps.Name, cs.Name, ads.Street, ads.House, empr.Fullname, pr.Name,  cr.Name, adr.Street, adr.House, dc.[Status], dc.[DateTime] from Documentstatus as dc
JOIN Document  as d
on d.Id = dc.DocumentId
join employee as emps
on emps.Id = dc.SenderId
join employee as empr
on empr.Id = dc.ReceiverId
join Position as ps
on ps.Id = emps.PositionId
join Position as pr
on pr.Id = empr.PositionId
join [address] as ads
on ads.Id = dc.senderAddressId
join city as cs
on cs.Id = ads.CityId
join [address] as adr
on adr.Id = dc.receiverAddressId
join city as cr
on cr.Id = adr.CityId