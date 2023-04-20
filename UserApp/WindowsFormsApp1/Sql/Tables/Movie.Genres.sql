IF OBJECT_ID(N'Movie.Genres') IS NULL
BEGIN
   CREATE TABLE Movie.Genres
   (
      GenreId INT NOT NULL,
      [Genre] VARCHAR(12) NOT NULL,

      CONSTRAINT PK_Movie_Genres_AddressTypeId PRIMARY KEY CLUSTERED
      (
         AddressTypeId ASC
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
      WHERE kc.parent_object_id = OBJECT_ID(N'Movie.Genre')
         AND kc.[name] = N'UK_Movie_Genres_Genre'
   )
BEGIN
   ALTER TABLE Movie.Genres
   ADD CONSTRAINT [UK_Movie_Genres_Genre] UNIQUE NONCLUSTERED
   (
      [Genre] ASC
   )
END;