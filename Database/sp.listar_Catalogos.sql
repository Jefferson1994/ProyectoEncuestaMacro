use EncuestaMacro
go

if object_id('sp_listar_catalogos') is not null
	drop procedure sp_listar_catalogos
go

/*====================================================================================
--autor:		  jsarango
--Fecha creacion: 11/03/2023
--Descripcion:    Obtiene catalogos.
--====================================================================================*/
create procedure sp_listar_catalogos
(
	@codigo			int,
	@tipo			varchar(45)
)
as

	if @tipo = 'provincias'
	begin 
	
		select 	IdProvincia as CODIGO,
				Nombre 		as DESCRIPICION
		from provincias
		
	end 


	if @tipo = 'cantones'
	begin
	
		select 	c.IdCanton 	as CODIGO, 
				c.Nombre 	as DESCRIPICION
		FROM cantones c
			JOIN provincias p
				on ( p.IdProvincia = c.IdProvinciaFK )
		WHERE p.IdProvincia = convert( int, @codigo )

	end


	if @tipo = 'preguntas'
	begin
				
        select 	pre.IdPregunta 	as CODIGO, 
                pre.Pregunta	as DESCRIPICION,
                cat.Categoria as CATEGORIA,
                es.ValorInicial as VALOR,
                es.ValorFinal as VALOR
        FROM preguntas pre
            JOIN categorias cat
                 on ( cat.IdCategoria = pre.IdCategoriaFK )
            JOIN escalas es
                ON (es.IdEscala = cat.IdEscalaFk)
        WHERE pre.IdPregunta = convert( int, @codigo )
	end

    if @tipo = 'escala'
	begin
				
       select 	IdEscala as CODIGO,
				ValorInicial 		as AFIRMATIVO,
				ValorFinal as NEGATIVO,
				ldCategoria as Categoria

		from escalas
	end
    if @tipo = 'categorias'
	begin
				
         select 	IdCategoria as CODIGO,
				Categoria 		as DESCRIPICION
		from categorias
	end

go

-- -----------------------------------------------------
-- EJECUTAR PROCEEDIMIENTO ALMACENADO CATALOGO
-- -----------------------------------------------------

execute EncuestaMacro..sp_listar_catalogos
	@codigo			= -1,
	@tipo			='provincias'