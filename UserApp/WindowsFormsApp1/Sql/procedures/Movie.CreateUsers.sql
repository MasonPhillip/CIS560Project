CREATE OR ALTER PROCEDURE Movie.CreateUsers
	@UserId INT,
	@UserName NVARCHAR(32),
	@Password NVARCHAR(32),
	@Name NVARCHAR(32),
	@RecoveryEmail NVARCHAR(32)
AS
	IF @UserId = 0
	INSERT INTO Movie.Users(UserName, [Password], [Name], RecoveryEmail)
	VALUES(@UserName, @Password, @Name, @RecoveryEmail);
	ELSE
	UPDATE Users
	SET
	UserName = @UserName,
	[Password] = @Password,
	[Name] = @Name,
	RecoveryEmail = @RecoveryEmail
	WHERE UserId = @UserId
GO