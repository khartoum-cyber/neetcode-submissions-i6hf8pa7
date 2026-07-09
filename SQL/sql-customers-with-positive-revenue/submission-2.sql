-- Write your query below

select customer_id
from customers as c
group by c.customer_id, c.year
having SUM(revenue) > 0 and c.year = '2020'