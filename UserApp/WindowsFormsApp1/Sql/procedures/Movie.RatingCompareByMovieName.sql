CREATE OR ALTER PROCEDURE Movie.RatingCompareByMovieName
   @MovieId INT
AS

SELECT PA.PersonId, PA.AddressTypeId, PA.Line1, PA.Line2,
   PA.City, PA.StateCode, PA.ZipCode
FROM Movie.Movies M
INNER JOIN

WHERE PA.PersonId = @PersonId;
GO