CREATE TABLE [dbo].[Commerce]
(
	[Commerce_Id] INT IDENTITY,
	[CommerceName] NVARCHAR(64) NOT NULL,
	[Addres_Id] INT NOT NULL,
	[PosLat] DECIMAL(8, 6) NOT NULL,
	[PosLong] DECIMAL(9, 6) NOT NULL,
	[Description] NVARCHAR (256) NOT NULL,
	[Active] BIT DEFAULT 1

	CONSTRAINT PK_Commerce PRIMARY KEY ([Commerce_Id])
)

GO

CREATE TRIGGER [dbo].[OnDeleteCommerce]
	ON [dbo].[Commerce]
	INSTEAD OF DELETE
	AS
	BEGIN
		UPDATE Commerce SET Active = 0
		WHERE Commerce_Id = (SELECT Commerce_Id FROM deleted)
	END