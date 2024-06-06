-- Inserting data into the 'city' table
INSERT INTO city (name) VALUES
    ('New York'),
    ('Los Angeles'),
    ('Chicago');

-- Inserting data into the 'street' table
INSERT INTO street (name, city_id) VALUES
    ('Broadway St', 1),
    ('Sunset Blvd', 2),
    ('Michigan Ave', 3),
    ('Main St', 1),
    ('Hollywood Blvd', 2);

-- Inserting data into the 'supermarket' table
INSERT INTO supermarket (name, street_id, house_number) VALUES
    ('Supermart A', 1, '123'),
    ('Supermart B', 2, '456'),
    ('Supermart C', 3, '789'),
    ('Supermart D', 4, '101'),
    ('Supermart E', 5, '202'),
    ('Supermart F', 1, '345'),
    ('Supermart G', 3, '567');

-- Inserting data into the 'person' table
INSERT INTO person (name, surname, birth_date) VALUES
    ('John', 'Doe', '1990-05-15'),
    ('Jane', 'Smith', '1985-10-20'),
    ('Michael', 'Johnson', '1978-03-08'),
    ('Emily', 'Brown', '1995-12-25'),
    ('David', 'Wilson', '1980-07-14'),
    ('Sarah', 'Taylor', '1992-09-30'),
    ('James', 'Martinez', '1987-02-18'),
    ('Jennifer', 'Anderson', '1973-11-05'),
    ('Daniel', 'Thomas', '1983-06-10'),
    ('Lisa', 'Hernandez', '1970-08-22');

-- Inserting data into the 'contact_type' table
INSERT INTO contact_type (name) VALUES
    ('Email'),
    ('Phone');

-- Inserting data into the 'person_contact' table
INSERT INTO person_contact (person_id, contact_type_id, contact_value) VALUES
    (1, 1, 'john.doe@example.com'),
    (1, 2, '123-456-7890'),
    (2, 1, 'jane.smith@example.com'),
    (2, 2, '234-567-8901'),
    (3, 1, 'michael.johnson@example.com'),
    (3, 2, '345-678-9012'),
    (4, 1, 'emily.brown@example.com'),
    (4, 2, '456-789-0123'),
    (5, 1, 'david.wilson@example.com'),
    (5, 2, '567-890-1234'),
    (6, 1, 'sarah.taylor@example.com'),
    (6, 2, '678-901-2345'),
    (7, 1, 'james.martinez@example.com'),
    (7, 2, '789-012-3456'),
    (8, 1, 'jennifer.anderson@example.com'),
    (8, 2, '890-123-4567'),
    (9, 1, 'daniel.thomas@example.com'),
    (9, 2, '901-234-5678'),
    (10, 1, 'lisa.hernandez@example.com'),
    (10, 2, '012-345-6789');

-- Inserting data into the 'customer' table
INSERT INTO customer (person_id, card_number, discount) VALUES
    (1, 1234567890, 0.05),
    (2, 2345678901, 0.1),
    (3, 3456789012, 0.15),
    (4, 4567890123, 0.2),
    (5, 5678901234, 0.05),
    (6, 6789012345, 0.1),
    (7, 7890123456, 0.15),
    (8, 8901234567, 0.2),
    (9, 9012345678, 0.05),
    (10, 1234567890, 0.1);

-- Inserting data into the 'product_category' table
INSERT INTO product_category (name) VALUES
    ('Electronics'),
    ('Clothing'),
    ('Grocery');

-- Inserting data into the 'product_title' table
INSERT INTO product_title (title, product_category_id) VALUES
    ('Laptop', 1),
    ('Smartphone', 1),
    ('T-Shirt', 2),
    ('Jeans', 2),
    ('Milk', 3),
    ('Bread', 3),
    ('Eggs', 3),
    ('Cereal', 3),
    ('Socks', 2),
    ('Dress', 2);

-- Inserting data into the 'manufacturer' table
INSERT INTO manufacturer (name) VALUES
    ('Apple'),
    ('Samsung'),
    ('Nike'),
    ('Adidas');

-- Inserting data into the 'product' table
INSERT INTO product (product_title_id, manufacturer_id, price, comment) VALUES
    (1, 1, 999.99, 'High-performance laptop'),
    (2, 2, 799.99, 'Flagship smartphone'),
    (3, 3, 19.99, 'Cotton T-Shirt'),
    (4, 3, 59.99, 'Slim-fit jeans'),
    (5, 4, 2.49, 'Whole milk'),
    (6, 4, 1.99, 'Whole wheat bread'),
    (7, 4, 1.99, 'Large eggs'),
    (8, 4, 3.49, 'Honey nut cereal'),
    (9, 3, 9.99, 'Ankle socks'),
    (10, 3, 49.99, 'Summer dress');

-- Inserting data into the 'customer_order' table
INSERT INTO customer_order (operation_time, supermarket_id, customer_id) VALUES
    ('2024-03-12 08:00:00', 1, 1),
    ('2024-03-12 08:15:00', 2, 2),
    ('2024-03-12 08:30:00', 3, 3),
    ('2024-03-12 08:45:00', 4, 4),
    ('2024-03-12 09:00:00', 5, 5),
    ('2024-03-12 09:15:00', 6, 6),
    ('2024-03-12 09:30:00', 7, 7),
    ('2024-03-12 09:45:00', 1, 8),
    ('2024-03-12 10:00:00', 2, 9),
    ('2024-03-12 10:15:00', 3, 10);

-- Inserting data into the 'order_details' table
INSERT INTO order_details (customer_order_id, product_id, price, price_with_discount, product_amount) VALUES
    (1, 1, 999.99, 949.99, 1),
    (2, 2, 799.99, 719.99, 1),
    (3, 3, 19.99, 17.99, 2),
    (4, 4, 59.99, 47.99, 1),
    (5, 5, 2.49, 2.24, 3),
    (6, 6, 1.99, 1.79, 2),
    (7, 7, 1.99, 1.79, 1),
    (8, 8, 3.49, 2.79, 2),
    (9, 9, 9.99, 8.99, 1),
    (10, 10, 49.99, 44.99, 1),
    (1, 2, 799.99, 759.99, 1),
    (2, 3, 19.99, 17.99, 1),
    (3, 4, 59.99, 53.99, 1),
    (4, 5, 2.49, 2.24, 2),
    (5, 6, 1.99, 1.79, 1),
    (6, 7, 1.99, 1.79, 2),
    (7, 8, 3.49, 2.79, 1),
    (8, 9, 9.99, 8.99, 2),
    (9, 10, 49.99, 44.99, 1),
    (10, 1, 999.99, 949.99, 1);