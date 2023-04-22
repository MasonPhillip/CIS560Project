IF OBJECT_ID(N'Movie.Users') IS NULL
BEGIN
   CREATE TABLE Movie.Users
   (
      UserId INT NOT NULL IDENTITY(1, 1),
      Username NVARCHAR(32) NOT NULL,
      [Password] NVARCHAR(32) NOT NULL,
      [Name] NVARCHAR(32) NOT NULL,
      RecoveryEmail NVARCHAR(32) NOT NULL,

      CONSTRAINT PK_Movie_Users_UserId PRIMARY KEY CLUSTERED
      (
         UserId ASC
      )
   );
END;

/****************************
 * Unique Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'Movie.Users')
         AND kc.[name] = N'UK_Movie_Users_Username'
   )
BEGIN
   ALTER TABLE Movie.Users
   ADD CONSTRAINT [UK_Movie_Users_Username] UNIQUE NONCLUSTERED
   (
      Username ASC
   )
END;
