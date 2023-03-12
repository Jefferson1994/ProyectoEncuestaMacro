-- -----------------------------------------------------
-- EJECUTAR PROCEEDIMIENTO ALMACENADO CATALOGO
-- -----------------------------------------------------

execute EncuestaMacro..sp_listar_Catalogo
	@codigo			= 1,
	@tipo			='categorias'


-- -----------------------------------------------------
-- EJECUTAR PROCEEDIMIENTO ALMACENADO CATALOGO PREGUNTAS
-- -----------------------------------------------------

execute EncuestaMacro..sp_listar_preguntas
	@tipo			='preguntas'

-- -----------------------------------------------------
-- EJECUTAR PROCEEDIMIENTO ALMACENADO BUSCAR CLIENTE
-- -----------------------------------------------------

execute EncuestaMacro..sp_buscar_clientes
	@codigo			= 1,
	@tipo			='buscarcliente'
