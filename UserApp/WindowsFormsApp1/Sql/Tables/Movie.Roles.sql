IF OBJECT_ID(N'Movie.Roles') IS NULL
BEGIN
   CREATE TABLE Movie.Roles
   (
      RoleId INT NOT NULL IDENTITY(1, 1),
      PersonId INT NOT NULL,
      MovieId INT NOT NULL,
      IsDirector BIT NOT NULL,
      IsActor BIT NOT NULL,
      AmountPaid DECIMAL(10,2)
      

      CONSTRAINT PK_Movie_Roles_RoleId PRIMARY KEY CLUSTERED
      (
         RoleId ASC
      ),

      CONSTRAINT FK_Movie_Roles_Movie_People FOREIGN KEY(PersonId)
      REFERENCES Movie.People(PersonId),

      CONSTRAINT FK_Movie_Roles_Movie_Movies FOREIGN KEY(MovieId)
      REFERENCES Movie.Movies(MovieId),
   );
END;

/****************************
 * Foreign Keys Constraints
 ****************************/
IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Movie.Roles')
         AND fk.referenced_object_id = OBJECT_ID(N'Movie.People')
         AND fk.[name] = N'FK_Movie_Roles_Movie_People'
   )
BEGIN
   ALTER TABLE Movie.Roles
   ADD CONSTRAINT [FK_Movie_Roles_Movie_People] FOREIGN KEY
   (
      PersonId
   )
   REFERENCES Movie.People
   (
      PersonId
   );
END;

IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Movie.Roles')
         AND fk.referenced_object_id = OBJECT_ID(N'Movie.Movies')
         AND fk.[name] = N'FK_Movie_Roles_Movie_Movies'
   )
BEGIN
   ALTER TABLE Movie.Roles
   ADD CONSTRAINT [FK_Movie_Roles_Movie_Movies] FOREIGN KEY
   (
      MovieId
   )
   REFERENCES Movie.Movies
   (
      MovieId
   );
END;