
-- =============================================
CREATE PROCEDURE editarOrdenProducto
	@IDOrdenProducto int,
	@IDTipoProducto int,
	@IDVariantes varchar (MAX),
	@Cantidad int = 1,
	@Comentarios varchar (MAX) = NULL
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM VariantesDeLaOrden WHERE id_orden_producto = @IDOrdenProducto

	UPDATE OrdenProducto
	SET id_tipo_producto = @IDTipoProducto,
	cantidad = @Cantidad,
	comentarios = @Comentarios
	WHERE id_orden_producto = @IDOrdenProducto

	IF @IDVariantes IS NOT NULL AND LEN(@IDVariantes) > 0
		INSERT INTO VariantesDeLaOrden(id_orden_producto, id_variante)
		SELECT @IDOrdenProducto AS id_orden_producto, CONVERT(INT, [Param]) AS id_variante
		FROM splitstring(@IDVariantes)
END
GO
