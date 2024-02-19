CREATE FUNCTION [dbo].[SF_SaltAndHash_Password]
(
	@password varchar(32),
	@salt  UNIQUEIDENTIFIER 
)
RETURNS VARBINARY (32)
AS
BEGIN
	DECLARE @saltedPassword VARCHAR(68)
	SET @saltedPassword = CONCAT(@salt, @password)
	RETURN HASHBYTES ('SHA2_256', @saltedPassword)
END
