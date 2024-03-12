CREATE TABLE [dbo].[MakeshiftSchelter]
(
	[MakeshiftSchelter_Id] INT NOT NULL IDENTITY,
	[Latitude] DECIMAL(8, 6) NOT NULL,
	[Longitude] DECIMAL(9, 6) NOT NULL,
	[Description] NVARCHAR(128) NOT NULL,
	[Active] BIT DEFAULT 1

	CONSTRAINT PK_MakeshiftSchelter PRIMARY KEY (MakeshiftSchelter_Id)
)
