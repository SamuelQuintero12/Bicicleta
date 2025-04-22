-- Crear la base de datos
DROP DATABASE IF EXISTS tienda_db;
CREATE DATABASE tienda_db;
USE tienda_db;

-- Tabla de Proveedores
CREATE TABLE proveedores (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(255) NOT NULL,
    direccion VARCHAR(255) NOT NULL,
    telefono VARCHAR(20),
    email VARCHAR(255) UNIQUE,
    fecha_creacion TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Tabla de Productos
CREATE TABLE productos (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(255) NOT NULL,
    descripcion TEXT,
    precio DECIMAL(10,2) NOT NULL,
    cantidad INT DEFAULT 0,
    imagen LONGBLOB,
    fecha_agregado TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    id_proveedor INT,
    FOREIGN KEY (id_proveedor) REFERENCES proveedores(id)
);
DELIMITER //
CREATE PROCEDURE RegistrarUsuario(
    IN p_nombre VARCHAR(100),
    IN p_email VARCHAR(100),
    IN p_contraseña VARCHAR(255),
    IN p_rol VARCHAR(50)
)
BEGIN
    INSERT INTO usuarios (nombre, email, contraseña, rol)
    VALUES (p_nombre, p_email, p_contraseña, p_rol);
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE BuscarUsuarioPorEmail(IN p_email VARCHAR(100))
BEGIN
    SELECT id, nombre, email, contraseña, rol
    FROM usuarios
    WHERE email = p_email;
END //
DELIMITER ;



-- Tabla de Inventarios
CREATE TABLE inventarios (
    id INT PRIMARY KEY AUTO_INCREMENT,
    id_producto INT,
    cantidad INT,
    tipo_accion ENUM('entrada','salida'),
    fecha TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (id_producto) REFERENCES productos(id)
);

-- Tabla de Usuarios
CREATE TABLE usuarios (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(255) NOT NULL,
    email VARCHAR(255) UNIQUE NOT NULL,
    contraseña VARCHAR(255) NOT NULL,
    rol ENUM('vendedor', 'administrador') NOT NULL,
    fecha_creacion TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Tabla de Ventas
CREATE TABLE ventas (
    id INT PRIMARY KEY AUTO_INCREMENT,
    id_usuario INT,
    fecha_venta TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    total DECIMAL(10,2),
    FOREIGN KEY (id_usuario) REFERENCES usuarios(id)
);

-- Tabla de Ventas_Productos
CREATE TABLE ventas_productos (
    id INT PRIMARY KEY AUTO_INCREMENT,
    id_venta INT,
    id_producto INT,
    cantidad INT,
    precio_unitario DECIMAL(10,2),
    FOREIGN KEY (id_venta) REFERENCES ventas(id),
    FOREIGN KEY (id_producto) REFERENCES productos(id)
);

-- Tabla de Facturas
CREATE TABLE facturas (
    id INT PRIMARY KEY AUTO_INCREMENT,
    id_venta INT,
    monto_total DECIMAL(10,2),
    fecha TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (id_venta) REFERENCES ventas(id)
);

-- Índices para optimización
CREATE INDEX idx_productos_nombre ON productos(nombre);
CREATE INDEX idx_ventas_fecha ON ventas(fecha_venta);
CREATE INDEX idx_usuarios_email ON usuarios(email);
