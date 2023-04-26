CREATE OR ALTER PROCEDURE Movie.HighestPaidWithin
   @StartDate DATE,
   @EndDate DATE
AS

SELECT P.PersonId, P.FirstName, P.LastName, ISNULL(SUM(R.AmountPaid), 0.00) AS TotalAmountPaid
FROM Movie.People P
INNER JOIN
Movie.Roles R
On
R.PersonId = P.PersonId
INNER JOIN
Movie.Movies M
On
M.MovieId = R.MovieId
WHERE M.ReleaseDate > @StartDate AND M.ReleaseDate < @EndDate
GROUP BY P.PersonId, P.FirstName, P.LastName
ORDER By TotalAmountPaid
GO