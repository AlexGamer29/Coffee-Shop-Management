CREATE PROC USERPROC_UpdateAccount
@userName NVARCHAR(100), @displayName NVARCHAR(100), @password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
    DECLARE @isCorrectPassword INT
    SELECT @isCorrectPassword = COUNT(*) FROM dbo.Account WHERE userName = @userName AND password = @password
    
    IF (@isCorrectPassword = 1)
    BEGIN
        IF (@newPassword = NULL OR @newPassword = '')
        BEGIN
            UPDATE dbo.Account SET displayName = @displayName WHERE userName = @userName
        END
        ELSE
            UPDATE dbo.Account SET displayName = @displayName, password = @newPassword WHERE userName = @userName
    END
END
GO

SELECT * FROM dbo.Receipt
SELECT * FROM dbo.ReceiptInfo