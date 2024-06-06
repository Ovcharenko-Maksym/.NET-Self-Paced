SELECT 
    product.id,
    product_title.title,
    SUM(CASE WHEN order_details.price_with_discount >= 0.05 * order_details.price THEN order_details.product_amount ELSE 0 END) AS count_with_discount_5,
    SUM(CASE WHEN order_details.price_with_discount < 0.05 * order_details.price THEN order_details.product_amount ELSE 0 END) AS count_without_discount_5,
    ((SUM(CASE WHEN order_details.price_with_discount >= 0.05 * order_details.price THEN order_details.product_amount ELSE 0 END) - SUM(CASE WHEN order_details.price_with_discount < 0.05 * order_details.price THEN order_details.product_amount ELSE 0 END)) * 100.0) / SUM(order_details.product_amount) AS difference
FROM product
LEFT JOIN order_details ON product.id = order_details.product_id
INNER JOIN product_title on product_title.id = product.product_title_id
WHERE product.id IS NOT NULL
GROUP BY product.id, product_title.title
ORDER BY product.id ASC;