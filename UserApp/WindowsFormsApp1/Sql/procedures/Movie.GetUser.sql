
CREATE OR ALTER PROCEDURE Movie.GetUser
	@UserName NVARCHAR(32)
AS

SELECT U.UserId, U.[Password], U.[Name], U.RecoveryEmail
FROM Movie.Users U
WHERE U.UserName = @UserName
GO