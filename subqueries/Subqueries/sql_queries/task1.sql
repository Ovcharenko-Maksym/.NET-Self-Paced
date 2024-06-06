SELECT product.id, product_title.title AS product, price
FROM product
INNER JOIN product_title on product.product_title_id = product_title.id
WHERE price >= (SELECT MIN(price) * 2 FROM product)
ORDER BY price ASC, product ASC;