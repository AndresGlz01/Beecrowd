SELECT categories.name      AS "name",
       sum(products.amount) AS "sum"
FROM products
         INNER JOIN categories ON products.id_categories = categories.id
GROUP BY categories.id;