CREATE PROC USP_CLIENTE_LISTAR
AS
BEGIN
  SELECT C.IdCliente ,
         C. NomCliente,
		 C.DirCliente,
		 P.NombrePais,
		 C.fonoCliente

  FROM Clientes AS C
  INNER JOIN paises AS P ON P.Idpais = C.idpais
END


CREATE PROC USP_PEDIDO_LISTAR
AS
BEGIN
  SELECT P.IdPedido,
         P.FechaPedido,
		 C.NomCliente,
		 P.DirDestinatario,
         E.ApeEmpleado+' '+E.NomEmpleado AS [Empleado]

  FROM pedidoscabe AS P
  INNER JOIN Clientes AS C ON C.IdCliente=P.IdCliente
  INNER JOIN Empleados AS E ON E.IdEmpleado =P.IdEmpleado
END

EXEC USP_CLIENTE_LISTAR
EXEC USP_PEDIDO_LISTAR
