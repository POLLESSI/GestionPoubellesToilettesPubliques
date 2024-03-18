CREATE TABLE [dbo].[Monument]
(
	[Monument_Id] INT IDENTITY,
	[MonumentName] NVARCHAR (32) NOT NULL,
	[Description] NVARCHAR(128) NOT NULL,
	[PosLat] DECIMAL(8, 6) NOT NULL,
	[PosLong] DECIMAL(9, 6) NOT NULL,
	[Active] BIT DEFAULT 1

	CONSTRAINT PK_Monument PRIMARY KEY ([Monument_Id])
)

GO

CREATE TRIGGER [dbo].[OnDeleteMonument]
	ON [dbo].[Monument]
	INSTEAD OF DELETE
	AS
	BEGIN
		UPDATE Monument SET Active = 0
		WHERE Monument_Id = (SELECT Monument_Id FROM deleted)
	END