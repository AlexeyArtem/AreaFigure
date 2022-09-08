SELECT dbo.Product.Name as 'Name product', dbo.Category.Name as 'Name category' FROM dbo.Product
LEFT JOIN dbo.ProductsCategories ON dbo.Product.Id = dbo.ProductsCategories.PrdouctId
LEFT JOIN dbo.Category on dbo.Category.Id = dbo.ProductsCategories.CategoryId