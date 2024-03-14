CREATE TABLE [dbo].[Addres]
(
	[Addres_Id] INT NOT NULL IDENTITY, 
    [Rue] NVARCHAR(64) NOT NULL, 
    [Numero] NVARCHAR(4) NOT NULL, 
    [CP] NVARCHAR(8) NOT NULL, 
    [Ville] NVARCHAR(64) NOT NULL, 
    [Pays] NVARCHAR(64) NULL,
    [Active] BIT DEFAULT 1

    CONSTRAINT PK_Addres PRIMARY KEY (Addres_Id)
)

GO

CREATE TRIGGER [dbo].[OnDeleteAddres]
    ON [dbo].[Addres]
    INSTEAD OF DELETE
    AS
    BEGIN
        UPDATE Addres SET Active = 0
        WHERE Adresse_Id = (SELECT Adresse_Id FROM deleted)
    END