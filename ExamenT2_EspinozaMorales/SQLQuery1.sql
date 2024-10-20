
SET DATEFORMAT dmy;

 --Creacion de la base de datos
CREATE DATABASE SistemaTickets;
USE SistemaTickets;



-- Tabla Categoria
CREATE TABLE Categoria (
    CategoriaID INT PRIMARY KEY IDENTITY,
    Nombre VARCHAR(100) NOT NULL,
    Descripcion TEXT
);

-- Tabla Tipo
CREATE TABLE Tipo (
    TipoID INT PRIMARY KEY IDENTITY,
    CategoriaID INT,
    Nombre VARCHAR(100) NOT NULL,
    Descripcion TEXT,
    FOREIGN KEY (CategoriaID) REFERENCES Categoria(CategoriaID)
);

-- Tabla Item
CREATE TABLE Item (
    ItemID INT PRIMARY KEY IDENTITY,
    TipoID INT,
    Descripcion TEXT NOT NULL,
    FOREIGN KEY (TipoID) REFERENCES Tipo(TipoID)
);

-- Tabla Agencia
CREATE TABLE Agencia (
    AgenciaID INT PRIMARY KEY IDENTITY,
    Nombre VARCHAR(100) NOT NULL,
    Direccion TEXT,
    Area VARCHAR(100),
    Distrito VARCHAR(100),
    Provincia VARCHAR(100),
    Departamento VARCHAR(100)
);

-- Tabla Calendario
CREATE TABLE Calendario (
    Fecha DATE PRIMARY KEY,
    Ano INT,
    Trimestre INT,
    Mes INT,
    Semana INT,
    Dia INT
);

-- Tabla Proveedor
CREATE TABLE Proveedor (
    ProveedorID INT PRIMARY KEY IDENTITY,
    Proveedor VARCHAR(100) NOT NULL,
    Descripcion TEXT,
    Representante VARCHAR(100)
);

-- Tabla Tickets
CREATE TABLE Tickets (
    TicketID INT PRIMARY KEY IDENTITY,
    ItemID INT,
    AgenciaID INT,
    FechaCreacion DATE,
    FechaCierre DATE,
    ServiceDesk VARCHAR(100),
    Resumen TEXT,
    EstadoID INT,
    FOREIGN KEY (ItemID) REFERENCES Item(ItemID),
    FOREIGN KEY (AgenciaID) REFERENCES Agencia(AgenciaID)
);

-- Tabla Atenciones
create TABLE Atenciones (
    TicketID INT,
    FechaProgramada DATE,
    ProveedorID INT,
    ItemID INT,
    TipoTicket VARCHAR(100),
    EstadoID INT,
    CostoAtencion DECIMAL(10, 2),
	VISIBILIDAD int
);
GO


-- Inserciones para la tabla Atenciones
INSERT INTO Atenciones (TicketID, FechaProgramada, ProveedorID, ItemID, TipoTicket, EstadoID, CostoAtencion)
VALUES (1, '2024-01-15', 1, 1, 'Reparaci�n', 1, 1500.00);

INSERT INTO Atenciones (TicketID, FechaProgramada, ProveedorID, ItemID, TipoTicket, EstadoID, CostoAtencion)
VALUES (2, '2024-02-16', 2, 2, 'Mantenimiento', 2, 800.00);

INSERT INTO Atenciones (TicketID, FechaProgramada, ProveedorID, ItemID, TipoTicket, EstadoID, CostoAtencion)
VALUES (3, '2024-03-14', 3, 3, 'Reinstalaci�n', 3, 1200.00);

INSERT INTO Atenciones (TicketID, FechaProgramada, ProveedorID, ItemID, TipoTicket, EstadoID, CostoAtencion)
VALUES (4, '2024-04-24', 4, 4, 'Soluci�n de errores', 1, 2500.00);

INSERT INTO Atenciones (TicketID, FechaProgramada, ProveedorID, ItemID, TipoTicket, EstadoID, CostoAtencion)
VALUES (5, '2024-05-12', 5, 5, 'Mejora de red', 2, 1800.00);
GO
update Atenciones
set VISIBILIDAD=1
go
-- Inserciones para la tabla Categoria
INSERT INTO Categoria (Nombre, Descripcion) 
VALUES ('Hardware', 'Componentes f�sicos de los sistemas inform�ticos');

INSERT INTO Categoria (Nombre, Descripcion) 
VALUES ('Software', 'Programas y aplicaciones utilizadas en los sistemas');

INSERT INTO Categoria (Nombre, Descripcion) 
VALUES ('Redes', 'Infraestructura y protocolos de comunicaci�n entre dispositivos');

