-- Write your query below

select customer_id
from (
    select customer_id, sum(revenue) as total_rev
    from customers
    where year = 2020
    group by customer_id
) t
where total_rev > 0;