SELECT 
    person.surname,
    person.name,
    SUM(order_details.price_with_discount * order_details.product_amount) AS total_expenses
FROM person
INNER JOIN customer ON person.id = customer.person_id
INNER JOIN customer_order ON customer.person_id = customer_order.customer_id
INNER JOIN order_details ON customer_order.id = order_details.customer_order_id
WHERE person.birth_date BETWEEN '2000-01-01' AND '2010-12-31'
GROUP BY person.surname, person.name
HAVING total_expenses > (SELECT AVG(total_expenses) FROM (SELECT SUM(order_details.price_with_discount * order_details.product_amount) AS total_expenses FROM customer_order JOIN order_details ON customer_order.id = order_details.customer_order_id GROUP BY customer_order.customer_id) AS avg_expenses)
ORDER BY total_expenses ASC, person.surname ASC;