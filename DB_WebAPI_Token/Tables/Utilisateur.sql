CREATE TABLE [dbo].[Utilisateur]
(
	[Id] INT NOT NULL, 
    [Nom] NVARCHAR(80) NOT NULL, 
    [Prenom] NVARCHAR(80) NOT NULL, 
    [Email] NVARCHAR(100) NOT NULL, 
    [DateNaissance] DATE NOT NULL, 
    [PasswordHash] BINARY(64) NOT NULL, 
    [SecurityStamp] UNIQUEIDENTIFIER NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_Utilisateur] PRIMARY KEY ([Id]) 
)
