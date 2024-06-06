SELECT product_category.name AS category, product_title.title AS product
FROM product_title
INNER JOIN product_category ON product_title.product_category_id = product_category.id
LEFT JOIN order_details ON product_title.id = order_details.product_id
WHERE order_details.id IS NULL
ORDER BY product_title.id ASC;