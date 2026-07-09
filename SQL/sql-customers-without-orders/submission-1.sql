-- Write your query below

select c.name
from customers as c
where NOT EXISTS (
    select name from customers join orders as o on o.customer_id = c.id
)