INSERT INTO Categoria (Nombre, Descripcion) 
VALUES ('Seguridad', 'Medidas para proteger la integridad y confidencialidad de los datos');

INSERT INTO Categoria (Nombre, Descripcion) 
VALUES ('Soporte T�cnico', 'Asistencia t�cnica a usuarios y sistemas inform�ticos');
-- Inserciones para la tabla Tipo
INSERT INTO Tipo (CategoriaID, Nombre, Descripcion) 
VALUES (1, 'Servidores', 'Equipos especializados para alojar aplicaciones y servicios');

INSERT INTO Tipo (CategoriaID, Nombre, Descripcion) 
VALUES (1, 'Equipos de Escritorio', 'PCs, laptops y otros dispositivos de trabajo');

INSERT INTO Tipo (CategoriaID, Nombre, Descripcion) 
VALUES (2, 'Sistemas Operativos', 'Software que gestiona los recursos del hardware');

INSERT INTO Tipo (CategoriaID, Nombre, Descripcion) 
VALUES (2, 'Aplicaciones Empresariales', 'Software especializado para operaciones empresariales');

INSERT INTO Tipo (CategoriaID, Nombre, Descripcion) 
VALUES (3, 'Redes LAN', 'Redes locales de �rea limitada como oficinas');
-- Inserciones para la tabla Item
INSERT INTO Item (TipoID, Descripcion)
VALUES (1, 'Servidor Dell PowerEdge R740');

INSERT INTO Item (TipoID, Descripcion)
VALUES (2, 'PC Lenovo ThinkCentre M720');

INSERT INTO Item (TipoID, Descripcion)
VALUES (3, 'Windows 10 Pro');

INSERT INTO Item (TipoID, Descripcion)
VALUES (4, 'ERP SAP Business One');

INSERT INTO Item (TipoID, Descripcion)
VALUES (5, 'Router Cisco Catalyst 9200');
-- Inserciones para la tabla Agencia
INSERT INTO Agencia (Nombre, Direccion, Area, Distrito, Provincia, Departamento)
VALUES ('Agencia Central', 'Av. Principal 123', 'Soporte TI', 'Miraflores', 'Lima', 'Lima');

INSERT INTO Agencia (Nombre, Direccion, Area, Distrito, Provincia, Departamento)
VALUES ('Agencia Sur', 'Av. Sur 456', 'Redes', 'Surco', 'Lima', 'Lima');

INSERT INTO Agencia (Nombre, Direccion, Area, Distrito, Provincia, Departamento)
VALUES ('Agencia Norte', 'Jr. Los Olivos 789', 'Desarrollo', 'Los Olivos', 'Lima', 'Lima');

INSERT INTO Agencia (Nombre, Direccion, Area, Distrito, Provincia, Departamento)
VALUES ('Agencia Este', 'Calle San Juan 321', 'Administraci�n', 'Ate', 'Lima', 'Lima');

INSERT INTO Agencia (Nombre, Direccion, Area, Distrito, Provincia, Departamento)
VALUES ('Agencia Callao', 'Av. Faucett 654', 'Seguridad', 'Callao', 'Callao', 'Callao');
-- Inserciones para la tabla Calendario
INSERT INTO Calendario (Fecha, Ano, Trimestre, Mes, Semana, Dia)
VALUES ('2024-01-15', 2024, 1, 1, 3, 15);

INSERT INTO Calendario (Fecha, Ano, Trimestre, Mes, Semana, Dia)
VALUES ('2024-04-20', 2024, 2, 4, 16, 20);

INSERT INTO Calendario (Fecha, Ano, Trimestre, Mes, Semana, Dia)
VALUES ('2024-07-10', 2024, 3, 7, 28, 10);

INSERT INTO Calendario (Fecha, Ano, Trimestre, Mes, Semana, Dia)
VALUES ('2024-09-05', 2024, 3, 9, 36, 5);

INSERT INTO Calendario (Fecha, Ano, Trimestre, Mes, Semana, Dia)
VALUES ('2024-12-01', 2024, 4, 12, 48, 1);
-- Inserciones para la tabla Proveedor
INSERT INTO Proveedor (Proveedor, Descripcion, Representante)
VALUES ('Tech Solutions S.A.', 'Proveedor de equipos de c�mputo', 'Carlos Garc�a');

INSERT INTO Proveedor (Proveedor, Descripcion, Representante)
VALUES ('SoftWarex', 'Consultor�a en desarrollo de software', 'Ana Fern�ndez');

