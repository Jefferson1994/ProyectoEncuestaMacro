use EncuestaMacro
go

if object_id('sp_listar_Catalogo') is not null
	drop procedure sp_listar_Catalogo
go

/*====================================================================================
--autor:		  jsarango
--Fecha creacion: 11/03/2023
--Descripcionn:    Obtiene clientes.
--====================================================================================*/
create procedure sp_listar_Catalogo
(
	@codigo			int,
	@tipo			varchar(45)
)
as

	if @tipo = 'provincias'
	begin 
	
		select 	IdProvincia as Codigo,
				Nombre 		as Descripcion
		from provincias
		
	end 


	if @tipo = 'cantones'
	begin
		select 	c.IdCanton 	as Codigo, 
				c.Nombre 	as Descripcion
		FROM cantones c
		JOIN provincias p
		ON (c.IdProvinciaFK=p.IdProvincia)

	end

	if @tipo = 'sucursales'
	begin
	
		select 	su.IdSucursal 	as Codigo, 
				su.Sucursal 	as SUCURSAL,
				c.Nombre        as Canton
		FROM sucursales su
			JOIN cantones c
				on ( c.IdCanton = su.IdCantonFK )
		

	end

    if @tipo = 'escala'
	begin
				
       select 	IdEscala as Codigo,
				ValorInicial 		as AFIRMATIVO,
				ValorFinal as NEGATIVO,
				IdCategoria as Categoria

		from escalas
	end
    if @tipo = 'categorias'
	begin
				
         select 	IdCategoria as Codigo,
				Categoria 		as Descripcion
		from categorias
	end

go




