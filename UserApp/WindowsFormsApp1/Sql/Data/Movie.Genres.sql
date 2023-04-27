DECLARE @GenresStaging TABLE
(
   GenreId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
   Genre NVARCHAR(12) NOT NULL UNIQUE
);

/***************************** Modify values here *****************************/

INSERT @GenresStaging(Genre)
VALUES
   ('Action'),
   ('Adventure'),
   ('Animated'),
   ('Comedy'),
   ('Drama'),
   ('Fantasy'),
   ('Historical'),
   ('Horror'),
   ('Musical'),
   ('Mystery'),
   ('Romance'),
   ('SciFi'),
   ('Sports'),
   ('Thriller'),
   ('War'),
   ('Western')

/******************************************************************************/

MERGE Movie.Genres G
USING @GenresStaging S ON S.GenreId = G.GenreId
WHEN MATCHED AND S.Genre <> G.Genre THEN
   UPDATE
   SET Genre = S.Genre
WHEN NOT MATCHED THEN
   INSERT(Genre)
   VALUES(S.Genre);