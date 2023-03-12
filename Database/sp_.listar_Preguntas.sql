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

	@tipo			varchar(45)

)
as	
	if @tipo = 'preguntas'
	begin
	
		select 	pre.IdPregunta as Codigo,
		pre.Pregunta   as Descripcion,
		cat.IdCategoria as Idcategoria,
		cat.Categoria as nombrecategoria,
		es.ValorFinal as valorinical,
		es.ValorFinal as valorfinal
		from preguntas pre
		JOIN categorias cat
		on ( pre.IdCategoriaFK = cat.IdCategoria)
		JOIN escalas es
		ON (es.IdEscala=cat.IdEscalaFk)
	end

go
