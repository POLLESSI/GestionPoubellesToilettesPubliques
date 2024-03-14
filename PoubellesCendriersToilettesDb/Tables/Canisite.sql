CREATE TABLE [dbo].[Canisite]
(
	[Canisite_Id] INT NOT NULL IDENTITY, 
    [Num_Mat] INT NOT NULL, 
    [PosLat] DECIMAL(8, 6) NOT NULL, 
    [PosLong] DECIMAL(9, 6) NOT NULL, 
    [Addres_Id] INT NOT NULL, 
    [IsFull] BIT NULL DEFAULT 0, 
    [Degradation] BIT NULL DEFAULT 0,
    [Active] BIT DEFAULT 1

    CONSTRAINT PK_Canisite PRIMARY KEY (Canisite_Id),
    CONSTRAINT FK_Canisite_Adresse FOREIGN KEY (Addres_Id) REFERENCES Addres(Addres_Id)   
)

GO 

CREATE TRIGGER [dbo].[OnDeleteCanisite]
    ON [dbo].[Canisite]
    INSTEAD OF DELETE
    AS
    BEGIN
        UPDATE Canisite SET Active = 0
        WHERE Canisite_Id = (SELECT Canisite_Id FROM deleted)
    END