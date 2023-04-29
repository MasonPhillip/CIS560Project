CREATE OR ALTER PROCEDURE Movie.HighestPaidWithin
   @StartDate SMALLINT,
   @EndDate SMALLINT
AS

SELECT P.PersonId, P.FirstName, P.LastName, ISNULL(SUM(R.AmountPaid), 0.00) AS TotalAmountPaid
FROM Movie.People P
	INNER JOIN Movie.Roles R ON R.PersonId = P.PersonId
	INNER JOIN Movie.Movies M ON M.MovieId = R.MovieId
WHERE M.ReleaseDate > @StartDate AND M.ReleaseDate < @EndDate AND R.IsActor = 1 AND R.IsDirector = 0
GROUP BY P.PersonId, P.FirstName, P.LastName
ORDER By TotalAmountPaid DESC