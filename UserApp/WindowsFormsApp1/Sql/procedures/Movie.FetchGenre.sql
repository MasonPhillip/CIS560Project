CREATE OR ALTER PROCEDURE Movie.FetchGenre
	@GenreId INT
AS

SELECT G.Genre
FROM Movie.Genres G
WHERE G.GenreId = @GenreId
GO