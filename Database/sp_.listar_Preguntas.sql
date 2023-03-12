use EncuestaMacro
go

if object_id('sp_listar_preguntas') is not null
	drop procedure sp_listar_preguntas
go

/*====================================================================================
--autor:		  jsarango
--Fecha creacion: 11/03/2023
--Descripcion:    Obtiene preguntas.
--====================================================================================*/
create procedure sp_listar_preguntas
(
	@codigo			int,
	@tipo			varchar(45)

)
as	
	if @tipo = 'preguntas'
	begin
	
		select 	pre.IdPregunta as CODIGO,
		pre.Pregunta   as DESCRIPICION,
		cat.IdCategoria as IDCATEGORIA,
		cat.Categoria as NOMBRE_CATEGORIA,
		es.ValorFinal as VALORI_NCIAL,
		es.ValorFinal as VALOR_FINAL
		from preguntas pre
		JOIN categorias cat
		on ( pre.IdCategoriaFK = cat.IdCategoria)
		JOIN escalas es
		ON (es.IdEscala=cat.IdEscalaFk)
	end

go

-- -----------------------------------------------------
-- EJECUTAR PROCEEDIMIENTO ALMACENADO CATALOGO PREGUNTAS
-- -----------------------------------------------------

execute EncuestaMacro..sp_listar_preguntas
	@codigo			= 8,
	@tipo			='preguntas'
