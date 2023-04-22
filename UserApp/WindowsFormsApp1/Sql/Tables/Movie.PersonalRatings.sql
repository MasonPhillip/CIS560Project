IF OBJECT_ID(N'Movie.PersonalRatings') IS NULL
BEGIN
   CREATE TABLE Movie.PersonalRatings
   (
      RatingId INT NOT NULL IDENTITY(1, 1),
      MovieId INT NOT NULL,
      AuthorUserId INT NOT NULL,
      PersonalRating INT NOT NULL,
      RatingDescription NVARCHAR(256) NOT NULL,

      CONSTRAINT PK_Movie_PersonalRatings_RatingId PRIMARY KEY CLUSTERED
      (
         RatingId ASC
      ),

      CONSTRAINT FK_Movie_PersonalRatings_Movie_Movies FOREIGN KEY(MovieId)
      REFERENCES Movie.Movies(MovieId),

      CONSTRAINT FK_Movie_PersonalRatings_Movie_Users FOREIGN KEY(AuthorUserId)
      REFERENCES Movie.Users(UserId)
   );
END;

/****************************
 * Foreign Keys Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Movie.PersonalRatings')
         AND fk.referenced_object_id = OBJECT_ID(N'Movie.Movies')
         AND fk.[name] = N'FK_Movie_PersonalRatings_Movie_Movies'
   )
BEGIN
   ALTER TABLE Movie.PersonalRatings
   ADD CONSTRAINT [FK_Movie_PersonalRatings_Movie_Movies] FOREIGN KEY
   (
      MovieId
   )
   REFERENCES Movie.Movies
   (
      MovieId
   );
END;

IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Movie.PersonalRatings')
         AND fk.referenced_object_id = OBJECT_ID(N'Movie.Users')
         AND fk.[name] = N'FK_Movie_PersonalRatings_Movie_Users'
   )
BEGIN
   ALTER TABLE Movie.PersonalRatings
   ADD CONSTRAINT [FK_Movie_PersonalRatings_Movie_Users] FOREIGN KEY
   (
      AuthorUserId
   )
   REFERENCES Movie.Users
   (
      UserId
   );
END; 

/****************************
 * Check Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.check_constraints cc
      WHERE cc.parent_object_id = OBJECT_ID(N'Movie.PersonalRatings')
         AND cc.[name] = N'CK_Movie_PersonalRatings_PersonalRating'
   )
BEGIN
   ALTER TABLE Movie.PersonalRatings
   ADD CONSTRAINT [CK_Movie_PersonalRatings_PersonalRating] CHECK
   (
      PersonalRating >= 0 AND PersonalRating <= 10
   )
END;
