select p."name"
from products p
	join providers pr on pr.id = p.id_providers
where p.amount between 10 and 20
	and pr."name" ilike 'P%'
	