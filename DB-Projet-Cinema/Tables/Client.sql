CREATE TABLE [dbo].[Client]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [First_name] NCHAR(32) NOT NULL, 
    [Last_name] NCHAR(32) NOT NULL, 
    [Birth_date] DATE NOT NULL, 
    [ZipCode] INT NOT NULL, 
    [UserId] INT NOT NULL, 
    CONSTRAINT [UK_Client_Id] UNIQUE ([Id]), 
    CONSTRAINT [FK_Client_User] FOREIGN KEY ([UserId]) REFERENCES [User]([Id])
)
