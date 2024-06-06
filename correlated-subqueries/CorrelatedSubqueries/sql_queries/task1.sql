SELECT id, name
FROM city
WHERE NOT EXISTS (
    SELECT 1
    FROM street
    WHERE street.city_id = city.id
)
ORDER BY name ASC;