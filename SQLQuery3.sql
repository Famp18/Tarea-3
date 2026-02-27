CREATE DATABASE GestionClientes;
GO

USE GestionClientes;
GO

CREATE TABLE Categorias (
    IdCategoria INT PRIMARY KEY IDENTITY(1,1),
    NombreCategoria VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(255)
);

CREATE TABLE Proveedores (
    IdProveedor INT PRIMARY KEY IDENTITY(1,1),
    NombreEmpresa VARCHAR(100) NOT NULL,
    Contacto VARCHAR(50),
    Telefono VARCHAR(20)
);

CREATE TABLE Clientes (
    IdCliente INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    Email VARCHAR(100),
    FechaRegistro DATETIME DEFAULT GETDATE()
);

CREATE TABLE Productos (
    IdProducto INT PRIMARY KEY IDENTITY(1,1),
    NombreProducto VARCHAR(100) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,
    Stock INT NOT NULL,
    IdCategoria INT,

    CONSTRAINT FK_Categoria_Producto FOREIGN KEY (IdCategoria) 
    REFERENCES Categorias(IdCategoria)
);

INSERT INTO Categorias (NombreCategoria, Descripcion) 
VALUES ('Electrónica', 'Dispositivos y gadgets'),
       ('Línea Blanca', 'Electrodomésticos para el hogar');

INSERT INTO Productos (NombreProducto, Precio, Stock, IdCategoria)
VALUES ('Laptop Gaming', 1200.00, 10, 1);
