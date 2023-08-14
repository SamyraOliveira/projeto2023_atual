

ALTER VIEW vw_pedidosCliColab
AS 
SELECT
		Pedidos.codigo_Pedido AS 'Codigo Pedido',
		Clientes.codigo_Cliente AS 'Codigo Cliente',
		Clientes.nome_Cliente AS 'Cliente', 
		Colaboradores.codigo_Colaborador AS 'Codigo Atendente',
		Colaboradores.nome_Colaborador AS 'Atendente'
FROM

Clientes

	INNER JOIN Pedidos ON Pedidos.codigo_Cliente = Clientes.codigo_Cliente
	INNER JOIN Colaboradores ON Pedidos.codigo_Colaborador = Colaboradores.codigo_Colaborador

WHERE 

Colaboradores.cargo_Colaborador = 'Atendente'

SELECT * FROM vw_pedidosCliColab


SELECT * FROM Pedidos



