SELECT co.id AS order_id, COUNT(od.id) AS items_count
FROM customer_order co
INNER JOIN order_details od ON co.id = od.customer_order_id
WHERE co.operation_time BETWEEN '2021-01-01' AND '2021-12-31'
GROUP BY co.id
HAVING COUNT(od.id) > (SELECT AVG(items_count) FROM (SELECT COUNT(id) AS items_count FROM order_details GROUP BY customer_order_id) AS avg_items_count)
ORDER BY items_count ASC, order_id ASC;