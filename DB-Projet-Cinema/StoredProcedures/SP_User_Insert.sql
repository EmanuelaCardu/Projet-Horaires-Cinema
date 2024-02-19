CREATE PROCEDURE [dbo].[SP_User_Insert]
	@email VARCHAR(320),
	@password VARCHAR(32)
AS
	DECLARE @salt UNIQUEIDENTIFIER
	SET @salt = NEWID()
	INSERT INTO [User] ([Email], [password], [salt])
	OUTPUT [inserted].[Id]
	VALUES (@email, [dbo].[SF_SaltAndHash_Password](@password, @salt), @salt)