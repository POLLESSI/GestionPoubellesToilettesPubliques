CREATE TABLE [dbo].[Map]
(
	[Map_Id] INT IDENTITY,
	[DateCreation] DATETIME, 
	[Description] NVARCHAR(32),
	[Active] BIT DEFAULT 1

	CONSTRAINT PK_Map PRIMARY KEY ([Map_Id])
)

GO

CREATE TRIGGER [dbo].[OnDeleteMap]
	ON [dbo].[Map]
	INSTEAD OF DELETE
	AS
	BEGIN
		UPDATE Map SET Active = 0
		WHERE Map_Id = (SELECT Map_Id FROM deleted)
	END