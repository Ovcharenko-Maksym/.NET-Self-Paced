SELECT 
    pt.id AS product_id,
    pt.title,
    (
        SELECT m.id
        FROM manufacturer m
        WHERE m.id = (
            SELECT p.manufacturer_id
            FROM product p
            JOIN order_details od ON p.id = od.product_id
            WHERE p.product_title_id = pt.id
            GROUP BY p.manufacturer_id
            ORDER BY SUM(od.product_amount) DESC
            LIMIT 1
        )
    ) AS manufacturer_id,
    (
        SELECT m.name
        FROM manufacturer m
        WHERE m.id = (
            SELECT p.manufacturer_id
            FROM product p
            JOIN order_details od ON p.id = od.product_id
            WHERE p.product_title_id = pt.id
            GROUP BY p.manufacturer_id
            ORDER BY SUM(od.product_amount) DESC
            LIMIT 1
        )
    ) AS manufacturer
FROM product_title pt
ORDER BY product_id ASC;