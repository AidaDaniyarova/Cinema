CREATE TABLE [dbo].[users]
(
	[username] VARCHAR(50) NOT NULL , 
    [email] VARCHAR(50) NOT NULL, 
    [password] VARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_users]PRIMARY KEY ([email])
)
