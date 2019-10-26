CREATE DATABASE LACIOPPA_DB
USE LACIOPPA_DB

-------TABLAS-------
CREATE TABLE TECNICOS(
	ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	USUARIO VARCHAR(10) NOT NULL,
	CONTRASEŅA NVARCHAR(10) NOT NULL,
	IDPERFIL INT NOT NULL FOREIGN KEY REFERENCES PERFILES_TECNICOS(ID),
	NOMBRE VARCHAR(30) NOT NULL,
	APELLIDO VARCHAR(30) NOT NULL,
	DNI VARCHAR(10) NOT NULL,
	SUELDO MONEY NULL,
	ESTADO BIT NOT NULL
	)

CREATE TABLE CLIENTES(
	ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	NOMBRE VARCHAR(30) NOT NULL,
	APELLIDO VARCHAR(30) NOT NULL,
	DNI VARCHAR(10) NOT NULL,
	DIRECCION VARCHAR(15) NULL,
	LOCALIDAD VARCHAR(15) NULL,
	TELEFONO VARCHAR(10) NULL,
	MAIL VARCHAR(50) NULL,
	ESTADO BIT NOT NULL
	)
	
CREATE TABLE REPUESTOS(
	ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	NOMBRE NVARCHAR(30) NOT NULL,
	CANTIDAD BIGINT NOT NULL,
	PRECIO MONEY NOT NULL CHECK(PRECIO > 0),
	IDCATEGORIA INT NOT NULL FOREIGN KEY REFERENCES CATEGORIAS_REPUESTOS(ID),
	ESTADO BIT NOT NULL
	)

CREATE TABLE CATEGORIAS_REPUESTOS(
	ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	NOMBRE VARCHAR(15) NOT NULL,
	ESTADO BIT NOT NULL
	)

CREATE TABLE PERFILES_TECNICOS(
	ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	NOMBRE VARCHAR(15) NOT NULL,
	ESTADO BIT NOT NULL,
	)

CREATE TABLE EQUIPOS(
	ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	NUMEROSERIE BIGINT NOT NULL,
	NOMBRE VARCHAR(20) NOT NULL,
	MARCA VARCHAR(20) NULL
	)

CREATE TABLE ESTADOS_REPARACION(
	ID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	NOMBRE VARCHAR(15) NOT NULL
	)

--FALTA TABLA DE REPARACIONES, TECNICOS POR REPARACION Y REPUESTO POR REPARACION


-----------QUERYS-----------

INSERT INTO PERFILES_TECNICOS VALUES ('Administrador',1)
INSERT INTO TECNICOS VALUES ('ADMIN','1234',1,'Administrador','SUDO','12345678',1000 , 1)
SELECT * FROM TECNICOS 

SELECT * FROM PERFILES_TECNICOS


