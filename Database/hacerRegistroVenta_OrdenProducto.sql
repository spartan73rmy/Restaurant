USE [Restaurant]
GO
/****** Object:  Trigger [dbo].[registrarPedido]    Script Date: 24/05/2018 07:15:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER TRIGGER [dbo].[registrarPedido] ON [dbo].[OrdenProducto]
FOR DELETE
AS
DECLARE @ID_ORDEN int
,@ID_TIPO_PRODUCTO int
,@ID_ORDEN_PRODUCTO int 
,@ID_PRODUCTO_VARIANTE int
,@CANTIDAD int
,@PRECIO Money
,@FECHA DATE


SELECT
@ID_ORDEN=id_orden
,@ID_TIPO_PRODUCTO=id_tipo_producto
,@ID_ORDEN_PRODUCTO=id_orden_producto
,@CANTIDAD=cantidad
,@PRECIO=precio
FROM deleted 

--SELECT @ID_PRODUCTO_VARIANTE=id_variante 
--FROM VariantesDeLaOrden
--WHERE id_orden_producto=@ID_ORDEN_PRODUCTO

SELECT @FECHA=fecha
FROM Orden
WHERE id_orden=@ID_ORDEN

INSERT INTO RegistroVenta(
id_tipo_producto
,id_producto_variante
,precio
,cantidad
,fecha
)
VALUES(@ID_TIPO_PRODUCTO,NULL,@PRECIO,@CANTIDAD,GETDATE());

