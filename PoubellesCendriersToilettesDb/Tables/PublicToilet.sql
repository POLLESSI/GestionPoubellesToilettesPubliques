CREATE TABLE [dbo].[PublicToilet]
(
	[PublicToilet_Id] INT NOT NULL IDENTITY, 
    [Num_Mat] INT NOT NULL, 
    [PosLat] DECIMAL(8, 6) NOT NULL, 
    [PosLong] DECIMAL(9, 6) NOT NULL, 
    [Addres_Id] INT NOT NULL, 
    [IsFull] BIT NULL DEFAULT 0, 
    [Degradation] BIT NULL DEFAULT 0,
    [Active] BIT DEFAULT 1

    CONSTRAINT PK_PublicToilet PRIMARY KEY (PublicToilet_Id)
    CONSTRAINT FK_PublicToilet_Adresse FOREIGN KEY (Addres_Id) REFERENCES Addres(Addres_Id)
)

GO

CREATE TRIGGER [dbo].[OnDeletePublicToilet]
    ON [dbo].[PublicToilet]
    INSTEAD OF DELETE
    AS
    BEGIN
        UPDATE PublicToilet SET Active = 0
        WHERE PublicToilet_Id = (SELECT PublicToilet_Id FROM deleted)
    END
