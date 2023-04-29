CREATE OR ALTER PROCEDURE Movie.FetchPerson
	@PersonId INT
AS

SELECT P.FirstName, P.LastName
FROM Movie.People P
WHERE P.PersonId = @PersonId
GO