CREATE PROCEDURE [dbo].[sqlNUserRegister]
	@Email NVARCHAR(64),
	@Pseudo NVARCHAR(64),
	@Password NVARCHAR(64)
AS

BEGIN
	DECLARE @pwd BINARY(64), @securityStamp UNIQUEIDENTIFIER;

	SET @securityStamp = NEWID()
	SET @pwd = dbo.fHasher (TRIM(@Password), @securityStamp)

	INSERT INTO NUser (Email, Pwd, SecurityStamp)
	VALUES (TRIM(@Email), @pwd, @securityStamp)
END
