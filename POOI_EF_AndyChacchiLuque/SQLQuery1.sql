Create table tb_Contribuyente(
	dniCont char(8) primary key,
	nomCont varchar(50) not null,
	direcCont varchar(80) not null,
	emailCont varchar(200) not null,
	idpais char(3) references paises,
	fonoCont varchar(50)
)
INSERT INTO tb_Contribuyente (dniCont, nomCont, direcCont, emailCont, idpais, fonoCont) VALUES
('12345678', 'Juan Pérez', 'Av. Libertador 123', 'juan.perez@email.com', '002', '123456789'),
('87654321', 'María Gómez', 'Calle Falsa 456', 'maria.gomez@email.com', '001', '987654321'),
('11223344', 'Carlos Fernández', 'Paseo de la Reforma 789', 'carlos.fernandez@email.com', '001', '555123456'),
('22334455', 'Ana Torres', 'Av. de los Insurgentes 321', 'ana.torres@email.com', '003', '444987654'),
('33445566', 'Luis Martínez', 'Calle 7 654', 'luis.martinez@email.com', '006', '333123789');

select*from tb_Contribuyente

create proc usp_Crud_Contribuyente
   @indicador varchar(30),
   @dniCont char(8)    ,
   @nomCont varchar(50)    ,
   @direcCont varchar(80)    ,
   @emailCont varchar(200 )   ,
   @idpais char(3)    ,
   @fonoCont varchar(50)    
as
begin
   if(@indicador='insertar')
   begin
     insert into tb_Contribuyente(dniCont,nomCont ,direcCont,emailCont,idpais,fonoCont)
	 values                     (@dniCont,@nomCont,@direcCont,@emailCont,@idpais,@fonoCont)
   end
   if(@indicador='MostrarTodo')
   begin
     select c.dniCont,
	        c.nomCont,
			c.direcCont,
			c.emailCont,
			c.idpais,
			c.fonoCont
	 from tb_Contribuyente as c
   end

   if(@indicador='MostrarContribuyente')
   begin
     select c.dniCont,
	        c.nomCont,
			c.direcCont,
			c.emailCont,
			c.idpais,
			c.fonoCont
	 from tb_Contribuyente as c
	 where c.dniCont=@dniCont
   end

    if(@indicador='Actualizar')
   begin
     update tb_Contribuyente
	    set nomCont=@nomCont,
		   direcCont=@direcCont,
		   emailCont=@emailCont,
		   idpais=@idpais,
		   fonoCont=@fonoCont
		   where dniCont=@dniCont
   end

   if(@indicador='Eliminar')
   begin
     delete tb_Contribuyente
	 where dniCont=@dniCont
   end

   
 

end


create proc usp_combo_pais
as
begin
  select p.Idpais ,p.NombrePais
  from paises as p
end

--------------------------------------------------

create or alter proc usp_listar_proovedores
as
begin
   select s.IdProveedor,
    s.NomContacto,
    s.DirProveedor,
    s.CargoContacto,
    s.idpais,
    s.fonoProveedor,
    s.FaxProveedor,
		  COUNT(p.UnidadesEnExistencia)AS TotalUnidades
   from Proveedores as s
   inner join Productos as p on p.IdProveedor=s.IdProveedor
   group by s.IdProveedor, 
    s.NomContacto, 
    s.DirProveedor, 
    s.CargoContacto, 
    s.idpais, 
    s.fonoProveedor, 
    s.FaxProveedor
end

select*from Productos