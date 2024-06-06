SELECT product.id, product_title.title, price
FROM product
INNER JOIN product_title on product.product_title_id = product_title.id
WHERE price > (
    SELECT AVG(price)
    FROM product
    WHERE product_title_id = product.product_title_id
)
ORDER BY product.id ASC;