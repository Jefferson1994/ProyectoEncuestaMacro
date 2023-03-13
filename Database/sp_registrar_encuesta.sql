use EncuestaMacro
go

if object_id('sp_registrar_encuesta') is not null
	drop procedure sp_registrar_encuesta
go

/*====================================================================================
--autor:		  jsarango
--Fecha creacion: 11/03/2023
--Descripcion:    Registro de encuestas.
--====================================================================================*/
create procedure sp_registrar_encuesta
(
	@id_pregunta	int,
	@id_cliente		int,
	@id_sucursal	int,
	@respuesta		varchar(300),
	@o_mensaje 		varchar(150) out,
	@o_codigo		int out
)

as

	declare @mes_actual 		datetime,
			@cantidad_encuestas	smallint

    select @mes_actual = MONTH(getdate())
	select @cantidad_encuestas = count(*) from encuestas where IdSucursalFK = @id_sucursal and DATEPART(month, FechaRegistro) = @mes_actual

	set @o_mensaje = ''
	set @o_codigo = 0
	

	
	if @cantidad_encuestas >= 30
		begin
            BEGIN TRAN
                
                select @o_mensaje = 'USTED YA EXCEDIO EL NÚMERO DE ENCUESTAS DURANTE EL MÉS'	
                select @o_codigo = 1      
            ROLLBACK TRAN
		end
	else 
		begin 
			BEGIN TRAN 
     
                INSERT INTO encuestas ( Respuesta, FechaRegistro, IdClienteFK, IdSucursalFK, IdPreguntaFK)
                    VALUES ( @respuesta, getdate(), @id_cliente, @id_sucursal, @id_pregunta )
                if @@error = 0
                    begin
                        select @o_mensaje = 'REGISTRO CORRECTAMENTE'	
                        select @o_codigo = 0
                    end
                else 
                    begin
                   
                        BEGIN TRAN

                            select @o_mensaje = 'NO SE PUEDO REGISTRAR, VERIFIQUE'	
                            select @o_codigo = 2
                        ROLLBACK TRAN 
                    end
            COMMIT TRAN		
		end
GO






