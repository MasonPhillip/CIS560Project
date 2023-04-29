CREATE OR ALTER PROCEDURE Movie.AverageCostProductionByGenre
   @GenreId INT
AS
SELECT G.Genre, cast(ISNULL(AVG(M.Cost), 0.00) AS BIGINT) AS AverageCost
FROM Movie.Genres G
	INNER JOIN Movie.Movies M ON M.GenreId = G.GenreId
WHERE G.GenreId = @GenreId
GROUP BY G.Genre
GO