﻿CREATE TABLE [dbo].[Ashtray]
(
	[Ashtray_Id] INT NOT NULL IDENTITY , 
    [Num_Mat] INT NOT NULL, 
    [PosLat] DECIMAL(8, 6) NOT NULL, 
    [PosLong] DECIMAL(9, 6) NOT NULL, 
    [Adresse_Id] INT NOT NULL,
    [IsFull] BIT NOT NULL DEFAULT 0, 
    [Degradation] BIT NOT NULL DEFAULT 0,
    [Active] BIT DEFAULT 1

    CONSTRAINT PK_Ashtray PRIMARY KEY (Ashtray_Id), 
    CONSTRAINT FK_Ashtray_Adresse FOREIGN KEY (Adresse_Id) REFERENCES Addres(Adresse_Id) 
)

GO CREATE TRIGGER [dbo].[OnDeleteAshtray]
    ON [dbo].[Ashtray]
    INSTEAD OF DELETE
    AS
    BEGIN
        UPDATE Ashtray SET Active = 0
        WHERE Ashtray_Id = (SELECT Ashtray_Id FROM deleted)
    END