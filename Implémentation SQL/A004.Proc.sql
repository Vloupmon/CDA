USE [ComptoirAnglais_V1];  
GO

ALTER PROCEDURE [dbo].[Stock_Update]
    @order_id int,
    @product_id int,
    @quantity smallint
AS
BEGIN
    SET NOCOUNT ON;
    SET IDENTITY_INSERT [dbo].[MouvementDeStock] ON;
    INSERT INTO [dbo].[MouvementDeStock]
    VALUES
        (
            'NULL',
            @product_id,
            @quantity,
            'CL',
            CAST(@order_id as nvarchar(100)),
            GETDATE()
    )
END
GO  
