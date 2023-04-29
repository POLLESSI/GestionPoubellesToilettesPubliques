CREATE TABLE [dbo].[Ashtray]
(
	[Ashtray_Id] INT NOT NULL IDENTITY , 
    [Num_Mat] INT NOT NULL, 
    [PosLat] FLOAT NOT NULL, 
    [PosLong] FLOAT NOT NULL, 
    [Adresse_Id] INT NOT NULL,
    [IsFull] BIT NOT NULL DEFAULT 0, 
    [Degradation] BIT NOT NULL DEFAULT 0

    CONSTRAINT PK_Ashtray PRIMARY KEY (Ashtray_Id), 
    CONSTRAINT FK_Ashtray_Adresse FOREIGN KEY (Adresse_Id) REFERENCES Addres(Adresse_Id) 
    
)
