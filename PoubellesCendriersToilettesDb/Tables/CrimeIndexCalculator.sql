CREATE TABLE [dbo].[CrimeIndexCalculator]
(
	[CrimeIndexCalculator_Id] INT NOT NULL IDENTITY,

	[Active] BIT DEFAULT 1

	CONSTRAINT PK_CrimeIndexCalculator PRIMARY KEY (CrimeIndexCalculator_Id)
)

GO

CREATE TRIGGER [dbo].[OnDeleteCrimeIndexCalculator]
	ON [dbo].[CrimeIndexCalculator]
	INSTEAD OF DELETE
	AS
	BEGIN
		UPDATE CrimeIndexCalculator SET Active = 0
		WHERE CrimeIndexCalculator_Id = (SELECT CrimeIndexCalculator_Id FROM deleted)
	END