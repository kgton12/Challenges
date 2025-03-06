select (
		substr(np.cpf, 1, 3) || '.' || substr(np.cpf, 4, 3) || '.' || substr(np.cpf, 7, 3) || '-' || substr(np.cpf, 10, 2)
	)
from customers c
	join natural_person np on np.id_customers = c.id