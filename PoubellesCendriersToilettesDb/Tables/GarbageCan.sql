CREATE TABLE [dbo].[GarbageCan]
(
	[GarbageCan_Id] INT NOT NULL IDENTITY, 
    [Num_Mat] INT NOT NULL, 
    [PosLat] DECIMAL(8, 6) NOT NULL, 
    [PosLong] DECIMAL(9, 6) NOT NULL, 
    [Addres_Id] INT NOT NULL, 
    [IsFull] BIT NULL DEFAULT 0, 
    [Degradation] BIT NULL DEFAULT 0,
    [Active] BIT DEFAULT 1

    CONSTRAINT PK_GarbageCan PRIMARY KEY (GarbageCan_Id),
    CONSTRAINT FK_GarbageCan_Adresse FOREIGN KEY (Addres_Id) REFERENCES Addres(Addres_Id)
)

GO

CREATE TRIGGER [dbo].[OnDeleteGarbageCan]
    ON [dbo].[GarbageCan]
    INSTEAD OF DELETE
    AS
    BEGIN
        UPDATE GarbageCan SET Active = 0
        WHERE GarbageCan_Id = (SELECT GarbageCan_Id FROM deleted)
    END
