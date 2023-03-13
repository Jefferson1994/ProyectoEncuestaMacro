use EncuestaMacro
go

if object_id('sp_buscar_clientes') is not null
	drop procedure sp_buscar_clientes
go

/*====================================================================================
--autor:		  jsarango
--Fecha creacion: 11/03/2023
--Descripcion:    Buscar clientes.
--====================================================================================*/
create procedure sp_buscar_clientes
(
	@cedula			varchar(10)
)
as

	 SELECT 	cli.IdCliente as IdCliente,
	 			cli.Nombre as Nombre,
		        cli.Apellido as Apellido,
		        cli.Cedula as Cedula,
		        cli.Edad as Edad
	FROM clientes cli
	WHERE cli.Cedula = @cedula
go

