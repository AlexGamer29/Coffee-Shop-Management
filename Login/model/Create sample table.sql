-- Add Categories
INSERT dbo.Categories (name)
VALUES (N'Cà phê Việt Nam')

INSERT dbo.Categories (name)
VALUES (N'Cà phê máy')

INSERT dbo.Categories (name)
VALUES (N'Cà phê Đá xay')

INSERT dbo.Categories (name)
VALUES (N'Cold Brew')

INSERT dbo.Categories (name)
VALUES (N'Trà trái cây')

INSERT dbo.Categories (name)
VALUES (N'Macchiato')

INSERT dbo.Categories (name)
VALUES (N'Thức uống trái cây')

INSERT dbo.Categories (name)
VALUES (N'Matcha - Sôcôla')

-- Add menu
INSERT dbo.Menu(name, idCategories, price)
VALUES(N'Cà phê đen', 1, 35000)

INSERT dbo.Menu(name, idCategories, price)
VALUES(N'Espresso / Americano', 2, 45000)

INSERT dbo.Menu(name, idCategories, price)
VALUES(N'Cold Brew truyền thống', 4, 45000)

INSERT dbo.Menu(name, idCategories, price)
VALUES(N'Trà đào cam sả', 5, 52000)

INSERT dbo.Menu(name, idCategories, price)
VALUES(N'Trà lài Macchiato', 6, 48000)

INSERT dbo.Menu(name, idCategories, price)
VALUES(N'Cà phê đá xay', 3, 59000)

INSERT dbo.Menu(name, idCategories, price)
VALUES(N'Sinh tố việt quất', 7, 59000)

INSERT dbo.Menu(name, idCategories, price)
VALUES(N'Matcha Latte', 8, 59000)