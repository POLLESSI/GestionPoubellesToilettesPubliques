CREATE TABLE [dbo].[MakeshiftSchelter]
(
	[MakeshiftSchelter_Id] INT NOT NULL IDENTITY,
	[Latitude] DECIMAL(8, 6) NOT NULL,
	[Longitude] DECIMAL(9, 6) NOT NULL,
	[Description] NVARCHAR(128) NOT NULL,
	[Active] BIT DEFAULT 1

	CONSTRAINT PK_MakeshiftSchelter PRIMARY KEY (MakeshiftSchelter_Id)
)

GO

CREATE TRIGGER [dbo].[OnDeleteMakeshiftSchelter]
	ON [dbo].[MakeshiftSchelter]
	INSTEAD OF DELETE
	AS 
	BEGIN
		UPDATE MakeshiftSchelter SET Active = 0
		WHERE MakeshiftSchelter_Id = (SELECT MakeshiftSchelter_Id FROM deleted)
	END
