CREATE OR ALTER PROCEDURE Movie.AverageStudioProfitByGenre
   @GenreId INT
AS
WITH CTE AS 
(
	SELECT M.MovieId, M.StudioId, M.GenreId, ((M.DomesticRevenue + M.InternationlRevenue) - M.Cost) AS Profit
	FROM Movie.Movies M
)
SELECT S.StudioId, S.StudioName, COUNT(DISTINCT C.MovieId) AS AmountMoviesReleased , ISNULL(AVG(C.Profit), 0.00) AS AverageProfitPerMovie
FROM Movie.Studios S 
	INNER JOIN CTE C ON C.StudioId = S.StudioId
WHERE C.GenreId = @GenreId
GROUP BY S.StudioId, S.StudioName
ORDER BY AverageProfitPerMovie DESC
GO