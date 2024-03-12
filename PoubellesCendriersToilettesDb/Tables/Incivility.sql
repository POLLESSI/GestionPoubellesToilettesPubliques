CREATE TABLE [dbo].[Incivility]
(
	[Incivility_Id] INT NOT NULL IDENTITY, 
    [Num_Mat] INT NOT NULL, 
    [PosLat] DECIMAL(8, 6) NOT NULL, 
    [PosLong] DECIMAL(9, 6) NOT NULL, 
    [Adresse_Id] INT NOT NULL, 
    [Severe] BIT NULL DEFAULT 0, 
    [Absorbed] BIT NULL DEFAULT 0,
    [Active] BIT DEFAULT 1

    CONSTRAINT PK_Incivility PRIMARY KEY (Incivility_Id),
    CONSTRAINT FK_Incivility_Adresse FOREIGN KEY (Adresse_Id) REFERENCES Addres(Adresse_Id)
)

GO

CREATE TRIGGER [dbo].[OnDeleteIncivility]
    ON [dbo].[Incivility]
    INSTEAD OF DELETE
    AS
    BEGIN
        UPDATE Incivility SET Active = 0
        WHERE Incivility_Id = (SELECT Incivility_Id FROM deleted)
    END

