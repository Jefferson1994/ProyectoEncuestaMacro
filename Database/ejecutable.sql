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

    
-- -----------------------------------------------------
-- EJECUTAR PROCEEDIMIENTO ALMACENDA AGREGAR ENCUESTA
-- -----------------------------------------------------
use EncuestaMacro
GO
declare @o_mensaje 		 varchar(150),
		@o_codigo		 int

execute sp_registrar_encuesta
		@id_pregunta	= 2,
		@id_cliente		= 1,
		@id_sucursal	= 2,
		@respuesta		= 'SI',
		@o_mensaje 		= @o_mensaje output,
		@o_codigo		= @o_codigo output

		SELECT @o_mensaje
		SELECT @o_codigo
GO
