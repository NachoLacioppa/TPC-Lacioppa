--CLIENTES
--VISTA PARA BUSCAR CLIENTES ACTIVOS
create view VW_Buscar_Clientes AS select nombre, apellido, dni, direccion, localidad, telefono, mail from Clientes where estado = 1
select * from VW_Buscar_Clientes

--AGREGAR CLIENTE
CREATE PROCEDURE SP_InsertarCliente
(@nombre varchar(30), @apellido varchar(30), @dni varchar(10), @direccion varchar(15), @localidad varchar(15), @telefono varchar(10), @mail varchar(50), @estado bit)
AS
BEGIN
INSERT INTO Clientes VALUES (@nombre, @apellido, @dni, @direccion, @localidad, @telefono, @mail, 1)
END

--MODIFICAR CLIENTE
CREATE PROCEDURE SP_ModificarCliente(
    @nombre varchar(30), 
    @apellido varchar(30), 
    @dni varchar(10), 
    @direccion varchar(15), 
    @localidad varchar(15), 
    @telefono varchar(10), 
    @mail varchar(50), 
    @estado bit
)
AS
BEGIN
UPDATE CLIENTES SET nombre = @nombre, apellido = @apellido, dni = @dni, direccion = @direccion, localidad = @localidad, telefono = @telefono, mail = @mail , ESTADO = 1
where dni = @dni
END

--VALIDAR DNI
CREATE PROCEDURE SP_BuscarDNI(
    @DNI VARCHAR(10)
)
AS
BEGIN
Select id, dni, estado from Clientes where dni = @dni and estado = 1
END

select * from CLIENTES
