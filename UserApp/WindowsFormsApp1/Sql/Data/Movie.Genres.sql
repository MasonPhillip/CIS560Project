DECLARE @GenresStaging TABLE
(
   GenreId TINYINT NOT NULL PRIMARY KEY,
   Genre VARCHAR(12) NOT NULL UNIQUE
);

/***************************** Modify values here *****************************/

INSERT @GenresStaging(GenreId, Genre)
VALUES
   (1, 'Action'),
   (2, 'Adventure'),
   (3, 'Animated'),
   (4, 'Comedy'),
   (5, 'Drama'),
   (6, 'Fantasy'),
   (7, 'Historical'),
   (8, 'Horror'),
   (9, 'Musical'),
   (10, 'Mystery'),
   (11, 'Romance'),
   (12, 'SciFi'),
   (13, 'Sports'),
   (14, 'Thriller'),
   (15, 'War'),
   (16, 'Western');

/******************************************************************************/

MERGE Movie.Genres G
USING @GenresStaging S ON S.GenreId = G.GenreId
WHEN MATCHED AND S.Genre <> G.Genre THEN
   UPDATE
   SET Genre = S.Genre
WHEN NOT MATCHED THEN
   INSERT(GenreId, Genre)
   VALUES(S.GenreId, S.Genre);