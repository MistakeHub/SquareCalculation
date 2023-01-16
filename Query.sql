SELECT  products.titleofproduct AS 'Продукт', 
 categories.titleofcategory AS 'Категория' 
FROM productandcategory.products 
LEFT JOIN productandcategory.categories 
 ON products.id = categories.id