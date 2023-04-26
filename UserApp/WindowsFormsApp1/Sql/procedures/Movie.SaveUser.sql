CREATE OR ALTER PROCEDURE Movie.SaveUser
   @UserId INT,
   @UserName NVARCHAR(32),
   @Password NVARCHAR(32),
   @Name NVARCHAR(32),
   @RecoveryEmail NVARCHAR(32)
AS

MERGE Movie.Users U
USING
      (
         VALUES(@UserId, @UserName, @Password, @Name, @RecoveryEmail)
      ) S(UserId, UserName, [Password], [Name], RecoveryEmail)
   ON S.UserId = U.UserId
WHEN MATCHED AND NOT EXISTS
      (
         SELECT S.UserName, S.[Password], S.[Name], S.RecoveryEmail
         INTERSECT
         SELECT  U.UserName, U.[Password], U.[Name], U.RecoveryEmail
      ) THEN
   UPDATE
   SET
      UserName = S.UserName,
      [Password] = S.[Password],
      [Name] = S.[Name],
      RecoveryEmail = S.RecoveryEmail
WHEN NOT MATCHED THEN
   INSERT(UserId, UserName, [Password], [Name], RecoveryEmail)
   VALUES(S.UserId, S.UserName, S.[Password], S.[Name], S.RecoveryEmail);
GO
