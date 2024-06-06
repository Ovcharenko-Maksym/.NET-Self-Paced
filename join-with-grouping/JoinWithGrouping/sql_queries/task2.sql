SELECT city.name AS city, SUM(order_details.price_with_discount * order_details.product_amount) AS income
FROM customer_order
INNER JOIN supermarket ON customer_order.supermarket_id = supermarket.id
INNER JOIN street ON supermarket.street_id = street.id
INNER JOIN city ON street.city_id = city.id
INNER JOIN order_details ON customer_order.id = order_details.customer_order_id
WHERE customer_order.operation_time BETWEEN '2020-11-01' AND '2020-11-30'
GROUP BY city.name
ORDER BY income ASC, city.name ASC;