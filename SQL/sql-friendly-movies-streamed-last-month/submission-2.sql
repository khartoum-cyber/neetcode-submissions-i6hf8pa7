-- Write your query below

select distinct c.title
from content c
join tv_program t on c.content_id = t.content_id
where t.program_date between '2020-06-01' and '2020-06-31' and c.kids_content = 'Y' and c.content_type = 'Movies';