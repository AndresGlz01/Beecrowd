SELECT CONCAT(SUBSTR(natural_person.cpf, 1, 3), '.', SUBSTR(natural_person.cpf, 4, 3), '.',
              SUBSTR(natural_person.cpf, 7,
                     3), '-', SUBSTR(natural_person.cpf, 10, 2)) AS "CPF"
FROM customers
         INNER JOIN natural_person ON customers.id = natural_person.id_customers;