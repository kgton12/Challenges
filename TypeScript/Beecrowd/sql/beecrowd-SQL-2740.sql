(
	select 'Podium: ' || l.team
	from league l
	order by l."position" asc
	limit 3
)
union all
(
	select 'Demoted: ' || l.team
	from league l
	order by l."position" asc
	limit 2 offset 13
)