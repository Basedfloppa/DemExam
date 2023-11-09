CREATE TABLE [dbo].[Staff]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [name] TEXT NULL, 
    [secondName] TEXT NULL, 
    [login] TEXT NULL, 
    [password] TEXT NULL, 
    [post] INT NULL DEFAULT 0
)