INSERT INTO Proveedor (Proveedor, Descripcion, Representante)
VALUES ('NetWork Solutions', 'Implementaci�n de redes y telecomunicaciones', 'Jos� Ram�rez');

INSERT INTO Proveedor (Proveedor, Descripcion, Representante)
VALUES ('SeguriPro', 'Soluciones de seguridad inform�tica', 'Laura Villanueva');

INSERT INTO Proveedor (Proveedor, Descripcion, Representante)
VALUES ('DataExperts', 'Consultores en gesti�n de datos y almacenamiento', 'Luis Torres');
-- Inserciones para la tabla Tickets
INSERT INTO Tickets (ItemID, AgenciaID, FechaCreacion, FechaCierre, ServiceDesk, Resumen, EstadoID)
VALUES (1, 1, '2024-01-10', '2024-01-20', 'Desk001', 'Falla en el servidor', 1);

INSERT INTO Tickets (ItemID, AgenciaID, FechaCreacion, FechaCierre, ServiceDesk, Resumen, EstadoID)
VALUES (2, 2, '2024-02-15', '2024-02-17', 'Desk002', 'PC no enciende', 2);

INSERT INTO Tickets (ItemID, AgenciaID, FechaCreacion, FechaCierre, ServiceDesk, Resumen, EstadoID)
VALUES (3, 3, '2024-03-12', '2024-03-15', 'Desk003', 'Problema con el sistema operativo', 3);

INSERT INTO Tickets (ItemID, AgenciaID, FechaCreacion, FechaCierre, ServiceDesk, Resumen, EstadoID)
VALUES (4, 4, '2024-04-22', '2024-04-25', 'Desk004', 'Error en aplicaci�n ERP', 1);

INSERT INTO Tickets (ItemID, AgenciaID, FechaCreacion, FechaCierre, ServiceDesk, Resumen, EstadoID)
VALUES (5, 5, '2024-05-10', '2024-05-18', 'Desk005', 'Problema de conectividad de red', 2);


----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
create proc usp_CRUD_TICKETS
 @Indicador VARCHAR(20),
 @TicketID  INT, 
 @FechaCreacion  DATETIME, 
 @FechaCierre  DATETIME, 
 @ItemID  INT, 
 @AgenciaID  INT,
 @Resumen TEXT
AS 
BEGIN
   IF @Indicador='SELECCIONAXID'
   BEGIN
     SELECT   TicketID,
	          FechaCreacion,
	          FechaCierre,
			  ItemID,
			  AgenciaID,
			  Resumen
	 FROM Tickets 
	 WHERE @TicketID=TicketID
   END

    IF @Indicador='SELECCIONATODO'
   BEGIN
     SELECT   TicketID,
	          FechaCreacion,
	          FechaCierre,
			  ItemID,
			  AgenciaID,
			  Resumen
	 FROM Tickets
   END

   IF @Indicador='CREATE'
   BEGIN
     INSERT INTO Tickets
	 (
	 FechaCreacion,
	 FechaCierre,
	 ItemID,
	 AgenciaID,
	 Resumen
	 ) VALUES
	 (
	 @FechaCreacion,
	 @FechaCierre,
	 @ItemID,
	 @AgenciaID,
	 @Resumen
	 )
   END

   IF @Indicador='DELETE'
   BEGIN
     DELETE FROM Tickets 
	 WHERE TicketID =@TicketID
   END

   IF @Indicador='UPDATE'
   BEGIN
     UPDATE Tickets 
	    SET 
		FechaCreacion=@FechaCreacion,
		FechaCierre=@FechaCierre,
		ItemID=@ItemID,
		AgenciaID=@AgenciaID,
		Resumen=@Resumen 
		where TicketID=@TicketID
   END

END


----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------


create or alter proc usp_CRUD_TIPO
 @Indicador VARCHAR(20),
 @TipoID  int, 
 @CategoriaID  int, 
 @Nombre  varchar(100), 
 @Descripcion  text
AS 
BEGIN
   IF @Indicador='SELECCIONAXID'
   BEGIN
     SELECT  TipoID,
	         CategoriaID,
	         Nombre,
			 Descripcion
	 FROM Tipo 
	 WHERE TipoID=@TipoID and
	       Activo=1

   END

    IF @Indicador='SELECCIONATODO'
   BEGIN
     SELECT  TipoID,
	         CategoriaID,
	         Nombre,	
			 Descripcion
	 FROM Tipo
	 where Activo=1
   END

   IF @Indicador='CREATE'
   BEGIN
     INSERT INTO Tipo
	 (
	 CategoriaID,
	 Nombre,
	 Descripcion,
	 Activo
	 ) VALUES
	 (
	 @CategoriaID,
	 @Nombre,
     @Descripcion,
	 1

	 )
   END

   IF @Indicador='DELETE'
   BEGIN
     update Tipo
	 set Activo =0
	 where TipoID=@TipoID
   END

   IF @Indicador='UPDATE'
   BEGIN
     UPDATE Tipo 
	    SET 
	 CategoriaID=@CategoriaID,
	 Nombre=@Nombre,
	 Descripcion=@Descripcion
		where TipoID =@TipoID
   END

