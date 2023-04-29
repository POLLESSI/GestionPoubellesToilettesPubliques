CREATE TABLE [dbo].[Addres]
(
	[Adresse_Id] INT NOT NULL IDENTITY, 
    [Rue] NVARCHAR(50) NOT NULL, 
    [Numero] INT NOT NULL, 
    [CP] INT NOT NULL, 
    [Ville] NVARCHAR(50) NOT NULL, 
    [Pays] NVARCHAR(50) NULL

    CONSTRAINT PK_Adresse PRIMARY KEY (Adresse_Id)
)
