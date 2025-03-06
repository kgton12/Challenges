select a.id,
	a."password",
	md5(a."password")
from account a
