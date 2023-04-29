CREATE OR ALTER PROCEDURE Movie.FetchRole
	@RoleId INT
AS

SELECT R.PersonId, R.MovieId, R.IsDirector, R.IsActor, R.AmountPaid
FROM Movie.Roles R
WHERE R.RoleId = @RoleId
GO