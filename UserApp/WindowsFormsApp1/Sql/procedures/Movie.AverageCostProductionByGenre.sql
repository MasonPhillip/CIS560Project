CREATE OR ALTER PROCEDURE Movie.AverageCostProductionByGenre
   @GenreId INT
AS
SELECT G.GenreName, ISNULL(AVG(C.Cost), 0.00) AS AverageCost
FROM Movie.Genres G
	INNER JOIN Movie.Movies M ON M.GenreId = G.GenreId
WHERE G.GenreId = @GenreId
GROUP BY G.GenreName
ORDER BY G.GenreName ASC
GO