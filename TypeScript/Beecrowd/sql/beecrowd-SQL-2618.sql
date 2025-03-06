select p."name",
	pr."name",
	c."name"
from products p
	join categories c on c.id = p.id_categories
	join providers pr on pr.id = p.id_providers
where c."name" = 'Imported'
	and pr."name" = 'Sansul SA'