END

----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------

create or alter proc      usp_listarCategoria
as
begin
  select CategoriaID,Nombre
  from Categoria
end
go
create  or alter     proc      USP_LISTAR_ITEM
as 
begin
  select ItemID,Descripcion
  from Item
end
go

create  or alter    proc     USP_LISTAR_AGENCIA
as
begin
  select AgenciaID,Nombre
  from Agencia
end
go
CREATE  or alter    PROC       USP_LISTAR_TICKETS
AS
BEGIN
   SELECT T.TicketID,T.Resumen
   FROM Tickets AS T
END
go
create  or alter    proc     usp_listar_proovedor
as
begin
   select a.ProveedorID,a.Proveedor
   from Proveedor as a
end
go
create  or alter    proc     usp_listar_estado
as
begin
   select a.EstadoID
   from Atenciones as a
end
go
--------------------------------------------------------------------------------
--------------------------------------------------------------------------------
UPDATE Atenciones
SET VISIBILIDAD=1

exec usp_CRUD_AtencionES 'SELECCIONAXID',1,'',0,0,'',0,0

EXEC usp_CRUD_AtencionES 'CREATE', 2, '11/11/2001', 1, 1, 'Tipo', 1, 11

create or alter proc usp_CRUD_AtencionES
 @Indicador VARCHAR(20),
 @IDTICKET INT,
 @FECHAPROGRAMADA DATE,
 @PROVEDORID INT,
 @IDITEM INT,
 @TIPOtICKET VARCHAR(100),
 @ESTADOID INT,
 @COSTOATENCION DECIMAL

AS 
BEGIN
   IF @Indicador='SELECCIONAXID'
   BEGIN
     SELECT A.TicketID,
	        LEFT(A.FechaProgramada,12),
			A.ProveedorID,
			A.ItemID,
			A.TipoTicket,
			A.EstadoID,
			A.CostoAtencion
	 FROM Atenciones AS A
	 WHERE A.TicketID=@IDTICKET AND
	       A.VISIBILIDAD=1

   END

    IF @Indicador='SELECCIONATODO'
   BEGIN
     SELECT A.TicketID,
	        LEFT(A.FechaProgramada,12),
			A.ProveedorID,
			A.ItemID,
			A.TipoTicket,
			A.EstadoID,
			A.CostoAtencion
	FROM Atenciones AS A WHERE VISIBILIDAD=1
   END

   IF @Indicador='CREATE'
   BEGIN
     INSERT INTO Atenciones
	 (
         TicketID,
	     FechaProgramada,
         ProveedorID,
         ItemID,
         TipoTicket,
         EstadoID,
         CostoAtencion,
		 VISIBILIDAD
	 ) VALUES
	 (
	 @IDTICKET ,
     @FECHAPROGRAMADA ,
     @PROVEDORID ,
     @IDITEM ,
     @TIPOtICKET ,
     @ESTADOID ,
     @COSTOATENCION ,
	 1
	 )
   END

   IF @Indicador='DELETE'
   BEGIN
     update Atenciones
	 set VISIBILIDAD =0
	 where TicketID=@IDTICKET
   END

   IF @Indicador='UPDATE'
   BEGIN
     UPDATE Atenciones 
	    SET 
	     TicketID=@IDTICKET,
	     FechaProgramada=@FECHAPROGRAMADA,
         ProveedorID=@PROVEDORID,
         ItemID=@IDITEM,
         TipoTicket=@TIPOtICKET,
         EstadoID=@ESTADOID,
         CostoAtencion=@COSTOATENCION
		 WHERE TicketID=@IDTICKET
   END

END



create or alter proc usp_Buscar_Agencia
 @agenciaID int,
 @nombre varchar(30),
 @Distrito varchar(30)

as 
begin
  select*
  from Agencia
  where (AgenciaID=@agenciaID or @agenciaID='' )and
        (Nombre like '%'+@nombre+'%' or @nombre='' )and
		(Distrito like '%'+@Distrito+'%' or @Distrito ='')
        
end
go

exec usp_Buscar_Agencia '','','Mirafl'










