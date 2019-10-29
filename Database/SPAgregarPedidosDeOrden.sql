GO  
CREATE PROCEDURE agregarPedidoOrden
    @IDOrden int,
	@IDTipoProducto int,
	@IDVariantes varchar (MAX)

AS
	SET NOCOUNT ON;   
    INSERT INTO OrdenProducto(id_orden, id_tipo_producto, precio, cantidad) 
	VALUES(
		@IDOrden, 
		@IDTipoProducto, 
		(SELECT precio_tipo FROM TipoProducto WHERE id_tipo_producto = @IDTipoProducto),
		1
	)
	IF @IDVariantes IS NOT NULL AND LEN(@IDVariantes) > 0
		INSERT INTO VariantesDeLaOrden(id_orden_producto, id_variante)
		SELECT IDENT_CURRENT('OrdenProducto') AS id_orden_producto, CONVERT(INT, [Param]) AS id_variante
		FROM splitstring(@IDVariantes)

GO
