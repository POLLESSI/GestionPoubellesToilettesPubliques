CREATE TABLE [dbo].[SiteInterest]
(
	[SiteInterest_Id] INT IDENTITY,
	[SiteInterestName] NVARCHAR(32) NOT NULL,
	[SiteInterestType] NVARCHAR(32) NOT NULL,
	[PosLat] DECIMAL(8, 6) NOT NULL,
	[PosLong] DECIMAL(9, 6) NOT NULL,
	[Description] NVARCHAR(256) NOT NULL,
	[Active] BIT DEFAULT 1

	CONSTRAINT PK_SiteInterest PRIMARY KEY([SiteInterest_Id])
)

GO

CREATE TRIGGER [dbo].[OnDeleteSiteInterest]
	ON [dbo].[SiteInterest]
	INSTEAD OF DELETE
	AS 
	BEGIN
		UPDATE SiteInterest SET Active = 0
		WHERE SiteInterest_Id = (SELECT SiteInterest_Id FROM deleted)
	END