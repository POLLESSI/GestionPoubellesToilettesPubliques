CREATE TABLE [dbo].[PublicToilet]
(
	[PublicToilet_Id] INT NOT NULL IDENTITY, 
    [Num_Nat] INT NOT NULL, 
    [PosLat] FLOAT NOT NULL, 
    [PosLong] FLOAT NOT NULL, 
    [Adresse_Id] INT NOT NULL, 
    [IsFull] BIT NULL DEFAULT 0, 
    [Degradation] BIT NULL DEFAULT 0

    CONSTRAINT PK_PublicToilet PRIMARY KEY (PublicToilet_Id)
    CONSTRAINT FK_PublicToilet_Adresse FOREIGN KEY (Adresse_Id) REFERENCES Addres(Adresse_Id)
)
