CREATE TABLE [dbo].[SaveStreet]
(
	[SaveStreet_Id] INT NOT NULL IDENTITY,
	[StreetName] NVARCHAR(64) NOT NULL,
	[StartLatitude] DECIMAL(8, 6) NOT NULL,
	[EndLatitude] DECIMAL(8, 6) NOT NULL,
	[StartLongitude] DECIMAL(9, 6) NOT NULL,
	[EndLongitude] DECIMAL(9, 6) NOT NULL,
	[SecurityScore] INT NULL,
	[Active] BIT DEFAULT 1

	CONSTRAINT PK_SaveStreet PRIMARY KEY ([SaveStreet_Id])
)

GO

CREATE TRIGGER [dbo].[OnDeleteSaveStreet]
	ON [dbo].[SaveStreet]
	INSTEAD OF DELETE
	AS
	BEGIN
		UPDATE SaveStreet SET Active = 0
		WHERE SaveStreet_Id = (SELECT SaveStreet_Id FROM deleted)
	END