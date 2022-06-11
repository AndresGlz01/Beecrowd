SELECT products.name   AS "name",
       providers.name  AS "name",
       categories.name AS "name"
FROM products,
     providers,
     categories
WHERE products.id_providers = providers.id
  AND products.id_categories = categories.id
  AND providers.name = 'Sansul SA'
  AND categories.name = 'Imported';