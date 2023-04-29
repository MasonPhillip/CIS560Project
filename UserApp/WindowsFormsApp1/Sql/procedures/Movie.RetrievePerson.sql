CREATE OR ALTER PROCEDURE Movie.RetrievePerson
AS

SELECT P.PersonId, P.FirstName, P.LastName
FROM Movie.People P
ORDER BY P.LastName ASC;
GO