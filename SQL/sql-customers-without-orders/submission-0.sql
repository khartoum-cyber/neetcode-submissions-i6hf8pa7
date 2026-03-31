-- Write your query below
select c.name
from customers as c
left join orders as o on c.id = o.customer_id
where customer_id is null