CREATE OR ALTER PROCEDURE Movie.CreatePeople
   @FirstName VARCHAR(32),
   @LastName VARCHAR(32),
   @PersonId INT OUTPUT
AS

INSERT Movie.People(FirstName, LastName)
VALUES(@FirstName, @LastName);

SET @PersonId = SCOPE_IDENTITY();
GO