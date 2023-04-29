CREATE OR ALTER PROCEDURE Movie.FetchPersonalRating
	@RatingId INT
AS

SELECT R.MovieId, R.AuthorUserId, R.PersonalRating, R.RatingDescription
FROM Movie.PersonalRatings R
WHERE R.RatingId = @RatingId
GO