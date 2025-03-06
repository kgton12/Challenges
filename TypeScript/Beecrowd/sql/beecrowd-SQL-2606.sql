SELECT p.id,
	p.name
FROM products p
	JOIN categories c on c.id = p.id_categories
WHERE c.name ilike 'super%'

