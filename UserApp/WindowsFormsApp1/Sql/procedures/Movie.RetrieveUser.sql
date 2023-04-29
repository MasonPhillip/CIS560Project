CREATE OR ALTER PROCEDURE Movie.RetrieveUser
AS

SELECT U.UserId, U.UserName, U.[Password], U.[Name], U.RecoveryEmail
FROM Movie.Users U
ORDER BY U.[Name] ASC;
GO