SELECT DISTINCT product_title.title, product.price
FROM product
INNER JOIN order_details ON product.id = order_details.product_id
INNER JOIN product_title ON product.product_title_id = product_title.id
INNER JOIN customer_order ON order_details.customer_order_id = customer_order.id
INNER JOIN customer ON customer_order.customer_id = customer.person_id
INNER JOIN person ON customer.person_id = person.id
WHERE person.birth_date BETWEEN '2000-01-01' AND '2010-12-31'
ORDER BY product_title.title ASC, product.price ASC;