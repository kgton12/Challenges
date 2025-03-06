(
	select ll.name as name, 
		ll.customers_number as customers_number
	from lawyers ll
	order by ll.customers_number desc
	limit 1
)
union all
(
	select ll.name as name,
		ll.customers_number as customers_number
	from lawyers ll
	order by ll.customers_number asc
	limit 1
)
union all
(
	select 'Average' as name,
		trunc(avg(ll.customers_number)) as customers_number
	from lawyers ll
	limit 1
)