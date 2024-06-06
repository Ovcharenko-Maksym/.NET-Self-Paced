SELECT 
    person.name,
    person.surname,
    AVG(order_details.price_with_discount * order_details.product_amount) AS avg_purchase,
    SUM(order_details.price_with_discount * order_details.product_amount) AS sum_purchase
FROM person
JOIN customer ON person.id = customer.person_id
JOIN customer_order ON customer.person_id = customer_order.customer_id
JOIN order_details ON customer_order.id = order_details.customer_order_id
WHERE person.id IS NOT NULL
GROUP BY person.name, person.surname
HAVING avg_purchase > 70
ORDER BY sum_purchase ASC, person.surname ASC;