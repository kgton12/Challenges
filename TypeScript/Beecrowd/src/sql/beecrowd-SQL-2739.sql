select l."name",
	extract(
		day
		from l.payday
	)::INT as day
from loan l