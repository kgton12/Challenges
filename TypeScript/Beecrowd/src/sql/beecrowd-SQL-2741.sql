SELECT 'Approved: ' || s."name",
	s.grade
FROM students s
where s.grade >= 7
order by grade desc