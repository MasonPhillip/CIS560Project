CREATE OR ALTER PROCEDURE Movie.FetchUser
	@UserId INT
AS

SELECT U.UserName, U.[Password], U.[Name], U.RecoveryEmail
FROM Movie.Users U
WHERE U.UserId = @UserId
GO