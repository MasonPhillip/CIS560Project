IF OBJECT_ID(N'Movie.Movies') IS NULL
BEGIN
   CREATE TABLE Movie.Movies
   (
      MovieId INT NOT NULL IDENTITY(1, 1),
      StudioId INT NOT NULL,
      MovieName NVARCHAR(256) NOT NULL,
      [ReleaseDate] DATE NOT NULL,
      IMDBRating INT NOT NULL,
      RottenTomatoesAudienceRating INT NOT NULL,
      DomesticRevenue BIGINT NOT NULL,
      InternationlRevenue BIGINT NOT NULL,
      Cost INT NOT NULL,
      GenreId INT NOT NULL,
      RottenTomatoesCriticRating INT NOT NULL,


      CONSTRAINT PK_Movie_Movies_MovieId PRIMARY KEY CLUSTERED
      (
         MovieId ASC
      ),

      CONSTRAINT FK_Movie_Movies_Movie_Studios FOREIGN KEY(StudioId)
      REFERENCES Movie.Studios(StudioId),

      CONSTRAINT FK_Movie_Movies_Movie_Genres FOREIGN KEY(GenreId)
      REFERENCES Movie.Genres(GenreId)
   );
END;

/****************************
 * Unique Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'Movie.Movies')
         AND kc.[name] = N'UK_Movie_Movies_MovieName'
   )
BEGIN
   ALTER TABLE Movie.Movies
   ADD CONSTRAINT [UK_Movie_Movies_MovieName] UNIQUE NONCLUSTERED
   (
      MovieName ASC
   )
END;

/****************************
 * Foreign Keys Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Movie.Movies')
         AND fk.referenced_object_id = OBJECT_ID(N'Movie.Studios')
         AND fk.[name] = N'FK_Movie_Movies_Movie_Studios'
   )
BEGIN
   ALTER TABLE Movie.Movies
   ADD CONSTRAINT [FK_Movie_Movies_Movie_Studios] FOREIGN KEY
   (
      StudioId
   )
   REFERENCES Movie.Studios
   (
      StudioId
   );
END;

IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Movie.Movies')
         AND fk.referenced_object_id = OBJECT_ID(N'Movie.Genres')
         AND fk.[name] = N'FK_Movie_Movies_Movie_Genres'
   )
BEGIN
   ALTER TABLE Movie.Movies
   ADD CONSTRAINT [FK_Movie_Movies_Movie_Genres] FOREIGN KEY
   (
      GenreId
   )
   REFERENCES Movie.Genres
   (
      GenreId
   );
END;