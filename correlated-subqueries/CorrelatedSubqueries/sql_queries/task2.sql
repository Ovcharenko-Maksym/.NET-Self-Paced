SELECT product_category.id, product_category.name
FROM product_category
WHERE EXISTS (
    SELECT 1
    FROM product
    WHERE product.product_title_id IN (
        SELECT product_title.id
        FROM product_title
        WHERE product_title.product_category_id = product_category.id
    ) AND EXISTS (
        SELECT 2
        FROM order_details
        WHERE order_details.product_id = product.id
    )
)
ORDER BY product_category.id ASC;