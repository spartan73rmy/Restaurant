USE [Restaurant]
GO
/****** Object:  UserDefinedFunction [dbo].[splitstring]    Script Date: 22/05/2018 11:05:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[splitstring] ( @stringToSplit VARCHAR(8000) )
    RETURNS
        @returnList TABLE ([Param] [nvarchar] (500))
AS
 
BEGIN
 
    DECLARE @name NVARCHAR(255)
    DECLARE @pos INT
 
    WHILE CHARINDEX(',', @stringToSplit) > 0
    BEGIN
        SELECT @pos  = CHARINDEX(',', @stringToSplit) 
        SELECT @name = SUBSTRING(@stringToSplit, 1, @pos-1)
 
        INSERT INTO @returnList
        SELECT @name
 
        SELECT @stringToSplit = SUBSTRING(@stringToSplit, @pos+1, LEN(@stringToSplit)-@pos)
    END
 
    INSERT INTO @returnList
    SELECT @stringToSplit
 
    RETURN
END
GO
/****** Object:  StoredProcedure [dbo].[agregarOrdenProducto]    Script Date: 22/05/2018 11:05:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[agregarOrdenProducto]
    @IDOrden int,
	@IDTipoProducto int,
	@IDVariantes varchar,
	@Cantidad int = 1,
	@Comentarios varchar (100) = NULL


AS
SET NOCOUNT ON;  
    INSERT INTO OrdenProducto(id_orden, id_tipo_producto, precio, cantidad, comentarios) 
	VALUES(
		@IDOrden, 
		@IDTipoProducto, 
		(SELECT precio_tipo FROM TipoProducto WHERE id_tipo_producto = @IDTipoProducto),
		@Cantidad,
		@Comentarios
	)
	
	IF @IDVariantes IS NOT NULL AND LEN(@IDVariantes) > 0
		INSERT INTO VariantesDeLaOrden(id_orden_producto, id_variante)
		SELECT IDENT_CURRENT('OrdenProducto') AS id_orden_producto, CONVERT(INT, [Param]) AS id_variante
		FROM splitstring(@IDVariantes)
	
GO
/****** Object:  StoredProcedure [dbo].[editarOrdenProducto]    Script Date: 22/05/2018 11:05:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[editarOrdenProducto]
	@IDOrdenProducto int,
	@IDTipoProducto int,
	@IDVariantes varchar,
	@Cantidad int = 1,
	@Comentarios varchar (100) = NULL
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
/****** Object:  StoredProcedure [dbo].[getPedidosDeOrden]    Script Date: 22/05/2018 11:05:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getPedidosDeOrden]
    @IDOrden int
AS   
    SET NOCOUNT ON;  
    SELECT *,
	variantes = STUFF((
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
/****** Object:  StoredProcedure [dbo].[getTipoProductos]    Script Date: 22/05/2018 11:05:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[getTipoProductos]
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
