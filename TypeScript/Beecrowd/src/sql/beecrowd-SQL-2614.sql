select customers.name,
	rentals.rentals_date
from rentals
	join customers on customers.id = rentals.id_customers
where rentals.rentals_date between '2016-09-01' and '2016-09-30'