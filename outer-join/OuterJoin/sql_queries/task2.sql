SELECT person.surname, person.name, person.birth_date
FROM person
LEFT JOIN customer ON person.id = customer.person_id
LEFT JOIN customer_order ON customer.person_id = customer_order.customer_id
WHERE customer_order.id IS NULL
ORDER BY person.surname ASC, person.birth_date ASC;