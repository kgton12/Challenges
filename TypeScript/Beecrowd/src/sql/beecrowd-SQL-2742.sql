select lr."name",
	trunc((lr.omega * 1.618), 3) as "Fator N"
from life_registry lr
	join dimensions d on d.id = lr.dimensions_id
where d."name" in ('C875', 'C774')
	and lr."name" ilike '%Richard%'
order by lr.omega
