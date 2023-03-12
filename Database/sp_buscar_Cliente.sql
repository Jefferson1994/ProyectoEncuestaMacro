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
	@codigo			int,
	@tipo			varchar(45)
)
as

	 


	if @tipo = 'buscarcliente'
	begin
	
		 SELECT cli.Nombre as Nombre,
		        cli.Apellido as Apellido,
		        cli.Cedula as Cedula,
		        cli.Edad as Edad
        FROM clientes cli
        WHERE (cli.Cedula=@codigo)

	end

	

go

