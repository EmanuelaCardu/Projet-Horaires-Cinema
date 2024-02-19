CREATE PROCEDURE [dbo].[SP_User_Check]
	@email VARCHAR(320),
	@password VARCHAR(32)
AS
	SELECT [Id] FROM [User] WHERE [Email] = @email AND [Password] = [dbo].[SF_SaltAndHash_Password]
	(@password, [Salt])
RETURN 0
