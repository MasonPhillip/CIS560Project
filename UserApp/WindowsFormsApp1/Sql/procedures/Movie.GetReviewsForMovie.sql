CREATE OR ALTER PROCEDURE Movie.GetReviewsForMovie
	@MovieId INT
AS

SELECT R.RatingDescription, R.MovieId, R.PersonalRating, R.AuthorUserId, R.RatingId
FROM Movie.PersonalRatings R
WHERE R.MovieId = @MovieId