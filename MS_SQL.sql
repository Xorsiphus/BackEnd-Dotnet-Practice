SELECT Name, CategoryName FROM Products 
    LEFT JOIN Categories on Categories.Id = Products.Category ;
