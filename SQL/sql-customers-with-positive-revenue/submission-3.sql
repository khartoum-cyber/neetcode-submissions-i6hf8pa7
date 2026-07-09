-- Write your query below

select customer_id
from customers as c
where c.year = '2020'
group by c.customer_id
having SUM(revenue) > 0