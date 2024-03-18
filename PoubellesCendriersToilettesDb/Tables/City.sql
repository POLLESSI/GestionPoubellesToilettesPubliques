CREATE TABLE [dbo].[City]
(
	[City_Id] INT IDENTITY,
	[CityName] NVARCHAR(32) NOT NULL,
	[PosLat] DECIMAL(8, 6) NOT NULL,
	[PosLong] DECIMAL(9, 6) NOT NULL,
	[Description] NVARCHAR(256) NOT NULL,
	[Active] BIT DEFAULT 1

	CONSTRAINT Pk_City PRIMARY KEY ([City_Id])
)

GO

CREATE TRIGGER [dbo].[OnDeleteCity]
	ON [dbo].[City]
	INSTEAD OF DELETE
	AS
	BEGIN
		UPDATE City SET Active = 0
		WHERE City_Id = (SELECT City_Id FROM deleted)
	END