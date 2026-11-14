-- Crear base de datos
create Database Tienda; 

use Tienda;

-- Crear la tabla Clientes
CREATE table Clientes (
Idcliente INT Auto_increment Primary key,
Nombre VARCHAR(120) NOT NULL,
Correo VARCHAR(255) NOT NULL
);

-- Insertar datos 
INSERT INTO Clientes (Nombre, Correo) VALUES ('Juan Pérez', 'juan@mail.com');
INSERT INTO Clientes (Nombre, Correo) VALUES ('Ana López', 'ana@mail.com');

-- Eliminar datos 
DELETE FROM Clientes WHERE Nombre = 'Ana López';

-- Borrar base de datos 
DROP DATABASE Tienda;

select * from Clientes;  

