CREATE TABLE [dbo].[Incivility]
(
	[Incivility_Id] INT NOT NULL IDENTITY, 
    [Num_Mat] INT NOT NULL, 
    [PosLat] FLOAT NOT NULL, 
    [PosLong] FLOAT NOT NULL, 
    [Adresse_Id] INT NOT NULL, 
    [Severe] BIT NULL DEFAULT 0, 
    [Absorbed] BIT NULL DEFAULT 0

    CONSTRAINT PK_Incivility PRIMARY KEY (Incivility_Id),
    CONSTRAINT FK_Incivility_Adresse FOREIGN KEY (Adresse_Id) REFERENCES Addres(Adresse_Id)
)
