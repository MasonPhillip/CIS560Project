CREATE OR ALTER PROCEDURE Person.CreatePerson
   @UserName NVARCHAR(32),
   @Password NVARCHAR(32),
   @Name NVARCHAR(32),
   @RecoveryEmail NVARCHAR(32),
   @UserId INT OUTPUT
AS

INSERT Movie.Users(UserName, [Password], [Name], RecoveryEmail)
VALUES(@UserName, @Password, @Name, @RecoveryEmail);

SET @UserId = SCOPE_IDENTITY();
GO