CREATE OR ALTER PROCEDURE Movie.AverageCostProductionByGenre
   @GenreId INT
AS
SELECT G.Genre, ISNULL(AVG(M.Cost), 0.00) AS AverageCost
FROM Movie.Genres G
	INNER JOIN Movie.Movies M ON M.GenreId = G.GenreId
WHERE G.GenreId = @GenreId
GROUP BY G.Genre
ORDER BY G.Genre ASC
GO