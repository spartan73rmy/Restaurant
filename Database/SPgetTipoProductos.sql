
CREATE PROCEDURE getTipoProductos
	@IDProducto int
	
AS
BEGIN
	SET NOCOUNT ON;
	SELECT *, 
	variantes = STUFF((
		SELECT '|' + STR(PV.id_producto_variante) + ',' + PV.nombre_variante + ',' + STR(PV.precio_variante)
		FROM ProductoVariante AS PV
		WHERE PV.id_tipo_producto = TP.id_tipo_producto AND PV.disponible = 1
		FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 1, '')
	FROM TipoProducto AS TP
	WHERE TP.id_producto = @IDProducto
END
GO
