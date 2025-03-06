SELECT p.name,
	pr.name
FROM products p
	JOIN providers pr on pr.id = p.id_providers
WHERE p.id_categories = 6