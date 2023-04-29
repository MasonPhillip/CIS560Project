CREATE OR ALTER PROCEDURE Movie.RetrieveRole
AS

SELECT R.RoleId, R.PersonId, R.MovieId, R.IsDirector, R.IsActor, R.AmountPaid
FROM Movie.Roles R
ORDER BY R.AmountPaid ASC;
GO