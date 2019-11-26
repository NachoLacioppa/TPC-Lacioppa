CREATE DATABASE LACIOPPA_DB
GO
USE LACIOPPA_DB
GO

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
	GO
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
	GO
CREATE TABLE REPUESTOS(
	ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	CODIGO NVARCHAR(50) NOT NULL,
	NOMBRE NVARCHAR(30) NOT NULL,
	CANTIDAD BIGINT NOT NULL,
	PRECIO MONEY NOT NULL CHECK(PRECIO > 0),
	IDCATEGORIA INT NOT NULL FOREIGN KEY REFERENCES CATEGORIAS_REPUESTOS(ID),
	ESTADO BIT NOT NULL
	)
	GO
CREATE TABLE CATEGORIAS_REPUESTOS(
	ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	NOMBRE VARCHAR(15) NOT NULL,
	ESTADO BIT NOT NULL
	)
	GO
CREATE TABLE PERFILES_TECNICOS(
	ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	NOMBRE VARCHAR(15) NOT NULL,
	ESTADO BIT NOT NULL,
	)
	GO
CREATE TABLE EQUIPOS(
	ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	NUMEROSERIE NVARCHAR(50) NOT NULL,
	MARCA VARCHAR(20) NOT NULL,
	MODELO VARCHAR(20) NULL
	)
	GO
CREATE TABLE ESTADOS_REPARACION(
	ID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	NOMBRE VARCHAR(15) NOT NULL
	)
CREATE TABLE REPARACIONES(
--entrada
	ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	CLIENTE INT NOT NULL FOREIGN KEY REFERENCES CLIENTES(ID),
	EQUIPO INT NOT NULL FOREIGN KEY REFERENCES EQUIPOS(ID),
	TECNICO INT NOT NULL FOREIGN KEY REFERENCES TECNICOS(ID),
	ESTADO INT NOT NULL FOREIGN KEY REFERENCES ESTADOS_REPARACION(ID),
	PROBLEMA NVARCHAR(MAX) NULL,
	FECHA_ENTRADA DATETIME NOT NULL,
--salida
	--TABLA REPARACIONES X REPUESTOS HACER INNER JOIN PARA MOSTRARLO EN EL PROGRAMA
	INFORME NVARCHAR(MAX) NULL,
	PRECIO MONEY NULL,
	FECHA_SALIDA DATETIME NULL,
)

CREATE TABLE REPUESTOS_POR_REPARACIONES(
	ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	IDREPARACIONES INT NOT NULL FOREIGN KEY REFERENCES REPARACIONES(ID),
	IDREPUESTO INT NOT NULL FOREIGN KEY REFERENCES REPUESTOS(ID)
)
--FALTA TABLA DE REPARACIONES Y REPUESTO POR REPARACION


-----------QUERYS-----------

