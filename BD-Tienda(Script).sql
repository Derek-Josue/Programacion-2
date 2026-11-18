-- creacion de la bd
Create database Tienda;

use tienda;

Create table Categoria (
    Codigo INT PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL
);

CREATE TABLE Producto (
    Codigo INT PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,
    Cantidad INT NOT NULL,
    Categoria INT NOT NULL,
    FOREIGN KEY (Categoria) REFERENCES Categoria(Codigo)
);

INSERT INTO Categoria (Codigo, Nombre) VALUES 
(1, 'Electrónica'),
(2, 'Ropa y Accesorios');

INSERT INTO Producto (Codigo, Nombre, Precio, Cantidad, Categoria) VALUES 
(101, 'Smartphone', 299.99, 15, 1),
(102, 'Laptop Gamer', 899.50, 5, 1),
(103, 'Camisa Casual', 25.00, 30, 2);

DELETE FROM Producto 
WHERE Codigo = 103;

DROP DATABASE Tienda;
