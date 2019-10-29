GO  
CREATE PROCEDURE getPedidosDeOrden
    @IDOrden int
AS   
    SET NOCOUNT ON;  
    SELECT *,
	array = STUFF((
		SELECT '|' + STR(vo.id_variante) + ',' + PV.nombre_variante + ',' + STR(PV.precio_variante)
		FROM VariantesDeLaOrden vo
		INNER JOIN ProductoVariante AS PV
		ON vo.id_variante = PV.id_producto_variante
		WHERE VO.id_orden_producto = OP.id_orden_producto AND PV.disponible = 1
		FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 1, '')
	FROM OrdenProducto  AS OP
	INNER JOIN TipoProducto AS TP
	ON OP.id_tipo_producto = TP.id_tipo_producto
	INNER JOIN Producto AS P
	ON P.id_producto = TP.id_producto
	INNER JOIN CategoriaProducto AS CP
	ON CP.id_categoria = P.id_categoria
	WHERE OP.id_orden = @IDOrden
GO
