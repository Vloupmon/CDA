USE [ComptoirInternational];
GO

DROP FUNCTION IF EXISTS dbo.ConvertCurrency;
GO

CREATE FUNCTION ConvertCurrency (
    @value DECIMAL(18,3),
    @sourceCurrency VARCHAR(3) = 'USD',
    @targetCountry VARCHAR(2) = NULL,
    @targetCurrency VARCHAR(3) = NULL,
    @date DATE = NULL
)
RETURNS DECIMAL(18,3)
AS
BEGIN
    DECLARE @rate DECIMAL (18,5)
    IF @value is NULL RETURN (NULL)
    IF @targetCountry is not NULL AND @targetCurrency is NULL BEGIN
        SET @targetCurrency =
        (SELECT TOP(1)
            DeviseID
        FROM dbo.PaysDevise
        WHERE @targetCountry = PaysID2)
    END
    IF @targetCurrency is NULL RETURN (NULL)
    if @date is NULL OR @date < (SELECT TOP(1)
            DateApplication
        FROM dbo.TauxConversion
        ORDER BY DateApplication ASC) BEGIN
        SET @date = GETDATE()
    END
    SET @rate = (SELECT TOP (1)
        [TauxConversion]
    FROM [ComptoirInternational].[dbo].[TauxConversion]
    WHERE IdDeviseSource = @sourceCurrency
        AND IdDeviseCible = @targetCurrency
        AND DateApplication <= @date
    ORDER BY DateApplication DESC)
    RETURN (@value * @rate)
END;
GO