CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL, --PRIMARY KEY-- --IDENTITY--
    [email] VARCHAR(320) NOT NULL, 
    [password] VARBINARY(32) NOT NULL, 
    [Salt] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(), 
    CONSTRAINT [CK_User_Email] CHECK (LEN([Email]) >= 5 AND [Email] LIKE '_@%_%._%'), 
    CONSTRAINT [AK_User_Id] UNIQUE ([Id]), 
    CONSTRAINT [PK_User] PRIMARY KEY ([Id]), 
    CONSTRAINT [AK_User_Email] UNIQUE ([Email])
)
