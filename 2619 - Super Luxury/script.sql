SELECT products.name  AS "name",
       providers.name AS "name",
       products.price
FROM products,
     providers,
     categories
WHERE products.id_providers = providers.id
  AND products.id_categories = categories.id
  AND categories.name = 'Super Luxury'
  AND products.price > 1000;