SELECT c.name,
	sum(p.amount)
FROM categories c
	join products p on c.id = p.id_categories
GROUP BY c.name