USE master
GO

CREATE DATABASE T_3
GO

USE T_3
GO

CREATE TABLE dbo.Empleado(
    IdEmpleado int primary key identity(1,1) not null,    
    Nombre nvarchar(100) not null,
    Apellidos nvarchar(100) not null,
    DNI nvarchar(8) not null,
    Email nvarchar(50) not null
)
GO 

INSERT INTO dbo.Empleado 
(Nombre, Apellidos, DNI, Email)
VALUES
('Paolo Andre', 'Guerrero Silva', '12345678', 'pguerrero@microsoft.com'),
('Juan Miguel', 'Vargas Borja', '87654321', 'jvargas@microsoft.com'),
('Lionel', 'Messi Andrade', '56781234', 'lmessi@microsoft.com'),
('Cristiano Angel', 'Ronaldo Molina', '34567890', 'cronaldo@microsoft.com'),
('Tiago Mathias', 'Alcantara Lima', '13467925', 'talcantara@microsoft.com'),
('Luis Oswaldo', 'Guadalupe Olivos', '85369524', 'lguadalupe@microsoft.com')
GO

Select IdEmpleado, Nombre, Apellidos, DNI, Email from dbo.Empleado
GO
----------------------------------------------------------------------
CREATE OR ALTER PROC USP_FILTRAR_EMPLEADOS
  @FILTRO VARCHAR(16)
AS 
BEGIN
   SELECT E.IdEmpleado,
          E.Nombre,
		  E.Apellidos,
		  E.DNI,
		  E.Email
   FROM Empleado AS E
   WHERE ( E.DNI like CONCAT(@FILTRO,'%') ) or
         ( E.Nombre like CONCAT('%',@FILTRO ,'%') ) or
         ( E.Apellidos like CONCAT('%',@FILTRO ,'%')) OR
		 (@FILTRO='')
END
GO

EXEC USP_FILTRAR_EMPLEADOS '12345678'

----------------------------------------------------------------------
CREATE OR ALTER PROC usp_obtener_empleado
@IdEmpleado INT
AS
BEGIN
  SELECT E.IdEmpleado,
         E.Nombre,
		 E.Apellidos,
		 E.DNI,
		 E.Email
  FROM Empleado E
  WHERE E.IdEmpleado=@IdEmpleado
END
------------------------------------------------------------------------

CREATE OR ALTER PROC usp_insertar_empleado
   @Nombre  VARCHAR(200),
   @Apellidos  VARCHAR(200),
   @DNI  VARCHAR(16),
   @Email  VARCHAR(100)
AS
BEGIN
    INSERT INTO Empleado(Nombre,Apellidos,DNI,Email)VALUES
	(@Nombre ,@Apellidos ,@DNI ,@Email)
END

select*from Empleado

exec usp_insertar_empleado 'Daniel','Espinoza','324234','daniel@asd'

------------------------------------------------------------------
CREATE OR ALTER PROC usp_actualizar_empleado
   @IdEmpleado INT,
   @Nombre  VARCHAR(200),
   @Apellidos  VARCHAR(200),
   @DNI  VARCHAR(16),
   @Email  VARCHAR(100)
AS
BEGIN
  UPDATE Empleado
  SET Nombre=@Nombre,
      Apellidos=@Apellidos,
	  DNI=@DNI,
	  Email=@Email
   WHERE IdEmpleado=@IdEmpleado
END
GO
---------------------------------------------------------------------
CREATE OR ALTER PROC usp_eliminar_empleado
    @IdEmpleado INT
AS
BEGIN
   DELETE Empleado
   WHERE IdEmpleado=@IdEmpleado
END
GO

usp_eliminar_empleado 10
