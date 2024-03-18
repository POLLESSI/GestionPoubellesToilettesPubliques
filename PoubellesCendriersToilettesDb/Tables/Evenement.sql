CREATE TABLE [dbo].[Evenement]
(
	[Evenement_Id] INT IDENTITY,
	[EvenementDate] DATETIME DEFAULT NOW(),
	[EvenementName] NVARCHAR(32)NOT NULL,
	[EvenementDescription] NVARCHAR(256) NOT NULL,
	[PosLat] DECIMAL(8, 6) NOT NULL,
	[PosLong] DECIMAL(9, 6) NOT NULL,
	[Positif] BIT DEFAULT 1,
	[Active] BIT DEFAULT 1

	CONSTRAINT PK_Evenement PRIMARY KEY ([Evenement_Id])
)

GO

CREATE TRIGGER [dbo].[OnDeleteEvenement]
	ON [dbo].[Evenement]
	INSTEAD OF DELETE
	AS
	BEGIN
		UPDATE Evenement SET Active = 0
		WHERE Evenement_Id = (SELECT Evenement_Id FROM deleted)
	END