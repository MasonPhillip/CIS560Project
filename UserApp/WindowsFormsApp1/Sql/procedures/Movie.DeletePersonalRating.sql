CREATE OR ALTER PROCEDURE Movie.DeletePersonalRating
	@RatingId INT
AS
BEGIN
DELETE FROM Movie.PersonalRatings WHERE RatingId = @RatingId
END