CREATE OR ALTER PROCEDURE Movie.RetrieveGenre
AS

SELECT G.GenreId, G.Genre
FROM Movie.Genres G
ORDER BY G.Genre ASC;
GO