CREATE TABLE [dbo].[Canisite]
(
	[Canisite_Id] INT NOT NULL IDENTITY, 
    [Num_Mat] INT NOT NULL, 
    [PosLat] FLOAT NOT NULL, 
    [PosLong] FLOAT NOT NULL, 
    [Adresse_Id] INT NOT NULL, 
    [IsFull] BIT NULL DEFAULT 0, 
    [Degradation] BIT NULL DEFAULT 0

    CONSTRAINT PK_Canisite PRIMARY KEY (Canisite_Id),
    CONSTRAINT FK_Canisite_Adresse FOREIGN KEY (Adresse_Id) REFERENCES Addres(Adresse_Id)   
)
