SELECT customers.name,
       orders.id
FROM customers
         INNER JOIN orders ON customers.id = orders.id_customers
WHERE EXTRACT(YEAR FROM orders.orders_date) = 2016
  AND EXTRACT(MONTH FROM orders_date) <= 6